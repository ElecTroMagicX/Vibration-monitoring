using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 震动监测系统
{
    public partial class FormHistoryData : Form
    {
        DataSet ds = new DataSet();
        DataTable dt;
        CTMySql cm = new CTMySql("localhost", "root", "震动监测系统", "000000", "3306");

        public FormHistoryData()
        {
            InitializeComponent();
            InitListbox();
        }

        void InitListbox()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            List<string> s = null;
            s = cm.GetAllDatatable();
            for(int i = 0; i < s.Count - 1; i++)
            {
                this.listBox1.Items.Add(s[i]);
                this.listBox2.Items.Add(s[i]);
            }
        }

        //绘制波形
        void DrawHistoryWave(ref PictureBox pictureBox, ushort[] data)
        {
            DrawWave dw = new DrawWave(ref pictureBox);
            dw.ClearToBackcolor(ref pictureBox);
            dw.DrawXaxis(ref pictureBox, 1, 5);
            dw.DrawYaxis(ref pictureBox, 1, 5);
            dw.Wave(ref data, ref pictureBox, 1, 1);
        }

        void SelectShowData()

        //波形显示1按钮    点击
        private void WaveShow1Button_Click(object sender, EventArgs e)
        {
            string tablename = listBox1.SelectedItem.ToString();

            dt = new DataTable(tablename);
            ds.Tables.Add(dt);
        }

        //波形显示2按钮   点击
        private void WaveShow2Button_Click(object sender, EventArgs e)
        {

        }
    }
}
