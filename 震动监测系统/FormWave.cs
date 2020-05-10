using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Collections;

namespace 震动监测系统
{
    public partial class FormWave : Form
    {
        CTMySql cTMySql = new CTMySql();
        DataSet dtst = CTMySql.dtst;

        static string tablename = "";//定义数据表名时间前缀
        static bool manageReadDataFlag = false;//定义manageReadData线程信号灯标志
        static bool reflashWave1ThreadFlag = false;
        static bool reflashWave2ThreadFlag = false;

        public ArrayList list1 = new ArrayList(4500000);
        public ArrayList list2 = new ArrayList(4500000);

        struct wavepram
        {
            public int timegap;

            public int valuegap;
        };

        static wavepram wave1pram;
        static wavepram wave2pram;

        public FormWave()
        {
            InitializeComponent();
            wave1pram.timegap = 8;
            wave2pram.timegap = 8;
            wave1_timegap_TrackBar_Scroll(null, null);
            wave2_timegap_TrackBar_Scroll(null, null);
        }

        /// <summary>
        /// 开始按钮  点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStart_Click(object sender, EventArgs e)
        {
            //判断manageReadData线程是否在运行
            //如果是，则直接return
            //如果不是，继续下边动作
            if (manageReadDataFlag)
            {
                MessageBox.Show("already start!");
                return;
            }


            if (CTSerialPort.SetSP() && CTSerialPort.OpenSP())//判断串口是否能开启
            {
                tablename = DateTime.Now.ToString();//定义内存表名时间前缀
                cTMySql.CreateDSTable(tablename + "_channel1");//创建内存表
                cTMySql.CreateDSTable(tablename + "_channel2");//创建内存表
                CTSerialPort.SendSP("E");
                Thread.Sleep(10);
                CTSerialPort.ClearInBuffer();

                manageReadDataFlag = true;//线程红绿灯信号 通过
                Thread mrd = new Thread(ManageReadDataThread);//实例化ManageReadData线程
                mrd.IsBackground = true;//设为后台线程
                mrd.Start();//线程开始
                CTSerialPort.SendSP("A");//给下位机发送开始信号

                //波形1绘制线程
                reflashWave1ThreadFlag = true;
                Thread rfwave1 = new Thread(ReflashWave1Thread);
                rfwave1.IsBackground = true;
                rfwave1.Start(tablename + "_channel1");

                //波形2绘制线程
                reflashWave2ThreadFlag = true;
                Thread rfwave2 = new Thread(ReflashWave2Thread);
                rfwave2.IsBackground = true;
                rfwave2.Start(tablename + "_channel2");

                Console.WriteLine("开始接收数据");
            }
            else
            {
                MessageBox.Show("串口通信参数有误，请重新设置");
            }
        }

        /// <summary>
        /// 停止按钮    点击
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonStop_Click(object sender, EventArgs e)
        {
            manageReadDataFlag = false;
            reflashWave1ThreadFlag = false;
            reflashWave2ThreadFlag = false;
            DialogResult dg = MessageBox.Show("是：保留本次采集数据\n否：不保留本次采集数据", "储存数据确认", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dg == DialogResult.No)
            {
                dg = MessageBox.Show("是：不保留本采集数据！\n否：保留本次采集数据", "确认不保留数据", MessageBoxButtons.YesNo);
                if (dg == DialogResult.Yes)
                {
                    cTMySql.ClearDataSet();
                    return;
                }
            }
            FormSaveWaiting fsw = new FormSaveWaiting();
            fsw.ShowDialog();
        }


        //读取并转换串口数据的线程
        void ManageReadDataThread()
        {
            Console.WriteLine("开始接收数据线程");
            int dataID = 1, oldID = 0;//定义通道一和二的数据ID变量
            byte[] bt = new byte[200];//定义接收数据的byte数组
            string dateTime = "";
            UInt16[] channel1 = new UInt16[50];
            UInt16[] channel2 = new UInt16[50];
            //cTMySql.CreateNewTable(tablename + "_channel1");
            //cTMySql.CreateNewTable(tablename + "_channel2");

            while (manageReadDataFlag)
            {
                //object lockthis = new object();
                //lock (lockthis)
                //{
                    if (CTSerialPort.ReadSP(ref bt, ref dateTime, 200))
                    {
                        for (int i = 0; i < 50; i++)
                        {
                            byte temp = 0;

                            temp = bt[i * 4];
                            bt[i * 4] = bt[i * 4 + 1];
                            bt[i * 4 + 1] = temp;

                            channel1[i] = BitConverter.ToUInt16(bt, i * 4);

                            temp = bt[i * 4 + 2];
                            bt[i * 4 + 2] = bt[i * 4 + 3];
                            bt[i * 4 + 3] = temp;

                            channel2[i] = BitConverter.ToUInt16(bt, i * 4 + 2);
                        }
                    list1.AddRange(channel1);
                    list2.AddRange(channel2);

                        textBox1.AppendText(string.Join(" ", channel1));
                        textBox2.AppendText(string.Join(" ", channel2));

                        cTMySql.InsertData2DSTable(tablename + "_channel1", dataID, dateTime.ToString(), ref channel1);
                        cTMySql.InsertData2DSTable(tablename + "_channel2", dataID, dateTime.ToString(), ref channel2);
                    //if (dataID - oldID >= 100)
                    //{
                    //    oldID = dataID;
                    //    cTMySql.AddOrUpdataTableFromDataset2Databass(tablename + "_channel1");
                    //    cTMySql.AddOrUpdataTableFromDataset2Databass(tablename + "_channel2");
                    //}
                    dataID += 50;
                }

                //}
            }
            manageReadDataFlag = false;//线程结束后将信号灯标志置为禁止
        }

        public void ReflashWave1Thread(object _tn)
        {
            string tn = (string)_tn;
            int gap = 500;
            DrawWave dw = new DrawWave(ref pictureBox1);
            DataTable dttb = dtst.Tables[tn];
            while (reflashWave1ThreadFlag)
            {
                lock (DrawWave.wavelock)
                {
                    gap = wave1pram.timegap;
                    try
                    {
                        int num = dttb.Rows.Count;
                        num -= (dw.boxSize.X - 40) / 5 * gap;
                        UInt16[] data = new UInt16[(dw.boxSize.X - 40) / 5];
                        if (num >= 1)
                        {
                            for (int i = 0; i < (dw.boxSize.X - 40) / 5; i++)
                            {
                                data[i] = (UInt16)dttb.Rows[num - 1 + i * gap]["DataValue"];
                            }
                            dw.Wave(ref data, ref pictureBox1, 1, 1);
                        }
                        else
                        {
                            int num0 = dttb.Rows.Count / gap;
                            UInt16[] data0 = new UInt16[num0];
                            for (int i = 0; i < num0; i++)
                            {
                                data0[i] = (UInt16)dttb.Rows[i * gap]["DataValue"];
                            }
                            dw.Wave(ref data0, ref pictureBox1, 1, 1);
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                Thread.Sleep(100);
            }
        }

        public void ReflashWave2Thread(object _tn)
        {
            string tn = (string)_tn;
            int gap = 500;
            DrawWave dw = new DrawWave(ref pictureBox2);
            DataTable dttb = dtst.Tables[tn];
            while (reflashWave2ThreadFlag)
            {
                lock (DrawWave.wavelock)
                {
                    gap = wave2pram.timegap;
                    try
                    {
                        int num = dttb.Rows.Count;
                        num -= (dw.boxSize.X - 40) / 5 * gap;
                        UInt16[] data = new UInt16[(dw.boxSize.X - 40) / 5];
                        if (num >= 51)
                        {
                            for (int i = 0; i < (dw.boxSize.X - 40) / 5; i++)
                            {
                                //int average = 0;
                                //for (int j = 0; j < gap; j++)
                                //{
                                //    average += (UInt16)dttb.Rows[num - 51 + i * gap + j]["DataValue"];
                                //}
                                //average = average / gap;
                                //data[i] = (UInt16)average;
                                data[i] = (UInt16)dttb.Rows[num - 1 + i * gap]["DataValue"];
                            }
                            dw.Wave(ref data, ref pictureBox2, 1, 1);
                        }
                        else
                        {
                            int num0 = dttb.Rows.Count / gap;
                            UInt16[] data0 = new UInt16[num0];
                            for (int i = 0; i < num0; i++)
                            {
                                data0[i] = (UInt16)dttb.Rows[i * gap]["DataValue"];
                            }
                            dw.Wave(ref data0, ref pictureBox2, 1, 1);
                        }
                    }
                    catch (Exception)
                    {
                    }
                }
                Thread.Sleep(100);
            }
        }


        private void wave1_timegap_TrackBar_Scroll(object sender, EventArgs e)
        {
            int trackbarValue = wave1_timegap_TrackBar.Value;
            switch (trackbarValue)
            {
                case 1:
                    wave1pram.timegap = 1;
                    wave1_timeshow_label.Text = "2 ms";
                    break;
                case 2:
                    wave1pram.timegap = 5;
                    wave1_timeshow_label.Text = "10 ms";
                    break;
                case 3:
                    wave1pram.timegap = 10;
                    wave1_timeshow_label.Text = "20 ms";
                    break;
                case 4:
                    wave1pram.timegap = 25;
                    wave1_timeshow_label.Text = "50 ms";
                    break;
                case 5:
                    wave1pram.timegap = 50;
                    wave1_timeshow_label.Text = "100 ms";
                    break;
                case 6:
                    wave1pram.timegap = 100;
                    wave1_timeshow_label.Text = "200 ms";
                    break;
                case 7:
                    wave1pram.timegap = 250;
                    wave1_timeshow_label.Text = "500 ms";
                    break;
                case 8:
                    wave1pram.timegap = 500;
                    wave1_timeshow_label.Text = "1000 ms";
                    break;
                default:
                    break;
            }
        }

        private void wave2_timegap_TrackBar_Scroll(object sender, EventArgs e)
        {
            int trackbarValue = wave2_timegap_TrackBar.Value;
            switch (trackbarValue)
            {
                case 1:
                    wave2pram.timegap = 1;
                    wave2_timeshow_label.Text = "2 ms";
                    break;
                case 2:
                    wave2pram.timegap = 5;
                    wave2_timeshow_label.Text = "10 ms";
                    break;
                case 3:
                    wave2pram.timegap = 10;
                    wave2_timeshow_label.Text = "20 ms";
                    break;
                case 4:
                    wave2pram.timegap = 25;
                    wave2_timeshow_label.Text = "50 ms";
                    break;
                case 5:
                    wave2pram.timegap = 50;
                    wave2_timeshow_label.Text = "100 ms";
                    break;
                case 6:
                    wave2pram.timegap = 100;
                    wave2_timeshow_label.Text = "200 ms";
                    break;
                case 7:
                    wave2pram.timegap = 250;
                    wave2_timeshow_label.Text = "500 ms";
                    break;
                case 8:
                    wave2pram.timegap = 500;
                    wave2_timeshow_label.Text = "1000 ms";
                    break;
                default:
                    break;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}

