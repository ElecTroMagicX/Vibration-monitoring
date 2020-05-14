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

namespace 震动监测系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //主界面显示
        private void Form1_Shown(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            //初始需处于锁定状态的功能
            {//用户组
                UserManage.Enabled = false;//用户管理按钮 锁定
                UserLogOut.Enabled = false;//退出登录按钮 锁定
                UserSwitch.Enabled = false;//切换用户按钮 锁定
            }
            {//通信组
                SP_Set.Enabled = false;//串口设置按钮     锁定
                SP_Ttest.Enabled = false;//连接测试按钮   锁定
                SP_Close.Enabled = false;//断开连接按钮   锁定
            }

            //窗口控件刷新
            Thread formreflash = new Thread(Form1Reflash);
            formreflash.IsBackground = true;
            formreflash.Start();
        }

        int xxxxxxx = 0;
        //控件刷新
        void Form1Reflash()
        {
            while (true)
            {
                Thread.Sleep(500);
                xxxxxxx++;
                //Console.WriteLine("From1 Reflash:{0}", xxxxxxx);
                /******************用户登录、管理员权限检测***************************************************************/
                if (CTMySql.isSignIn)   //用户已登录时
                {
                    UserLogOut.Enabled = true;//退出登录按钮 解锁
                    UserSwitch.Enabled = true;//切换用户按钮 解锁
                    UserSignIn.Enabled = false;//用户登录按钮 锁定

                    SP_Set.Enabled = true;//串口设置按钮 解锁
                }
                else    //用户未登录时
                {
                    UserManage.Enabled = false;//用户管理按钮 锁定
                    UserLogOut.Enabled = false;//退出登录按钮 锁定
                    UserSwitch.Enabled = false;//切换用户按钮 锁定
                    UserSignIn.Enabled = true;//用户登录按钮 解锁

                    SP_Set.Enabled = false;//串口设置按钮     锁定
                }
                if (CTMySql.isUserAdmin)    //用户是管理员用户时
                {
                    UserManage.Enabled = true;//用户管理按钮 解锁
                }
                else    //用户非管理员用户时
                {
                    UserManage.Enabled = false;//用户管理按钮 锁定
                }
                /****************串口开启检测********************************************************************************/
                if (CTSerialPort.IsComOpen())   //串口开启时
                {
                    this.SP_Ttest.Enabled = true;//连接测试按钮  解锁
                    this.SP_Close.Enabled = true;//断开连接按钮  解锁
                }
                else//串口关闭时
                {
                    this.SP_Ttest.Enabled = false;//连接测试按钮  锁定
                    this.SP_Close.Enabled = false;//断开连接按钮  锁定
                }
            }
        }

        //鼠标进入
        private void Form1_MouseEnter(object sender, EventArgs e)
        {

        }

        //参数设置按钮    点击
        private void SP_Set_Click(object sender, EventArgs e)
        {
            Form_SP_Set form_SP_Set = new Form_SP_Set();
            form_SP_Set.ShowDialog();
        }
        
        //测试连接按钮    点击
        private void SP_Ttest_Click(object sender, EventArgs e)
        {
            Form_SP_Test form_sp_test = new Form_SP_Test();
            form_sp_test.ShowDialog();
        }

        //断开连接按钮    点击
        private void SP_Close_Click(object sender, EventArgs e)
        {
            CTSerialPort.CloseSP();
        }

        //用户登录按钮    点击
        private void UserSignIn_Click(object sender, EventArgs e)
        {
            FormSignIn formSignIn = new FormSignIn();
            formSignIn.ShowDialog();
        }

        //退出登录按钮    点击
        private void UserLogOut_Click(object sender, EventArgs e)
        {
            CTMySql.isSignIn = false;
            CTMySql.isUserAdmin = false;
        }

        //切换用户按钮    点击
        private void UserSwitch_Click(object sender, EventArgs e)
        {
            CTMySql.isSignIn = false;
            FormSignIn formSignIn = new FormSignIn();
            formSignIn.ShowDialog();
        }

        //用户管理按钮    点击
        private void UserManage_Click(object sender, EventArgs e)
        {
            CloseAllMdiForms();
            if (CTMySql.isUserAdmin) 
            {
                FormUserManage fum = new FormUserManage();
                fum.MdiParent = this;
                fum.WindowState = FormWindowState.Maximized;
                fum.Show();
            }
            else
            {
                MessageBox.Show("此用户没有管理权限");
            }
        }

        //实时数据按钮    点击
        private void ButtonRealData_MyButtonClickEvent(object sender, EventArgs e)
        {
            CloseAllMdiForms();
            FormWave fw = new FormWave();
            Console.WriteLine("FormWave RealData have show.");
            fw.MdiParent = this;
            fw.WindowState = FormWindowState.Maximized;
            fw.Show();
        }

        //历史数据按钮    点击
        private void ButtonHistoryData_MyButtonClickEvent(object sender, EventArgs e)
        {
            CloseAllMdiForms();
            FormHistoryData fh = new FormHistoryData();
            Console.WriteLine("FormHistoryData have show.");
            fh.MdiParent = this;
            fh.WindowState = FormWindowState.Maximized;
            fh.Show();
        }

        //通信设置按钮    点击
        private void ButtonSeriportSet_MyButtonClickEvent(object sender, EventArgs e)
        {
            CloseAllMdiForms();
            Form_SP_Test fspt = new Form_SP_Test();
            fspt.MdiParent = this;
            fspt.WindowState = FormWindowState.Normal;
            fspt.Show();
            Form_SP_Set fsps = new Form_SP_Set();
            fsps.MdiParent = this;
            fsps.WindowState = FormWindowState.Normal;
            fsps.Show();
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        void CloseAllMdiForms()
        {
            if (this.MdiChildren.Length != 0)
            {
                int n = this.MdiChildren.Length;
                for (int i = 0; i < n; i++)
                {
                    this.MdiChildren[0].Close();
                }
            }
        }
    }
}
