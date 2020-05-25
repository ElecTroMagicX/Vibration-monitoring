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
            List<string> s;
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
        void SelectShowData(string tablename, ref PictureBox pictureBox, ref HScrollBar hScrollBar, ref TrackBar trackBar)
        {        
            DrawWave dw = new DrawWave(ref pictureBox);

            ushort[] data;
            int gap;  //x axis timegap
            int datanum = (dw.boxSize.X - 40) / 5;
            gap = timgap[trackBar.Value];
            data = new ushort[datanum];

            // set hScrollBar
            hScrollBar.LargeChange = 50 * gap;
            hScrollBar.SmallChange = 5 * gap;
            hScrollBar.Maximum = ds.Tables[tablename].Rows.Count - (datanum + 1) * gap;
            hScrollBar.Minimum = 0;
            if (hScrollBar.Maximum < 0) hScrollBar.Maximum = 0;

            for(int i = 0; i < datanum; i++)
            {
                try
                {
                    data[i] = (ushort)ds.Tables[tablename].Rows[i * gap + hScrollBar.Value][2];
                }
                catch (Exception)
                {
                    break;
                }
            }

            dw.ClearToBackcolor(ref pictureBox);
            dw.DrawXaxis(ref pictureBox, 1, 5);
            dw.DrawYaxis(ref pictureBox, 1, 5);
            dw.Wave(ref data, ref pictureBox, 1, 1);
        }

        //波形1显示按钮    点击
        private void WaveShow1Button_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Enabled == false && pictureBox1.Visible == false)
            {
                pictureBox1.Enabled = true;
                pictureBox1.Visible = true;
                hScrollBar1.Enabled = true;
            }
            if (dataGridView1.Enabled == true && dataGridView1.Visible == true)
            {
                dataGridView1.Visible = false;
                dataGridView1.Enabled = false;
            }
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
            catch (Exception) { }

            SelectShowData(tablename1, ref pictureBox1, ref hScrollBar1, ref wave1_timegap_TrackBar);

            hScrollBar1.Value = 0;
            hScrollBar1.Enabled = true;
            wave1_timegap_TrackBar.Enabled = true;
        }

        //波形2显示按钮   点击
        private void WaveShow2Button_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Enabled == false && pictureBox2.Visible == false)
            {
                pictureBox2.Enabled = true;
                pictureBox2.Visible = true;
                hScrollBar2.Enabled = true;
            }
            if (dataGridView2.Enabled == true && dataGridView2.Visible == true)
            {
                dataGridView2.Visible = false;
                dataGridView2.Enabled = false;
            }
            if (listBox2.SelectedIndex < 0)
            {
                MessageBox.Show("请选择需显示的数据", "请选择数据", MessageBoxButtons.OK);
                return;
            }

            tablename2 = listBox2.SelectedItem.ToString();

            try
            {
                ds.Tables.Add(cm.GetTableValue(tablename2));
            }
            catch (Exception) { }

            SelectShowData(tablename2, ref pictureBox2, ref hScrollBar2, ref wave2_timegap_TrackBar);

            hScrollBar2.Value = 0;
            hScrollBar2.Enabled = true;
            wave2_timegap_TrackBar.Enabled = true;
        }

        // hScrollBar1 value changed
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            SelectShowData(tablename1, ref pictureBox1, ref hScrollBar1, ref wave1_timegap_TrackBar);
        }

        // trackBar1 value changed
        private void wave1_timegap_TrackBar_ValueChanged(object sender, EventArgs e)
        {
            wave1_timeshow_label.Text = timlable[wave1_timegap_TrackBar.Value];
            SelectShowData(tablename1, ref pictureBox1, ref hScrollBar1, ref wave1_timegap_TrackBar);
        }

        private void hScrollBar2_ValueChanged(object sender, EventArgs e)
        {
            SelectShowData(tablename2, ref pictureBox2, ref hScrollBar2, ref wave2_timegap_TrackBar);
        }

        private void wave2_timegap_TrackBar_ValueChanged(object sender, EventArgs e)
        {
            wave2_timeshow_label.Text = timlable[wave2_timegap_TrackBar.Value];
            SelectShowData(tablename2, ref pictureBox2, ref hScrollBar2, ref wave2_timegap_TrackBar);
        }

        // dataGridView Init
        void InitDataGridView(DataGridView dg, string tn)
        {
            dg.DataSource = ds.Tables[tn];

            dg.AllowDrop = false;
            dg.AllowUserToAddRows = false;
            dg.AllowUserToDeleteRows = false;
            dg.ReadOnly = true;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void ListShow1Button_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Enabled == true && pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox1.Enabled = false;
                hScrollBar1.Enabled = false;
            }
            if (dataGridView1.Enabled == false && dataGridView1.Visible == false)
            {
                dataGridView1.Visible = true;
                dataGridView1.Enabled = true;
            }

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
            catch (Exception) { }

            InitDataGridView(dataGridView1, tablename1);
        }

        private void ListShow2Button_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Enabled == true && pictureBox2.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox2.Enabled = false;
                hScrollBar2.Enabled = false;
            }
            if (dataGridView2.Enabled == false && dataGridView2.Visible == false)
            {
                dataGridView2.Visible = true;
                dataGridView2.Enabled = true;
            }

            if (listBox2.SelectedIndex < 0)
            {
                MessageBox.Show("请选择需显示的数据", "请选择数据", MessageBoxButtons.OK);
                return;
            }

            tablename2 = listBox2.SelectedItem.ToString();

            try
            {
                ds.Tables.Add(cm.GetTableValue(tablename2));
            }
            catch (Exception) { }

            InitDataGridView(dataGridView2, tablename2);
        }
    }
}
