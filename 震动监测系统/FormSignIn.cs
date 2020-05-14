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
    public partial class FormSignIn : Form
    {
        CTMySql cTMySql;

        public FormSignIn()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 是否登录信号灯
        ///</summary>
        public bool signInFlag { get; set; }
        public bool adminFlag { get; set; }

        static Form1 f1 = new Form1();
        static Thread f1t = new Thread(F1Show);
        //登录按钮  点击
        private void btmSignIn_Click(object sender, EventArgs e)
        {
            string userAccount = txtbxAccount.Text;
            string userPassword = txtbxPassword.Text;
            bool a = cTMySql.CheckSignInPassword(userAccount, userPassword);//判断密码是否正确
            if (a)
            {
                MessageBox.Show("登陆成功");
                CTMySql.signInUserName = txtbxAccount.Text;
                if (f1t.IsAlive)
                {
                    f1.CloseAllMdiForms();
                    this.Close();
                    return;
                }
                else
                {
                    f1t.IsBackground = false;
                    f1t.Start();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("登陆失败");
            }
        }

        static void F1Show()
        {
            f1.ShowDialog();
        }

        //登陆页面  首次出现
        private void FormSignIn_Shown(object sender, EventArgs e)
        {
            cTMySql = new CTMySql("localhost", "root", "震动监测系统", "000000", "3306");//设置连接参数
            CTMySql.isSignIn = false;
            if (cTMySql.ConnectDatabass())//打开连接，判断连接是否成功
            {
                //MessageBox.Show("Success To Connect MySQL");
            }
            else
            {
                MessageBox.Show("Fail To Connect MySQL");
            }
        }

        //用户名输入框    按键按下
        private void txtbxAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断用户名输入是否合法
            Byte[] a = { 0 };
            Encoding.ASCII.GetBytes(e.KeyChar.ToString(), 0, 1, a, 0);//将按键字符转为ASCII码，存入数组a
            Console.WriteLine("keychar:" + e.KeyChar);
            Console.WriteLine("keyascii:" + a[0]);
            Console.WriteLine();
            int x = a[0];
            //判断字符是否合法
            if (
                   (x >= 65 && x <= 90)//允许大写字母
                   || (x >= 97 && x <= 122)//允许小写字母
                   || (x >= 48 && x <= 57)//允许数字
                   || (x == 8)//允许退格
                   || (x == 32)//允许空格
                   //|| (x == 46)//允许小数点
                   || (x == 95)//允许下划线
               )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                
            }
        }

        //密码输入框     按键按下
        private void txtbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判断密码输入是否合法
            Byte[] a = { 0 };
            Encoding.ASCII.GetBytes(e.KeyChar.ToString(), 0, 1, a, 0);//将按键字符转为ASCII码，存入数组a
            Console.WriteLine("keychar:" + e.KeyChar);
            Console.WriteLine("keyascii:" + a[0]);
            Console.WriteLine();
            int x = a[0];
            //判断字符是否合法
            if (
                   (x >= 65 && x <= 90)//允许大写字母
                   || (x >= 97 && x <= 122)//允许小写字母
                   || (x >= 48 && x <= 57)//允许数字
                   || (x == 8)//允许退格
                   //|| (x == 32)//允许空格
                   || (x == 46)//允许小数点
                   || (x == 95)//允许下划线
               )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
