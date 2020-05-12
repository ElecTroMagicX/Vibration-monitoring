using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
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
        //CTMySql cm = new CTMySql("localhost", "root", "震动监测系统", "000000", "3306");
        CTMySql cm = new CTMySql();

        static int[] timgap = { 0, 1, 5, 10, 25, 50, 100, 250, 500 };
        static string[] timlable = { "0", "2ms", "10ms", "20ms", "50ms", "100ms", "200ms", "500ms", "1000ms" };
        string tablename1 = "";
        string tablename2 = "";

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
            s = cm.GetAllDatatableName();
            for(int i = 0; i < s.Count - 1; i++)
            {
                this.listBox1.Items.Add(s[i]);
                this.listBox2.Items.Add(s[i]);
            }

            hScrollBar1.Enabled = false;    // init disable hSrollBar
            hScrollBar2.Enabled = false;    // init disable hSrollBar
            wave1_timegap_TrackBar.Enabled = false;
            wave2_timegap_TrackBar.Enabled = false;
        }

        // select data point and draw wave
        void SelectShowData(string tablename, ref PictureBox pictureBox)
        {        
            DrawWave dw = new DrawWave(ref pictureBox);

            ushort[] data;
            int gap;  //x axis timegap
            int datanum = (dw.boxSize.X - 40) / 5;
            gap = timgap[wave1_timegap_TrackBar.Value];
            data = new ushort[datanum];

            // set hScrollBar
            hScrollBar1.Maximum = ds.Tables[tablename].Rows.Count / gap - datanum;
            hScrollBar1.Minimum = 0;
            hScrollBar1.LargeChange = 1;
            hScrollBar1.SmallChange = 1;
            if (hScrollBar1.Maximum < 0) hScrollBar1.Maximum = 0;

            for(int i = 0; i < datanum; i++)
            {
                if (hScrollBar1.Maximum > 0) data[i] = (ushort)ds.Tables[tablename].Rows[i * gap + hScrollBar1.Value][2];
                else break;
            }

            dw.ClearToBackcolor(ref pictureBox);
            dw.DrawXaxis(ref pictureBox, 1, 5);
            dw.DrawYaxis(ref pictureBox, 1, 5);
            dw.Wave(ref data, ref pictureBox, 1, 1);
        }

        //波形显示1按钮    点击
        private void WaveShow1Button_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0)
            {
                MessageBox.Show("请选择需显示的数据", "请选择数据", MessageBoxButtons.OK);
                return;
            }
            tablename1 = listBox1.SelectedItem.ToString();
            try
            {
                ds.Tables.Add(cm.GetTableValue(tablename1));
            }
            catch (Exception)
            {

            }
            SelectShowData(tablename1, ref pictureBox1);

            hScrollBar1.Value = 0;
            hScrollBar1.Enabled = true;
            wave1_timegap_TrackBar.Enabled = true;
        }

        //波形显示2按钮   点击
        private void WaveShow2Button_Click(object sender, EventArgs e)
        {
        }

        // hScrollBar value changed
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            SelectShowData(tablename1, ref pictureBox1);
        }

        // trackBar value changed
        private void wave1_timegap_TrackBar_ValueChanged(object sender, EventArgs e)
        {
            wave1_timeshow_label.Text = timlable[wave1_timegap_TrackBar.Value];
            SelectShowData(tablename1, ref pictureBox1);
        }
    }
}
