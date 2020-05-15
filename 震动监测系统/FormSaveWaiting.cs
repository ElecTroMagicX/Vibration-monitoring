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
    public partial class FormSaveWaiting : Form
    {
        static public int pv1 = 0;
        CTMySql cm = new CTMySql();
        static public object tLock = new object();

        public FormSaveWaiting()
        {
            InitializeComponent();

            int dtstnum = CTMySql.dtst.Tables.Count;
            cm.CreateNewTable(CTMySql.dtst.Tables[dtstnum - 2].TableName);
            cm.CreateNewTable(CTMySql.dtst.Tables[dtstnum - 1].TableName);

            Thread T1 = new Thread(D1);
            Thread T2 = new Thread(D2);
            T1.IsBackground = true;
            T2.IsBackground = true;
            T1.Start();
            T2.Start();

            Thread wt = new Thread(w);
            wt.IsBackground = true;
            wt.Start();
        }

        void D1()
        {
            int dtstnum = CTMySql.dtst.Tables.Count;
            SaveDelet1 sd1 = new SaveDelet1(CTMySql.dtst.Tables[dtstnum - 2].TableName);
            sd1.Savep();
        }
        void D2()
        {
            int dtstnum = CTMySql.dtst.Tables.Count;
            SaveDelet2 sd2 = new SaveDelet2(CTMySql.dtst.Tables[dtstnum - 1].TableName);
            sd2.Savep();
        }

        void w()
        {
            int o = pv1, v = 0;
            while (pv1 != 100)
            {
                if (0 != pv1)
                {
                    o = (pv1 + o) / 2;
                    //o = pv1;
                }
                progressBar1.Value = o;

                label1.Text = o.ToString();
                Thread.Sleep(100);
            }
            progressBar1.Value = 100;
            label1.Text = "储存完成";
        }
    }

    class SaveDelet1
    {
        CTMySql cm = new CTMySql();
        DataTable dt;

        string tn;

        public SaveDelet1(string _tn)
        {
            tn = _tn;
            dt = CTMySql.dtst.Tables[_tn];
        }

        public void Savep()
        {
            int num = 100, start = 0, all, loop;
            all = dt.Rows.Count;
            if (all <= 100)
            {
                loop = 1;
            }
            else
            {
                loop = all / 100 + 1;
            }
            for (int i = 0; i < loop; i++)
            {
                lock (FormSaveWaiting.tLock)
                {
                    if (i == loop - 1)
                    {
                        if (loop != 1)
                        {
                            cm.AddOrUpdataTableFromDataset2Databass(tn, all % (loop - 1), start);
                        }
                    }
                    else
                    {
                        cm.AddOrUpdataTableFromDataset2Databass(tn, num, start);
                        start += num;
                    }
                    FormSaveWaiting.pv1 = i * 100 / loop;
                }
            }
            Delet();
            FormSaveWaiting.pv1 = 100;
        }

        private void Delet()
        {
            CTMySql.dtst.Tables[tn].Clear();
        }
    }

    class SaveDelet2
    {
        CTMySql cm = new CTMySql();
        DataTable dt;

        string tn;

        public SaveDelet2(string _tn)
        {
            tn = _tn;
            dt = CTMySql.dtst.Tables[_tn];
        }

        public void Savep()
        {
            int num = 100, start = 0, all, loop;
            all = dt.Rows.Count;
            if (all <= 100)
            {
                loop = 1;
            }
            else
            {
                loop = all / 100 + 1;
            }
            for (int i = 0; i < loop; i++)
            {
                lock (FormSaveWaiting.tLock)
                {
                    if (i == loop - 1)
                    {
                        if (loop != 1)
                        {
                            cm.AddOrUpdataTableFromDataset2Databass(tn, all % (loop - 1), start);
                        }
                    }
                    else
                    {
                        cm.AddOrUpdataTableFromDataset2Databass(tn, num, start);
                        start += num;
                    }
                    FormSaveWaiting.pv1 = i * 100 / loop;
                }
            }
            Delet();
            FormSaveWaiting.pv1 = 100;
        }

        private void Delet()
        {
            CTMySql.dtst.Tables[tn].Clear();
        }
    }
}
