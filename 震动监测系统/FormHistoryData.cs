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
            for(int i = 1; i < s.Count; i++)
            {
                this.listBox1.Items.Add(s[i]);
                this.listBox2.Items.Add(s[i]);
            }
        }

        void DrawHistoryWave()
        {
            DrawWave dw1 = new DrawWave(ref pictureBox1);
            DrawWave dw2 = new DrawWave(ref pictureBox2);
            dw1.GetBoxSize(ref pictureBox1);
            dw2.GetBoxSize(ref pictureBox2);
        }
    }
}
