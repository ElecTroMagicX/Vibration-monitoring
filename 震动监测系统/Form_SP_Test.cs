using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace 震动监测系统
{

    public partial class Form_SP_Test : Form
    {
        static bool flag1 = false;  //读串口数据线程信号灯
        
        public Form_SP_Test()
        {
            InitializeComponent();
        }

        //开始测试按钮    点击
        public void Button_sp_test_Click(object sender, EventArgs e)
        {
            button_sp_test_close.Focus();//焦点置于停止测试按钮
            button_sp_test_close.Enabled = true;//停止测试按钮    解锁
            button_sp_tests_start.Enabled = false;//开始测试按钮  锁定

            //开始读取串口数据线程
            Thread readData = new Thread(ReadSpData);//实例一个读取数据线程
            readData.IsBackground = true;//设置为后台线程
            readData.Priority = ThreadPriority.Highest;//设置线程优先级为高
            flag1 = true;//读数据线程信号灯通过
            readData.Start(4);//开始线程

            SendSpData("A");//给下位机发送开始发送数据信号
        }

        //连接测试窗口    出现
        public void Form_SP_Test_Shown(object sender, EventArgs e)
        {
            button_sp_tests_start.Focus();//焦点置于开始测试按钮
            button_sp_test_close.Enabled = false;//停止测试按钮    锁定
            boxtest_com_num.Text = controlconfig.valueItem("portnum");
            boxtest_bode_num.Text = controlconfig.valueItem("bodenum");
        }

        //停止测试按钮    点击
        private void button_sp_test_close_Click(object sender, EventArgs e)
        {
            flag1 = false;//停止读数据线程
            button_sp_test_close.Enabled = false;
            button_sp_tests_start.Enabled = true;
            //this.Close();
        }


        //连接测试窗口    关闭中
        private void Form_SP_Test_FormClosing(object sender, FormClosingEventArgs e)
        {
            flag1 = false;//停止读数据线程
        }

        //发送串口数据
        public void SendSpData(string sendData)
        {
            CTSerialPort.SendSP(sendData);
        }

        //读取串口数据    开始之前要先让信号灯通过
        public void ReadSpData(object readSize)
        {
            byte[] spData = new byte[4];
            int num = 0;

            CTSerialPort.ClearInBuffer();
            boxtest_result.Text = null;
            while (flag1)
            {
                if (CTSerialPort.ReadSP(ref spData, (int)readSize))
                {
                    for (int n = 0; n < 4; n++)
                    {
                        boxtest_result.AppendText(spData[n].ToString() + " ");
                        //boxtest_result.Text += spData[n].ToString();
                        //this.boxtest_result.Focus();//获取焦点
                        //this.boxtest_result.Select(this.boxtest_result.TextLength, 0);//光标定位到文本最后
                        //this.boxtest_result.ScrollToCaret();//滚动到光标处
                    }
                    //boxtest_result.Text += "  ";
                    //this.boxtest_result.Focus();//获取焦点
                    //this.boxtest_result.Select(this.boxtest_result.TextLength, 0);//光标定位到文本最后
                    //this.boxtest_result.ScrollToCaret();//滚动到光标处
                    System.DateTime currentTime = new System.DateTime();
                    currentTime = System.DateTime.Now;
                    Console.WriteLine("Min:" + currentTime.Minute.ToString() + "  Sec:" + currentTime.Second.ToString()
                        + "  MsecL" + currentTime.Millisecond.ToString() + "\r\n");
                    num++;
                }
                if (num >= 10)
                {
                    boxtest_result.Text += "\r\n测试成功\r\n";
                    flag1 = false;
                    SendSpData("E");
                    return;
                }
            }
            boxtest_result.Text += "\r\n测试失败，未接收到完整数据\r\n";
            SendSpData("E");
            return;
        }
    }
}
