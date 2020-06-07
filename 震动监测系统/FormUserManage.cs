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
    public partial class FormUserManage : Form
    {
        public FormUserManage()
        {
            InitializeComponent();
            InitForm();
        }

        void InitForm()
        {

            #region 初始锁定控件
            //初始锁定控件
            NewUserNameTextbox.Enabled = false;
            NewUserPasswordTextbox.Enabled = false;
            NewUserAdminNoRadioButton.Enabled = false;
            NewUserAdminYesRadioButton.Enabled = false;

            NewUserAddButton.Enabled = false;

            UserNameTextbox.Enabled = false;
            ChangeAdminNoRadioButton.Enabled = false;
            ChangeAdminYesRadioButton.Enabled = false;
            DeletUserButton.Enabled = false;
            ShowPasswordButton.Enabled = false;
            ShowPasswordTextbox.Enabled = false;
            ChangePasswordButton.Enabled = false;
            ChangePasswordTextbox.Enabled = false;
            #endregion

            #region 获取所有用户信息
            //获取所有用户信息
            UserListView.BeginUpdate();

            UserListView.View = View.Details;
            UserListView.Clear();
            UserListView.Columns.Add("用户名（双击选择用户）", 200, HorizontalAlignment.Right);
            UserListView.Columns.Add("管理员", 50, HorizontalAlignment.Center);
            UserListView.FullRowSelect = true;

            DataTable dt = new DataTable("Account");
            CTMySql cm = new CTMySql();

            dt = cm.GetTableValue("Account");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name;
                ulong admin;
                name = (string)dt.Rows[i]["Account"];
                admin = (ulong)dt.Rows[i]["Level"];

                ListViewItem lvi = new ListViewItem();
                lvi.Text = name;
                if (admin == 1)
                {
                    lvi.SubItems.Add("是");
                }
                else
                {
                    lvi.SubItems.Add("否");
                }
                UserListView.Items.Add(lvi);
            }
            UserListView.EndUpdate();
            #endregion

            #region 检测管理员权限
            if(!CTMySql.isUserAdmin)
            {
                UserListView.Enabled = false;
                NewUserButton.Enabled = false;
            }
            #endregion
        }


        struct PanelAndControlSize
        {
            public int parentX;
            public int parentY;
            public int controlX;
            public int controlY;
        };
        PanelAndControlSize PCSNewUserButton;

        PanelAndControlSize PCSNewUserNameLable;
        PanelAndControlSize PCSNewUserPassWordLable;
        PanelAndControlSize PCSNewUserAdminLable;
        PanelAndControlSize PCSNewUserNameTextbox;
        PanelAndControlSize PCSNewUserPassWordTextbox;
        PanelAndControlSize PCSNewUserAdminYesRadioButton;
        PanelAndControlSize PCSNewUserAdminNoRadioButton;

        PanelAndControlSize PCSNewUserAddButton;

        PanelAndControlSize PCSUserNameLable;
        PanelAndControlSize PCSUserNameTextbox;

        PanelAndControlSize PCSChangeAdminLable;
        PanelAndControlSize PCSChangeAdminYesRadioButton;
        PanelAndControlSize PCSChangeAdminNoRadioButton;

        PanelAndControlSize PCSDeletUserButton;

        #region 获取控件及父控件的尺寸
        void PCS_Get(ref Panel parent, ref Button control, ref PanelAndControlSize pcs)
        {
            pcs.parentX = parent.Width;
            pcs.parentY = parent.Height;
            pcs.controlX = control.Width;
            pcs.controlY = control.Height;
        }
        void PCS_Get(ref Panel parent, ref Label control, ref PanelAndControlSize pcs)
        {
            pcs.parentX = parent.Width;
            pcs.parentY = parent.Height;
            pcs.controlX = control.Width;
            pcs.controlY = control.Height;
        }
        void PCS_Get(ref Panel parent, ref TextBox control, ref PanelAndControlSize pcs)
        {
            pcs.parentX = parent.Width;
            pcs.parentY = parent.Height;
            pcs.controlX = control.Width;
            pcs.controlY = control.Height;
        }
        void PCS_Get(ref Panel parent, ref RadioButton control, ref PanelAndControlSize pcs)
        {
            pcs.parentX = parent.Width;
            pcs.parentY = parent.Height;
            pcs.controlX = control.Width;
            pcs.controlY = control.Height;
        }
        #endregion

        #region 调整位置
        Point AdjustControlLocation(PanelAndControlSize pcs, int rt, int dn)
        {
            Point cp = new Point((pcs.parentX / 2) - (pcs.controlX / 2), (pcs.parentY / 2) - (pcs.controlY / 2));
            if(rt > 0)
            {
                cp.X += pcs.controlX / 2 + rt;
            }
            else if(rt < 0)
            {
                cp.X += -pcs.controlX / 2 + rt;
            }
            if (dn > 0)
            {
                cp.Y += pcs.controlY / 2 + dn;
            }
            else if (dn < 0)
            {
                cp.Y += -pcs.controlY / 2 + dn;
            }
            return cp;
        }
        #endregion

        //调整控件位置
        void InitPCS()
        {
            PCS_Get(ref NewUserPanel, ref NewUserButton, ref PCSNewUserButton);

            PCS_Get(ref NewUserSetPanel, ref NewUserNameLable, ref PCSNewUserNameLable);
            PCS_Get(ref NewUserSetPanel, ref NewUserPassWordLable, ref PCSNewUserPassWordLable);
            PCS_Get(ref NewUserSetPanel, ref NewUserAdminLable, ref PCSNewUserAdminLable);
            PCS_Get(ref NewUserSetPanel, ref NewUserNameTextbox, ref PCSNewUserNameTextbox);
            PCS_Get(ref NewUserSetPanel, ref NewUserPasswordTextbox, ref PCSNewUserPassWordTextbox);
            PCS_Get(ref NewUserSetPanel, ref NewUserAdminYesRadioButton, ref PCSNewUserAdminYesRadioButton);
            PCS_Get(ref NewUserSetPanel, ref NewUserAdminNoRadioButton, ref PCSNewUserAdminNoRadioButton);

            PCS_Get(ref NewUserAddPanel, ref NewUserAddButton, ref PCSNewUserAddButton);

            PCS_Get(ref UserNamePanel, ref UserNameTextbox, ref PCSUserNameTextbox);
            PCS_Get(ref UserNamePanel, ref UserNameLable, ref PCSUserNameLable);

            PCS_Get(ref ChangeAdminPanel, ref ChangeAdminLable, ref PCSChangeAdminLable);
            PCS_Get(ref ChangeAdminPanel, ref ChangeAdminYesRadioButton, ref PCSChangeAdminYesRadioButton);
            PCS_Get(ref ChangeAdminPanel, ref ChangeAdminNoRadioButton, ref PCSChangeAdminNoRadioButton);

            PCS_Get(ref DeletUserPanel, ref DeletUserButton, ref PCSDeletUserButton);


            NewUserButton.Location = AdjustControlLocation(PCSNewUserButton, 0, 0);

            NewUserNameLable.Location = AdjustControlLocation(PCSNewUserNameLable, -10, -25);
            NewUserNameTextbox.Location = AdjustControlLocation(PCSNewUserNameTextbox, 10, -25);
            NewUserPassWordLable.Location = AdjustControlLocation(PCSNewUserPassWordLable, -10, 0);
            NewUserPasswordTextbox.Location = AdjustControlLocation(PCSNewUserPassWordTextbox, 10, 0);
            NewUserAdminLable.Location = AdjustControlLocation(PCSNewUserAdminLable, -10, 25);
            NewUserAdminYesRadioButton.Location = AdjustControlLocation(PCSNewUserAdminYesRadioButton, 10, 25);
            NewUserAdminNoRadioButton.Location = AdjustControlLocation(PCSNewUserAdminNoRadioButton, 10, 50);

            NewUserAddButton.Location = AdjustControlLocation(PCSNewUserAddButton, 0, 0);

            UserNameLable.Location = AdjustControlLocation(PCSUserNameLable, 0, -5);
            UserNameTextbox.Location = AdjustControlLocation(PCSUserNameTextbox, 0, 5);

            ChangeAdminLable.Location = AdjustControlLocation(PCSChangeAdminLable, 0, -10);
            ChangeAdminYesRadioButton.Location = AdjustControlLocation(PCSChangeAdminYesRadioButton, 0, 0);
            ChangeAdminNoRadioButton.Location = AdjustControlLocation(PCSChangeAdminNoRadioButton, 0, 10);

            DeletUserButton.Location = AdjustControlLocation(PCSDeletUserButton, 0, 0);
        }

        private void FormUserManage_Shown(object sender, EventArgs e)
        {
            //调整控件位置
            InitPCS();
        }

        // listview双击选择
        private void UserListView_DoubleClick(object sender, EventArgs e)
        {
            // 解锁相关控件
            UserNameTextbox.Enabled = true;
            ChangeAdminYesRadioButton.Enabled = true;
            ChangeAdminNoRadioButton.Enabled = true;
            DeletUserButton.Enabled = true;
            ShowPasswordButton.Enabled = true;
            ShowPasswordTextbox.Enabled = true;
            ChangePasswordButton.Enabled = true;
            ChangePasswordTextbox.Enabled = true;

            UserNameTextbox.Text = UserListView.SelectedItems[0].Text;
            if(UserListView.SelectedItems[0].SubItems[1].Text == "是")
            {
                ChangeAdminYesRadioButton.Checked = true;
                ChangeAdminNoRadioButton.Checked = false;
            }
            else
            {
                ChangeAdminYesRadioButton.Checked = false;
                ChangeAdminNoRadioButton.Checked = true;
            }

            // 刷新相关控件
            ShowPasswordTextbox.Text = "";
            ChangePasswordTextbox.Text = "";
        }

        // 新建用户 点击
        private void NewUserButton_Click(object sender, EventArgs e)
        {
            if(NewUserAddButton.Enabled == true)
            {
                // 如果已经解锁，则刷新控件
                NewUserNameLable.Text = "";
                NewUserPasswordTextbox.Text = "";
                NewUserAdminNoRadioButton.Checked = true;
                NewUserAdminYesRadioButton.Checked = false;
            }
            else
            {
                // 解锁相关控件
                NewUserNameTextbox.Enabled = true;
                NewUserPasswordTextbox.Enabled = true;
                NewUserAdminYesRadioButton.Enabled = true;
                NewUserAdminNoRadioButton.Enabled = true;
                NewUserAdminNoRadioButton.Checked = true;
                NewUserAdminNoRadioButton.Checked = false;
                NewUserAddButton.Enabled = true;
                ChangePasswordButton.Enabled = true;
                ShowPasswordButton.Enabled = true;
                ChangePasswordTextbox.Enabled = true;
            }

            NewUserAdminYesRadioButton.Checked = false;
            NewUserAdminNoRadioButton.Checked = true;
        }

        // 添加用户按钮
        private void NewUserAddButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable("Account");
            CTMySql cm = new CTMySql();
            cm.ConnectDatabass();
            dt = cm.GetTableValue("Account");
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if(NewUserNameTextbox.Text == (string)dt.Rows[i]["Account"])
                {
                    MessageBox.Show("用户已经存在，请更改用户名");
                    return;
                }
            }
            if(NewUserPasswordTextbox.Text == "")
            {
                MessageBox.Show("密码不能为空，请重试");
                return;
            }
            DialogResult dr = DialogResult.Yes;
            if(NewUserAdminYesRadioButton.Checked)
            {
                dr = MessageBox.Show("确定添加的新用户为管理员用户？", "", MessageBoxButtons.YesNo);
            }
            if (dr == DialogResult.No) return;
            int level = 0;
            if (NewUserAdminYesRadioButton.Checked) level = 1;
            if (NewUserAdminNoRadioButton.Checked) level = 0;
            string[] data = new string[3];
            data[0] = NewUserPasswordTextbox.Text;
            data[1] = NewUserNameTextbox.Text;
            data[2] = level.ToString();
            cm.AddRowtoDatabass(data, "Account");

            #region 获取所有用户信息
            //获取所有用户信息
            UserListView.BeginUpdate();

            UserListView.View = View.Details;
            UserListView.Clear();
            UserListView.Columns.Add("用户名（双击选择用户）", 200, HorizontalAlignment.Right);
            UserListView.Columns.Add("管理员", 50, HorizontalAlignment.Center);
            UserListView.FullRowSelect = true;

            dt = cm.GetTableValue("Account");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name;
                ulong admin;
                name = (string)dt.Rows[i]["Account"];
                admin = (ulong)dt.Rows[i]["Level"];

                ListViewItem lvi = new ListViewItem();
                lvi.Text = name;
                if (admin == 1)
                {
                    lvi.SubItems.Add("是");
                }
                else
                {
                    lvi.SubItems.Add("否");
                }
                UserListView.Items.Add(lvi);
            }
            UserListView.EndUpdate();
            #endregion

            MessageBox.Show("新用户添加成功！");
        }

        // 删除用户按钮   点击
        private void DeletUserButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show("确认删除用户 " + UserNameTextbox.Text + "?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;
            DataTable dt = new DataTable("Account");
            CTMySql cm = new CTMySql();
            dt = cm.GetTableValue("Account");
            int pkvalue = -1;
            string pkname = dt.Columns[0].ColumnName;
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                if (UserNameTextbox.Text == dt.Rows[i]["Account"].ToString())
                {
                    pkvalue = Convert.ToInt32(dt.Rows[i][0]);
                    break;
                }
            }
            cm.DeletRowfromDatabass("Account", pkname, pkvalue);
            MessageBox.Show("删除用户成功！");

            #region 获取所有用户信息
            //获取所有用户信息
            UserListView.BeginUpdate();

            UserListView.View = View.Details;
            UserListView.Clear();
            UserListView.Columns.Add("用户名（双击选择用户）", 200, HorizontalAlignment.Right);
            UserListView.Columns.Add("管理员", 50, HorizontalAlignment.Center);
            UserListView.FullRowSelect = true;

            dt = cm.GetTableValue("Account");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name;
                ulong admin;
                name = (string)dt.Rows[i]["Account"];
                admin = (ulong)dt.Rows[i]["Level"];

                ListViewItem lvi = new ListViewItem();
                lvi.Text = name;
                if (admin == 1)
                {
                    lvi.SubItems.Add("是");
                }
                else
                {
                    lvi.SubItems.Add("否");
                }
                UserListView.Items.Add(lvi);
            }
            UserListView.EndUpdate();
            #endregion
        }

        private void ChangeAdminYesRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            CTMySql cm = new CTMySql();
            dt = cm.GetTableValue("Account");
            int pkvalue = -1;
            string pkname = dt.Columns[0].ColumnName;
            if (dt.Rows[0]["Account"].ToString() == UserNameTextbox.Text)
            {
                MessageBox.Show("此默认账户不能被修改！");
                return;
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (UserNameTextbox.Text == dt.Rows[i]["Account"].ToString())
                {
                    pkvalue = Convert.ToInt32(dt.Rows[i][0]);
                    break;
                }
            }
            if(ChangeAdminYesRadioButton.Checked)
                cm.UpdataDatabass("Account", "1", "Level", pkname, pkvalue);
            else
                cm.UpdataDatabass("Account", "0", "Level", pkname, pkvalue);
            cm.IsUserAdmin();
            this.Refresh();
            #region 获取所有用户信息
            //获取所有用户信息
            UserListView.BeginUpdate();

            UserListView.View = View.Details;
            UserListView.Clear();
            UserListView.Columns.Add("用户名（双击选择用户）", 200, HorizontalAlignment.Right);
            UserListView.Columns.Add("管理员", 50, HorizontalAlignment.Center);
            UserListView.FullRowSelect = true;

            dt = cm.GetTableValue("Account");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string name;
                ulong admin;
                name = (string)dt.Rows[i]["Account"];
                admin = (ulong)dt.Rows[i]["Level"];

                ListViewItem lvi = new ListViewItem();
                lvi.Text = name;
                if (admin == 1)
                {
                    lvi.SubItems.Add("是");
                }
                else
                {
                    lvi.SubItems.Add("否");
                }
                UserListView.Items.Add(lvi);
            }
            UserListView.EndUpdate();
            #endregion
        }

        private void ShowPasswordButton_Click(object sender, EventArgs e)
        {
            ShowPasswordTextbox.Enabled = true;
            DataTable dt = new DataTable();
            CTMySql cm = new CTMySql();
            dt = cm.GetTableValue("Account");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (UserNameTextbox.Text == dt.Rows[i]["Account"].ToString())
                {
                    ShowPasswordTextbox.Text = dt.Rows[i]["Password"].ToString();
                    break;
                }
            }
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if(ChangePasswordTextbox.Text == "")
            {
                MessageBox.Show("密码只能由字母、数字、点、下划线组成，且不能为空！");
            }
            ShowPasswordTextbox.Enabled = true;
            DataTable dt = new DataTable();
            CTMySql cm = new CTMySql();
            dt = cm.GetTableValue("Account");
            int pkvalue = -1;
            string pkname = dt.Columns[0].ColumnName;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (UserNameTextbox.Text == dt.Rows[i]["Account"].ToString())
                {
                    pkvalue = Convert.ToInt32(dt.Rows[i][0]);
                    break;
                }
            }
            cm.UpdataDatabass("account", ChangePasswordTextbox.Text, "Password", pkname, pkvalue);
            MessageBox.Show("密码修改成功！");
            ShowPasswordTextbox.Text = ChangePasswordTextbox.Text;
        }
    }
}
