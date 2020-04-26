using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 震动监测系统
{
    class DrawWave
    {
        public Point boxSize;
        public Bitmap bp;
        public static object wavelock = new object();

        public DrawWave(ref System.Windows.Forms.PictureBox box)
        {
            GetBoxSize(ref box);
        }

        public void GetBoxSize(ref System.Windows.Forms.PictureBox box)
        {
            boxSize.X = box.Width;
            boxSize.Y = box.Height;

            bp = new Bitmap(box.Width, box.Height);
        }

        /// <summary>
        /// 绘制X坐标刻度线的方法
        /// </summary>
        /// <param name="box">所需绘制的pictureBox窗体</param>
        /// <param name="axisType">轴类型：0 直线+主坐标，1 直线+主坐标+副坐标，2 主坐标，3 主坐标+副坐标</param>
        /// <param name="axisMark">轴刻度</param>
        public void DrawXaxis(ref System.Windows.Forms.PictureBox box, int axisType, int axisMark)
        {
            Graphics g;
            g = Graphics.FromImage(bp);//创建画板
            
            Pen py1 = new Pen(Color.Yellow, 1);//定义画笔

            Point axisStart = new Point();//轴坐标起点
            axisStart.X = 20;
            axisStart.Y = boxSize.Y - 20;

            int axisLenth = boxSize.X - 40;//轴长度

            //画主坐标
            for (int i = 0; i < axisLenth; i+=axisMark*5)
            {
                g.DrawLine(py1, axisStart.X + i, axisStart.Y - 4, axisStart.X + i, axisStart.Y + 4);
            }

            if (axisType == 1 || axisType == 3)
            {
                //画副坐标
                for (int i = 0; i < axisLenth; i += axisMark)
                {
                    g.DrawLine(py1, axisStart.X + i, axisStart.Y - 2, axisStart.X + i, axisStart.Y + 2);
                }
            }

            if (axisType == 0 || axisType == 1)
            {
                //画直线
                g.DrawLine(py1, axisStart.X, axisStart.Y, axisStart.X + axisLenth, axisStart.Y);
            }

            box.Image = bp;

            g.Dispose();
            py1.Dispose();
        }

        /// <summary>
        /// 绘制Y坐标刻度线的方法
        /// </summary>
        /// <param name="box">所需绘制的pictureBox窗体</param>
        /// <param name="axisType">轴类型：0 直线+主坐标，1 直线+主坐标+副坐标，2 主坐标，3 主坐标+副坐标</param>
        /// <param name="axisMark">轴刻度</param>
        public void DrawYaxis(ref System.Windows.Forms.PictureBox box, int axisType, int axisMark)
        {
            Graphics g;
            g = Graphics.FromImage(bp);//创建画板
            Pen py1 = new Pen(Color.Yellow, 1);

            Point axisStart = new Point();//轴坐标起点
            axisStart.X = 20;
            axisStart.Y = boxSize.Y - 20;

            int axisLenth = boxSize.Y - 40;//轴长度

            //画主坐标
            for (int i = 0; i < axisLenth; i += axisMark*5)
            {
                g.DrawLine(py1, axisStart.X - 4, axisStart.Y - i, axisStart.X + 4, axisStart.Y - i);
            }

            if (axisType == 1 || axisType == 3)
            {
                //画副坐标
                for (int i = 0; i < axisLenth; i += axisMark)
                {
                    g.DrawLine(py1, axisStart.X - 2, axisStart.Y - i, axisStart.X + 2, axisStart.Y - i);
                }
            }

            if (axisType == 0 || axisType == 1)
            {
                //画直线
                g.DrawLine(py1, axisStart.X, axisStart.Y, axisStart.X, axisStart.Y - axisLenth);
            }

            box.Image = bp;

            g.Dispose();
            py1.Dispose();
        }

        /// <summary>
        /// 绘制波形的方法
        /// </summary>
        /// <param name="data">数据</param>
        /// <param name="box">需要绘制的图片盒子</param>
        /// <param name="Xmark">时间轴主坐标标度</param>
        /// <param name="timeType">时间类型</param>
        public void Wave(ref UInt16[] data, ref System.Windows.Forms.PictureBox box, int Xmark, int timeType)
        {
            Graphics g;
            g = Graphics.FromImage(bp);//创建画板
            Pen pwave = new Pen(Color.YellowGreen, 1);

            int num = data.Length;
            //UInt16 max = data.Max(), min = data.Min();
            Point startPoint = new Point(20, boxSize.Y - 20);
            Point maxPoint = new Point(boxSize.X - 20, 20);

            int xPointNum = (boxSize.X - 40) / 5 + 1;

            ClearToBackcolor(ref box); 
            DrawXaxis(ref box, 1, 5);
            DrawYaxis(ref box, 1, 5);
            if (num <= xPointNum)   //data num <= x axis point num
            {
                for (int i = 0; i < num-1; i++)
                {
                    float yLess1 = (float)data[i] / 65535 * (boxSize.Y - 40);
                    float yLess2 = (float)data[i+1] / 65535 * (boxSize.Y - 40);
                    g.DrawLine(pwave, startPoint.X + i * 5, startPoint.Y - yLess1, startPoint.X + (i + 1) * 5, startPoint.Y - yLess2);
                }
            }
            else    //data num > x axis point num
            {
                for (int i = num - xPointNum; i < num-1; i++)
                {
                    float yLess1 = (float)data[i] / 65535 * (boxSize.Y - 40);
                    float yLess2 = (float)data[i + 1] / 65535 * (boxSize.Y - 40);
                    g.DrawLine(pwave, startPoint.X + i * 5, startPoint.Y - yLess1, startPoint.X + (i + 1) * 5, startPoint.Y - yLess2);
                }
            }

            box.Image = bp;

            g.Dispose();
            pwave.Dispose();
        }
        public void Wave(ref UInt16 data, ref System.Windows.Forms.PictureBox box, int Xmark, int timeType)
        {
            Graphics g;
            g = Graphics.FromImage(bp);//创建画板
            Pen pwave = new Pen(Color.YellowGreen, 1);

            Point startPoint = new Point(20, boxSize.Y - 20);
            Point maxPoint = new Point(boxSize.X - 20, 20);

            int xPointNum = (boxSize.X - 40) / 5 + 1;

            ClearToBackcolor(ref box);
            DrawXaxis(ref box, 1, 5);
            DrawYaxis(ref box, 1, 5);

            box.Image = bp;

            g.Dispose();
            pwave.Dispose();
        }

        /// <summary>
        /// Clear bitmap to box.ackColor
        /// </summary>
        /// <param name="box"></param>
        public void ClearToBackcolor(ref System.Windows.Forms.PictureBox box)
        {
            Graphics g;
            g = Graphics.FromImage(bp);//创建画板

            g.Clear(box.BackColor);

            g.Dispose();
        }
    }
}
