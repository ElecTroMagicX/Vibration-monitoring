namespace 震动监测系统
{
    partial class FormUserManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UserListView = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.NewUserAddPanel = new System.Windows.Forms.Panel();
            this.NewUserAddButton = new System.Windows.Forms.Button();
            this.NewUserSetPanel = new System.Windows.Forms.Panel();
            this.NewUserAdminNoRadioButton = new System.Windows.Forms.RadioButton();
            this.NewUserAdminYesRadioButton = new System.Windows.Forms.RadioButton();
            this.NewUserAdminLable = new System.Windows.Forms.Label();
            this.NewUserPassWordLable = new System.Windows.Forms.Label();
            this.NewUserPasswordTextbox = new System.Windows.Forms.TextBox();
            this.NewUserNameLable = new System.Windows.Forms.Label();
            this.NewUserNameTextbox = new System.Windows.Forms.TextBox();
            this.NewUserPanel = new System.Windows.Forms.Panel();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ChangePasswordButton = new System.Windows.Forms.Button();
            this.ChangePasswordTextbox = new System.Windows.Forms.TextBox();
            this.ShowPasswordButton = new System.Windows.Forms.Button();
            this.ShowPasswordTextbox = new System.Windows.Forms.TextBox();
            this.UserNamePanel = new System.Windows.Forms.Panel();
            this.UserNameLable = new System.Windows.Forms.Label();
            this.UserNameTextbox = new System.Windows.Forms.TextBox();
            this.ChangeAdminPanel = new System.Windows.Forms.Panel();
            this.ChangeAdminNoRadioButton = new System.Windows.Forms.RadioButton();
            this.ChangeAdminYesRadioButton = new System.Windows.Forms.RadioButton();
            this.ChangeAdminLable = new System.Windows.Forms.Label();
            this.DeletUserPanel = new System.Windows.Forms.Panel();
            this.DeletUserButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.NewUserAddPanel.SuspendLayout();
            this.NewUserSetPanel.SuspendLayout();
            this.NewUserPanel.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.UserNamePanel.SuspendLayout();
            this.ChangeAdminPanel.SuspendLayout();
            this.DeletUserPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserListView
            // 
            this.UserListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.UserListView.HideSelection = false;
            this.UserListView.Location = new System.Drawing.Point(4, 4);
            this.UserListView.MultiSelect = false;
            this.UserListView.Name = "UserListView";
            this.UserListView.Size = new System.Drawing.Size(294, 442);
            this.UserListView.TabIndex = 0;
            this.UserListView.UseCompatibleStateImageBehavior = false;
            this.UserListView.View = System.Windows.Forms.View.Details;
            this.UserListView.DoubleClick += new System.EventHandler(this.UserListView_DoubleClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.UserListView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Location = new System.Drawing.Point(305, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(483, 384);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(483, 384);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel4.Controls.Add(this.NewUserAddPanel, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.NewUserSetPanel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.NewUserPanel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(477, 186);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // NewUserAddPanel
            // 
            this.NewUserAddPanel.Controls.Add(this.NewUserAddButton);
            this.NewUserAddPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewUserAddPanel.Location = new System.Drawing.Point(360, 4);
            this.NewUserAddPanel.Name = "NewUserAddPanel";
            this.NewUserAddPanel.Size = new System.Drawing.Size(113, 178);
            this.NewUserAddPanel.TabIndex = 4;
            // 
            // NewUserAddButton
            // 
            this.NewUserAddButton.Location = new System.Drawing.Point(3, 3);
            this.NewUserAddButton.Name = "NewUserAddButton";
            this.NewUserAddButton.Size = new System.Drawing.Size(75, 23);
            this.NewUserAddButton.TabIndex = 2;
            this.NewUserAddButton.Text = "添加";
            this.NewUserAddButton.UseVisualStyleBackColor = true;
            this.NewUserAddButton.Click += new System.EventHandler(this.NewUserAddButton_Click);
            // 
            // NewUserSetPanel
            // 
            this.NewUserSetPanel.Controls.Add(this.NewUserAdminNoRadioButton);
            this.NewUserSetPanel.Controls.Add(this.NewUserAdminYesRadioButton);
            this.NewUserSetPanel.Controls.Add(this.NewUserAdminLable);
            this.NewUserSetPanel.Controls.Add(this.NewUserPassWordLable);
            this.NewUserSetPanel.Controls.Add(this.NewUserPasswordTextbox);
            this.NewUserSetPanel.Controls.Add(this.NewUserNameLable);
            this.NewUserSetPanel.Controls.Add(this.NewUserNameTextbox);
            this.NewUserSetPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewUserSetPanel.Location = new System.Drawing.Point(123, 4);
            this.NewUserSetPanel.Name = "NewUserSetPanel";
            this.NewUserSetPanel.Size = new System.Drawing.Size(230, 178);
            this.NewUserSetPanel.TabIndex = 1;
            // 
            // NewUserAdminNoRadioButton
            // 
            this.NewUserAdminNoRadioButton.AutoSize = true;
            this.NewUserAdminNoRadioButton.Location = new System.Drawing.Point(113, 136);
            this.NewUserAdminNoRadioButton.Name = "NewUserAdminNoRadioButton";
            this.NewUserAdminNoRadioButton.Size = new System.Drawing.Size(35, 16);
            this.NewUserAdminNoRadioButton.TabIndex = 13;
            this.NewUserAdminNoRadioButton.TabStop = true;
            this.NewUserAdminNoRadioButton.Text = "否";
            this.NewUserAdminNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // NewUserAdminYesRadioButton
            // 
            this.NewUserAdminYesRadioButton.AutoSize = true;
            this.NewUserAdminYesRadioButton.Location = new System.Drawing.Point(113, 113);
            this.NewUserAdminYesRadioButton.Name = "NewUserAdminYesRadioButton";
            this.NewUserAdminYesRadioButton.Size = new System.Drawing.Size(35, 16);
            this.NewUserAdminYesRadioButton.TabIndex = 12;
            this.NewUserAdminYesRadioButton.TabStop = true;
            this.NewUserAdminYesRadioButton.Text = "是";
            this.NewUserAdminYesRadioButton.UseVisualStyleBackColor = true;
            // 
            // NewUserAdminLable
            // 
            this.NewUserAdminLable.AutoSize = true;
            this.NewUserAdminLable.Location = new System.Drawing.Point(31, 115);
            this.NewUserAdminLable.Name = "NewUserAdminLable";
            this.NewUserAdminLable.Size = new System.Drawing.Size(53, 12);
            this.NewUserAdminLable.TabIndex = 11;
            this.NewUserAdminLable.Text = "管理员：";
            // 
            // NewUserPassWordLable
            // 
            this.NewUserPassWordLable.AutoSize = true;
            this.NewUserPassWordLable.Location = new System.Drawing.Point(31, 74);
            this.NewUserPassWordLable.Name = "NewUserPassWordLable";
            this.NewUserPassWordLable.Size = new System.Drawing.Size(53, 12);
            this.NewUserPassWordLable.TabIndex = 9;
            this.NewUserPassWordLable.Text = "密  码：";
            // 
            // NewUserPasswordTextbox
            // 
            this.NewUserPasswordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewUserPasswordTextbox.Location = new System.Drawing.Point(85, 80);
            this.NewUserPasswordTextbox.Margin = new System.Windows.Forms.Padding(10);
            this.NewUserPasswordTextbox.Name = "NewUserPasswordTextbox";
            this.NewUserPasswordTextbox.Size = new System.Drawing.Size(100, 21);
            this.NewUserPasswordTextbox.TabIndex = 8;
            // 
            // NewUserNameLable
            // 
            this.NewUserNameLable.AutoSize = true;
            this.NewUserNameLable.Location = new System.Drawing.Point(31, 33);
            this.NewUserNameLable.Name = "NewUserNameLable";
            this.NewUserNameLable.Size = new System.Drawing.Size(53, 12);
            this.NewUserNameLable.TabIndex = 7;
            this.NewUserNameLable.Text = "用户名：";
            // 
            // NewUserNameTextbox
            // 
            this.NewUserNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewUserNameTextbox.Location = new System.Drawing.Point(79, 45);
            this.NewUserNameTextbox.Margin = new System.Windows.Forms.Padding(10);
            this.NewUserNameTextbox.Name = "NewUserNameTextbox";
            this.NewUserNameTextbox.Size = new System.Drawing.Size(100, 21);
            this.NewUserNameTextbox.TabIndex = 6;
            // 
            // NewUserPanel
            // 
            this.NewUserPanel.Controls.Add(this.NewUserButton);
            this.NewUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewUserPanel.Location = new System.Drawing.Point(4, 4);
            this.NewUserPanel.Name = "NewUserPanel";
            this.NewUserPanel.Size = new System.Drawing.Size(112, 178);
            this.NewUserPanel.TabIndex = 3;
            // 
            // NewUserButton
            // 
            this.NewUserButton.Location = new System.Drawing.Point(11, 74);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(75, 23);
            this.NewUserButton.TabIndex = 0;
            this.NewUserButton.Text = "新建用户";
            this.NewUserButton.UseVisualStyleBackColor = true;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.UserNamePanel, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ChangeAdminPanel, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.DeletUserPanel, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 195);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(477, 186);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel5.SetColumnSpan(this.tableLayoutPanel3, 3);
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.ChangePasswordButton, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ChangePasswordTextbox, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.ShowPasswordButton, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ShowPasswordTextbox, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 96);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(469, 86);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // ChangePasswordButton
            // 
            this.ChangePasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ChangePasswordButton.Location = new System.Drawing.Point(149, 53);
            this.ChangePasswordButton.Margin = new System.Windows.Forms.Padding(10);
            this.ChangePasswordButton.Name = "ChangePasswordButton";
            this.ChangePasswordButton.Size = new System.Drawing.Size(75, 23);
            this.ChangePasswordButton.TabIndex = 2;
            this.ChangePasswordButton.Text = "修改密码";
            this.ChangePasswordButton.UseVisualStyleBackColor = true;
            this.ChangePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // ChangePasswordTextbox
            // 
            this.ChangePasswordTextbox.Location = new System.Drawing.Point(244, 53);
            this.ChangePasswordTextbox.Margin = new System.Windows.Forms.Padding(10);
            this.ChangePasswordTextbox.Name = "ChangePasswordTextbox";
            this.ChangePasswordTextbox.Size = new System.Drawing.Size(100, 21);
            this.ChangePasswordTextbox.TabIndex = 3;
            // 
            // ShowPasswordButton
            // 
            this.ShowPasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowPasswordButton.Location = new System.Drawing.Point(149, 11);
            this.ShowPasswordButton.Margin = new System.Windows.Forms.Padding(10);
            this.ShowPasswordButton.Name = "ShowPasswordButton";
            this.ShowPasswordButton.Size = new System.Drawing.Size(75, 22);
            this.ShowPasswordButton.TabIndex = 0;
            this.ShowPasswordButton.Text = "查询密码";
            this.ShowPasswordButton.UseVisualStyleBackColor = true;
            this.ShowPasswordButton.Click += new System.EventHandler(this.ShowPasswordButton_Click);
            // 
            // ShowPasswordTextbox
            // 
            this.ShowPasswordTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ShowPasswordTextbox.Location = new System.Drawing.Point(244, 12);
            this.ShowPasswordTextbox.Margin = new System.Windows.Forms.Padding(10);
            this.ShowPasswordTextbox.Name = "ShowPasswordTextbox";
            this.ShowPasswordTextbox.ReadOnly = true;
            this.ShowPasswordTextbox.Size = new System.Drawing.Size(100, 21);
            this.ShowPasswordTextbox.TabIndex = 1;
            // 
            // UserNamePanel
            // 
            this.UserNamePanel.Controls.Add(this.UserNameLable);
            this.UserNamePanel.Controls.Add(this.UserNameTextbox);
            this.UserNamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserNamePanel.Location = new System.Drawing.Point(4, 4);
            this.UserNamePanel.Name = "UserNamePanel";
            this.UserNamePanel.Size = new System.Drawing.Size(151, 85);
            this.UserNamePanel.TabIndex = 4;
            // 
            // UserNameLable
            // 
            this.UserNameLable.AutoSize = true;
            this.UserNameLable.Location = new System.Drawing.Point(3, 3);
            this.UserNameLable.Name = "UserNameLable";
            this.UserNameLable.Size = new System.Drawing.Size(89, 12);
            this.UserNameLable.TabIndex = 5;
            this.UserNameLable.Text = "当前选择用户：";
            // 
            // UserNameTextbox
            // 
            this.UserNameTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UserNameTextbox.Location = new System.Drawing.Point(3, 19);
            this.UserNameTextbox.Margin = new System.Windows.Forms.Padding(10);
            this.UserNameTextbox.Name = "UserNameTextbox";
            this.UserNameTextbox.ReadOnly = true;
            this.UserNameTextbox.Size = new System.Drawing.Size(100, 21);
            this.UserNameTextbox.TabIndex = 4;
            // 
            // ChangeAdminPanel
            // 
            this.ChangeAdminPanel.Controls.Add(this.ChangeAdminNoRadioButton);
            this.ChangeAdminPanel.Controls.Add(this.ChangeAdminYesRadioButton);
            this.ChangeAdminPanel.Controls.Add(this.ChangeAdminLable);
            this.ChangeAdminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChangeAdminPanel.Location = new System.Drawing.Point(162, 4);
            this.ChangeAdminPanel.Name = "ChangeAdminPanel";
            this.ChangeAdminPanel.Size = new System.Drawing.Size(151, 85);
            this.ChangeAdminPanel.TabIndex = 3;
            // 
            // ChangeAdminNoRadioButton
            // 
            this.ChangeAdminNoRadioButton.AutoSize = true;
            this.ChangeAdminNoRadioButton.Location = new System.Drawing.Point(14, 42);
            this.ChangeAdminNoRadioButton.Name = "ChangeAdminNoRadioButton";
            this.ChangeAdminNoRadioButton.Size = new System.Drawing.Size(35, 16);
            this.ChangeAdminNoRadioButton.TabIndex = 2;
            this.ChangeAdminNoRadioButton.TabStop = true;
            this.ChangeAdminNoRadioButton.Text = "否";
            this.ChangeAdminNoRadioButton.UseVisualStyleBackColor = true;
            // 
            // ChangeAdminYesRadioButton
            // 
            this.ChangeAdminYesRadioButton.AutoSize = true;
            this.ChangeAdminYesRadioButton.Location = new System.Drawing.Point(14, 20);
            this.ChangeAdminYesRadioButton.Name = "ChangeAdminYesRadioButton";
            this.ChangeAdminYesRadioButton.Size = new System.Drawing.Size(35, 16);
            this.ChangeAdminYesRadioButton.TabIndex = 1;
            this.ChangeAdminYesRadioButton.TabStop = true;
            this.ChangeAdminYesRadioButton.Text = "是";
            this.ChangeAdminYesRadioButton.UseVisualStyleBackColor = true;
            this.ChangeAdminYesRadioButton.CheckedChanged += new System.EventHandler(this.ChangeAdminYesRadioButton_CheckedChanged);
            // 
            // ChangeAdminLable
            // 
            this.ChangeAdminLable.AutoSize = true;
            this.ChangeAdminLable.Location = new System.Drawing.Point(3, 0);
            this.ChangeAdminLable.Name = "ChangeAdminLable";
            this.ChangeAdminLable.Size = new System.Drawing.Size(89, 12);
            this.ChangeAdminLable.TabIndex = 0;
            this.ChangeAdminLable.Text = "设置为管理员：";
            // 
            // DeletUserPanel
            // 
            this.DeletUserPanel.Controls.Add(this.DeletUserButton);
            this.DeletUserPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeletUserPanel.Location = new System.Drawing.Point(320, 4);
            this.DeletUserPanel.Name = "DeletUserPanel";
            this.DeletUserPanel.Size = new System.Drawing.Size(153, 85);
            this.DeletUserPanel.TabIndex = 2;
            // 
            // DeletUserButton
            // 
            this.DeletUserButton.Location = new System.Drawing.Point(3, 3);
            this.DeletUserButton.Name = "DeletUserButton";
            this.DeletUserButton.Size = new System.Drawing.Size(75, 23);
            this.DeletUserButton.TabIndex = 3;
            this.DeletUserButton.Text = "删除用户";
            this.DeletUserButton.UseVisualStyleBackColor = true;
            this.DeletUserButton.Click += new System.EventHandler(this.DeletUserButton_Click);
            // 
            // FormUserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormUserManage";
            this.Text = "FormUserManage";
            this.Shown += new System.EventHandler(this.FormUserManage_Shown);
            this.Resize += new System.EventHandler(this.FormUserManage_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.NewUserAddPanel.ResumeLayout(false);
            this.NewUserSetPanel.ResumeLayout(false);
            this.NewUserSetPanel.PerformLayout();
            this.NewUserPanel.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.UserNamePanel.ResumeLayout(false);
            this.UserNamePanel.PerformLayout();
            this.ChangeAdminPanel.ResumeLayout(false);
            this.ChangeAdminPanel.PerformLayout();
            this.DeletUserPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView UserListView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button ChangePasswordButton;
        private System.Windows.Forms.TextBox ChangePasswordTextbox;
        private System.Windows.Forms.Button ShowPasswordButton;
        private System.Windows.Forms.TextBox ShowPasswordTextbox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button NewUserAddButton;
        private System.Windows.Forms.Button NewUserButton;
        private System.Windows.Forms.Panel NewUserSetPanel;
        private System.Windows.Forms.Label NewUserAdminLable;
        private System.Windows.Forms.Label NewUserPassWordLable;
        private System.Windows.Forms.TextBox NewUserPasswordTextbox;
        private System.Windows.Forms.Label NewUserNameLable;
        private System.Windows.Forms.TextBox NewUserNameTextbox;
        private System.Windows.Forms.Panel DeletUserPanel;
        private System.Windows.Forms.Button DeletUserButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel UserNamePanel;
        private System.Windows.Forms.Label UserNameLable;
        private System.Windows.Forms.TextBox UserNameTextbox;
        private System.Windows.Forms.Panel ChangeAdminPanel;
        private System.Windows.Forms.RadioButton ChangeAdminNoRadioButton;
        private System.Windows.Forms.RadioButton ChangeAdminYesRadioButton;
        private System.Windows.Forms.Label ChangeAdminLable;
        private System.Windows.Forms.RadioButton NewUserAdminNoRadioButton;
        private System.Windows.Forms.RadioButton NewUserAdminYesRadioButton;
        private System.Windows.Forms.Panel NewUserAddPanel;
        private System.Windows.Forms.Panel NewUserPanel;
    }
}