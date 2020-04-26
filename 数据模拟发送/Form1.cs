using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Pipes;

namespace 数据模拟发送
{
    public partial class MainForm : Form
    {
        static bool openThreadFlag = false;
        static bool raFlag = false;
        static int rangflag = 0;
        static bool sendFlag = false;
        static bool readbstopflag = false;
        static bool readastopflag = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("1111111111111111");
            Control.CheckForIllegalCrossThreadCalls = false;
            if (controlconfig.existItem("porttxt")
                && controlconfig.existItem("bodetxt")
                && controlconfig.existItem("datatxt")
                && controlconfig.existItem("stoptxt")
                && controlconfig.existItem("range1txt")
                && controlconfig.existItem("mid1txt")
                && controlconfig.existItem("range2txt")
                && controlconfig.existItem("mid2txt")
                && controlconfig.existItem("lineValtxt")
                && controlconfig.existItem("timetxt"))
            {
                porttxt.Text = controlconfig.valueItem("porttxt");
                bodetxt.Text = controlconfig.valueItem("bodetxt");
                datatxt.Text = controlconfig.valueItem("datatxt");
                stoptxt.Text = controlconfig.valueItem("stoptxt");
                range1txt.Text = controlconfig.valueItem("range1txt");
                mid1txt.Text = controlconfig.valueItem("mid1txt");
                range2txt.Text = controlconfig.valueItem("range2txt");
                mid2txt.Text = controlconfig.valueItem("mid2txt");
                lineValtxt.Text = controlconfig.valueItem("lineValtxt");
                timetxt.Text = controlconfig.valueItem("timetxt");
            }
            else
            {
                porttxt.Text = "COM5";
                bodetxt.Text = "115200";
                datatxt.Text = "8";
                stoptxt.Text = "1";
                range1txt.Text = "10000";
                mid1txt.Text = "30000";
                range2txt.Text = "1000";
                mid2txt.Text = "30000";
                lineValtxt.Text = "30000";
                timetxt.Text = "1000";
            }
            button1.Focus();
        }

        public void NTextChanged(TextBox txt)
        {
            controlconfig.AddOrModifyItem(txt.Name, txt.Text);
        }

        private void porttxt_TextChanged(object sender, EventArgs e)
        {
            NTextChanged(porttxt);
        }

        private void bodetxt_TextChanged(object sender, EventArgs e)
        {
            NTextChanged(bodetxt);
        }

        private void datatxt_TextChanged(object sender, EventArgs e)
        {
            NTextChanged(datatxt);
        }

        private void stoptxt_TextChanged(object sender, EventArgs e)
        {
            NTextChanged(stoptxt);
        }

        private void range1txt_TextChanged(object sender, EventArgs e)
        {
            NTextChanged(range1txt);
        }

        private void mid1txt_TextChanged(object sender, EventArgs e)
        {
            NTextChanged(mid1txt);
        }

        private void range2txt_TextChanged(object sender, EventArgs e)
        {
            NTextChanged(range2txt);
        }

        private void mid2txt_TextChanged(object sender, EventArgs e)
        {
            NTextChanged(mid2txt);
        }

        private void lineValtxt_TextChanged(object sender, EventArgs e)
        {
            NTextChanged(lineValtxt);
        }

        private void timetxt_TextChanged(object sender, EventArgs e)
        {
            NTextChanged(timetxt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controlconfig.AddOrModifyItem(porttxt.Name, porttxt.Text);
            controlconfig.AddOrModifyItem(bodetxt.Name, bodetxt.Text);
            controlconfig.AddOrModifyItem(datatxt.Name, datatxt.Text);
            controlconfig.AddOrModifyItem(stoptxt.Name, stoptxt.Text);
            controlconfig.AddOrModifyItem(range1txt.Name, range1txt.Text);
            controlconfig.AddOrModifyItem(mid1txt.Name, mid1txt.Text);
            controlconfig.AddOrModifyItem(range2txt.Name, range2txt.Text);
            controlconfig.AddOrModifyItem(mid2txt.Name, mid2txt.Text);
            controlconfig.AddOrModifyItem(lineValtxt.Name, lineValtxt.Text);
            controlconfig.AddOrModifyItem(timetxt.Name, timetxt.Text);
            if (button1.Text == "Start")
            {
                Thread op = new Thread(OpenSP);
                op.IsBackground = true;
                op.Start();
                openThreadFlag = true;
                button1.Text = "Stop";
            }
            else
            {
                if (CTSerialPort.IsComOpen())
                {
                    readbstopflag = true;
                    readastopflag = true;
                    sendFlag = false;
                    Thread.Sleep(200);
                    CTSerialPort.CloseSP();
                    readbstopflag = false;
                    readastopflag = false;
                }
                openThreadFlag = false;
                readastopflag = true;
                Thread.Sleep(200);
                readastopflag = false;
                button1.Text = "Start";
            }
        }

        private void linebut_Click(object sender, EventArgs e)
        {
            rangflag = 0;
        }

        void OpenSP()
        {
            while (!CTSerialPort.IsComOpen())
            {
                CTSerialPort.SetSP(controlconfig.valueItem("porttxt"),
                   controlconfig.valueItem("bodetxt"),
                   controlconfig.valueItem("datatxt"),
                   controlconfig.valueItem("stoptxt"));
                Thread.Sleep(20);
                try
                {
                    CTSerialPort.OpenSP();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("fail to open {0}", porttxt.Text);
                }
            }
            //Thread ra = new Thread(ReadA);
            //openThreadFlag = false;
            //ra.IsBackground = true;
            //ra.Start();

            Thread sd = new Thread(SendRandData);
            sd.IsBackground = true;
            sendFlag = true;
            sd.Start();
        }

        void ReadA()
        {
            byte[] bt = new byte[1024];
            while (!CTSerialPort.ReadSP(ref bt, 1) && bt[0].ToString() != "A" && !readastopflag)
            {
                Thread.Sleep(20);
            }
            Console.WriteLine("A Secces", bt[0].ToString());
            Thread rb = new Thread(ReadB);
            rb.IsBackground = true;
            raFlag = true;
            rb.Start();
            Thread sd = new Thread(SendRandData);
            sd.IsBackground = true;
            sendFlag = true;
            sd.Start();
        }

        void ReadB()
        {
            byte[] bt = new byte[1024];
            while ((!CTSerialPort.ReadSP(ref bt, 1) && bt[0].ToString() != "B") && !readbstopflag)
            {
                Thread.Sleep(20);
            }
            Console.WriteLine("B Secces", bt[0].ToString());
            raFlag = false;
            sendFlag = false;
        }

        void SendRandData()
        {
            while (sendFlag)
            {
                UInt16 r1 = Convert.ToUInt16(controlconfig.valueItem(range1txt.Name));
                UInt16 r2 = Convert.ToUInt16(controlconfig.valueItem(range2txt.Name));
                UInt16 m1 = Convert.ToUInt16(controlconfig.valueItem(mid1txt.Name));
                UInt16 m2 = Convert.ToUInt16(controlconfig.valueItem(mid2txt.Name));
                UInt16 line = Convert.ToUInt16(controlconfig.valueItem(lineValtxt.Name));
                byte[] bt;
                switch (rangflag)
                {
                    case 0:
                        bt = RandR(0, line);
                        CTSerialPort.SendSP(bt);
                        break;
                    case 1:
                        bt = RandR(r1, m1);
                        CTSerialPort.SendSP(bt);
                        break;
                    case 2:
                        bt = RandR(r2, m2);
                        CTSerialPort.SendSP(bt);
                        break;
                }
                int a = Convert.ToInt32(controlconfig.valueItem(timetxt.Name));
                Thread.Sleep(a);
            }
        }

        private void rand1but_Click(object sender, EventArgs e)
        {
            rangflag = 1;
        }

        private void rand2but_Click(object sender, EventArgs e)
        {
            rangflag = 2;
        }

        byte[] RandR(UInt16 range, UInt16 mid)
        {
            Random r = new Random();
            UInt16 s = (UInt16)r.Next(mid - range / 2, mid + range / 2);
            byte[] bt = BitConverter.GetBytes(s);
            byte temp = bt[1];
            bt[1] = bt[0];
            bt[0] = temp;
            //textBox1.Text += s.ToString();
            //textBox1.Text += " ";
            textBox1.AppendText(s.ToString() + " ");
            return bt;
        }
    }
}
