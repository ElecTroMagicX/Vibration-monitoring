using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsControlLibrary1
{
    public partial class MyButton: UserControl
    {
        static Point pt;

        public MyButton()
        {
            InitializeComponent();
        }

        

        [Browsable(true), Category("自定义属性")]
        [Description("设置按钮文本")]
        public string TextAll
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
            }
        }

        [Browsable(true), Category("自定义属性")]
        [Description("设置按钮文本颜色")]
        public Color FontColorAll
        {
            get
            {
                return label1.ForeColor;
            }
            set
            {
                label1.ForeColor = value;
            }
        }

        [Browsable(true),Category("自定义属性")]
        [Description("设置背景图片")]
        public Image BackGroundImageAll
        {
            get
            {
                return pictureBox1.BackgroundImage;
            }
            set
            {
                pictureBox1.BackgroundImage = value;
            } 
        }

        [Browsable(true), Category("自定义属性")]
        [Description("设置背景图片匹配形式")]
        public ImageLayout BackgroundImageLayoutAll
        {
            get { return pictureBox1.BackgroundImageLayout; }
            set { pictureBox1.BackgroundImageLayout = value; }
        }

        [Browsable(true), Category("自定义属性")]
        [Description("设置背景颜色")]
        public Color BackColotAll
        {
            get
            {
                return this.BackColor;
            }
            set
            {
                this.BackColor = value;
            }
        }

        private void MyButton_Paint(object sender, PaintEventArgs e)
        {
            //设置label水平居中，高度处于58/80
            pt = new Point(this.Width, this.Height);
            pt.X = (pt.X - label1.Width) / 2;
            pt.Y = pt.Y * 58 / 80;
            label1.Location = pt;

            //设置picture水平居中，高度60/80
            Point a = new Point(3, 3);
            pictureBox1.Location = a;
            Size size = new Size(this.Width - 6, this.Height * 60 / 80);
            pictureBox1.Size = size;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;

            //设置button大小与All相等
            size = new Size(this.Width, this.Height);
        }

        
        public delegate void MyButtonClickHandle(object sender, EventArgs e);//委托声明
        [Category("自定义事件")]
        public event MyButtonClickHandle MyButtonClickEvent;//事件声明

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MyButtonClickEvent != null)
            {
                MyButtonClickEvent(sender, new EventArgs());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MyButtonClickEvent != null)
            {
                MyButtonClickEvent(sender, new EventArgs());
            }
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            if (MyButtonClickEvent != null)
            {
                MyButtonClickEvent(sender, new EventArgs());
            }
        }
    }
}
