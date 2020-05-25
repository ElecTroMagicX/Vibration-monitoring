namespace 震动监测系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.UserSwitch = new System.Windows.Forms.ToolStripMenuItem();
            this.UserLogOut = new System.Windows.Forms.ToolStripMenuItem();
            this.UserManage = new System.Windows.Forms.ToolStripMenuItem();
            this.通信ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SP_Set = new System.Windows.Forms.ToolStripMenuItem();
            this.SP_Ttest = new System.Windows.Forms.ToolStripMenuItem();
            this.SP_Close = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelButton = new System.Windows.Forms.Panel();
            this.ButtonSeriportSet = new WindowsFormsControlLibrary1.MyButton();
            this.ButtonHistoryData = new WindowsFormsControlLibrary1.MyButton();
            this.ButtonUserManage = new WindowsFormsControlLibrary1.MyButton();
            this.ButtonRealData = new WindowsFormsControlLibrary1.MyButton();
            this.ButtonHome = new WindowsFormsControlLibrary1.MyButton();
            this.menuStrip1.SuspendLayout();
            this.PanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(153)))), ((int)(((byte)(0)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.用户ToolStripMenuItem,
            this.通信ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(984, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.文件ToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 用户ToolStripMenuItem
            // 
            this.用户ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UserSignIn,
            this.UserSwitch,
            this.UserLogOut,
            this.UserManage});
            this.用户ToolStripMenuItem.Name = "用户ToolStripMenuItem";
            this.用户ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.用户ToolStripMenuItem.Text = "用户";
            // 
            // UserSignIn
            // 
            this.UserSignIn.Name = "UserSignIn";
            this.UserSignIn.Size = new System.Drawing.Size(180, 22);
            this.UserSignIn.Text = "用户登录";
            this.UserSignIn.Click += new System.EventHandler(this.UserSignIn_Click);
            // 
            // UserSwitch
            // 
            this.UserSwitch.Name = "UserSwitch";
            this.UserSwitch.Size = new System.Drawing.Size(180, 22);
            this.UserSwitch.Text = "切换用户";
            this.UserSwitch.Click += new System.EventHandler(this.UserSwitch_Click);
            // 
            // UserLogOut
            // 
            this.UserLogOut.Name = "UserLogOut";
            this.UserLogOut.Size = new System.Drawing.Size(180, 22);
            this.UserLogOut.Text = "退出登录";
            this.UserLogOut.Click += new System.EventHandler(this.UserLogOut_Click);
            // 
            // UserManage
            // 
            this.UserManage.Name = "UserManage";
            this.UserManage.Size = new System.Drawing.Size(180, 22);
            this.UserManage.Text = "用户管理";
            this.UserManage.Click += new System.EventHandler(this.UserManage_Click);
            // 
            // 通信ToolStripMenuItem
            // 
            this.通信ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SP_Set,
            this.SP_Ttest,
            this.SP_Close});
            this.通信ToolStripMenuItem.Name = "通信ToolStripMenuItem";
            this.通信ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.通信ToolStripMenuItem.Text = "通信";
            // 
            // SP_Set
            // 
            this.SP_Set.Name = "SP_Set";
            this.SP_Set.Size = new System.Drawing.Size(180, 22);
            this.SP_Set.Text = "串口设置";
            this.SP_Set.Click += new System.EventHandler(this.SP_Set_Click);
            // 
            // SP_Ttest
            // 
            this.SP_Ttest.Name = "SP_Ttest";
            this.SP_Ttest.Size = new System.Drawing.Size(180, 22);
            this.SP_Ttest.Text = "连接测试";
            this.SP_Ttest.Click += new System.EventHandler(this.SP_Ttest_Click);
            // 
            // SP_Close
            // 
            this.SP_Close.Name = "SP_Close";
            this.SP_Close.Size = new System.Drawing.Size(180, 22);
            this.SP_Close.Text = "断开连接";
            this.SP_Close.Click += new System.EventHandler(this.SP_Close_Click);
            // 
            // PanelButton
            // 
            this.PanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.PanelButton.Controls.Add(this.ButtonSeriportSet);
            this.PanelButton.Controls.Add(this.ButtonHistoryData);
            this.PanelButton.Controls.Add(this.ButtonUserManage);
            this.PanelButton.Controls.Add(this.ButtonRealData);
            this.PanelButton.Controls.Add(this.ButtonHome);
            this.PanelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelButton.Location = new System.Drawing.Point(0, 25);
            this.PanelButton.Margin = new System.Windows.Forms.Padding(0);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(75, 556);
            this.PanelButton.TabIndex = 1;
            // 
            // ButtonSeriportSet
            // 
            this.ButtonSeriportSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.ButtonSeriportSet.BackColotAll = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.ButtonSeriportSet.BackGroundImageAll = ((System.Drawing.Image)(resources.GetObject("ButtonSeriportSet.BackGroundImageAll")));
            this.ButtonSeriportSet.BackgroundImageLayoutAll = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonSeriportSet.FontColorAll = System.Drawing.Color.White;
            this.ButtonSeriportSet.Location = new System.Drawing.Point(0, 72);
            this.ButtonSeriportSet.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonSeriportSet.Name = "ButtonSeriportSet";
            this.ButtonSeriportSet.Size = new System.Drawing.Size(75, 72);
            this.ButtonSeriportSet.TabIndex = 4;
            this.ButtonSeriportSet.TextAll = "通信设置";
            this.ButtonSeriportSet.MyButtonClickEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonClickHandle(this.ButtonSeriportSet_MyButtonClickEvent);
            this.ButtonSeriportSet.MouseInEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonMouseInHandle(this.ButtonHome_MouseInEvent);
            this.ButtonSeriportSet.MouseLeaveEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonMouseLevaeHandle(this.ButtonHome_MouseLeaveEvent);
            // 
            // ButtonHistoryData
            // 
            this.ButtonHistoryData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.ButtonHistoryData.BackColotAll = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.ButtonHistoryData.BackGroundImageAll = ((System.Drawing.Image)(resources.GetObject("ButtonHistoryData.BackGroundImageAll")));
            this.ButtonHistoryData.BackgroundImageLayoutAll = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonHistoryData.FontColorAll = System.Drawing.Color.White;
            this.ButtonHistoryData.Location = new System.Drawing.Point(0, 216);
            this.ButtonHistoryData.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonHistoryData.Name = "ButtonHistoryData";
            this.ButtonHistoryData.Size = new System.Drawing.Size(75, 72);
            this.ButtonHistoryData.TabIndex = 3;
            this.ButtonHistoryData.TextAll = "历史数据";
            this.ButtonHistoryData.MyButtonClickEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonClickHandle(this.ButtonHistoryData_MyButtonClickEvent);
            this.ButtonHistoryData.MouseInEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonMouseInHandle(this.ButtonHome_MouseInEvent);
            this.ButtonHistoryData.MouseLeaveEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonMouseLevaeHandle(this.ButtonHome_MouseLeaveEvent);
            // 
            // ButtonUserManage
            // 
            this.ButtonUserManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.ButtonUserManage.BackColotAll = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.ButtonUserManage.BackGroundImageAll = ((System.Drawing.Image)(resources.GetObject("ButtonUserManage.BackGroundImageAll")));
            this.ButtonUserManage.BackgroundImageLayoutAll = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonUserManage.FontColorAll = System.Drawing.Color.White;
            this.ButtonUserManage.Location = new System.Drawing.Point(0, 288);
            this.ButtonUserManage.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonUserManage.Name = "ButtonUserManage";
            this.ButtonUserManage.Size = new System.Drawing.Size(75, 72);
            this.ButtonUserManage.TabIndex = 2;
            this.ButtonUserManage.TextAll = "用户管理";
            this.ButtonUserManage.MyButtonClickEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonClickHandle(this.UserManage_Click);
            this.ButtonUserManage.MouseInEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonMouseInHandle(this.ButtonHome_MouseInEvent);
            this.ButtonUserManage.MouseLeaveEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonMouseLevaeHandle(this.ButtonHome_MouseLeaveEvent);
            // 
            // ButtonRealData
            // 
            this.ButtonRealData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.ButtonRealData.BackColotAll = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.ButtonRealData.BackGroundImageAll = ((System.Drawing.Image)(resources.GetObject("ButtonRealData.BackGroundImageAll")));
            this.ButtonRealData.BackgroundImageLayoutAll = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonRealData.FontColorAll = System.Drawing.Color.White;
            this.ButtonRealData.Location = new System.Drawing.Point(0, 144);
            this.ButtonRealData.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRealData.Name = "ButtonRealData";
            this.ButtonRealData.Size = new System.Drawing.Size(75, 72);
            this.ButtonRealData.TabIndex = 1;
            this.ButtonRealData.TextAll = "实时数据";
            this.ButtonRealData.MyButtonClickEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonClickHandle(this.ButtonRealData_MyButtonClickEvent);
            this.ButtonRealData.MouseInEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonMouseInHandle(this.ButtonHome_MouseInEvent);
            this.ButtonRealData.MouseLeaveEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonMouseLevaeHandle(this.ButtonHome_MouseLeaveEvent);
            // 
            // ButtonHome
            // 
            this.ButtonHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.ButtonHome.BackColotAll = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.ButtonHome.BackGroundImageAll = ((System.Drawing.Image)(resources.GetObject("ButtonHome.BackGroundImageAll")));
            this.ButtonHome.BackgroundImageLayoutAll = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonHome.FontColorAll = System.Drawing.Color.White;
            this.ButtonHome.Location = new System.Drawing.Point(0, 0);
            this.ButtonHome.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(75, 72);
            this.ButtonHome.TabIndex = 0;
            this.ButtonHome.TextAll = "主页";
            this.ButtonHome.MouseInEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonMouseInHandle(this.ButtonHome_MouseInEvent);
            this.ButtonHome.MouseLeaveEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonMouseLevaeHandle(this.ButtonHome_MouseLeaveEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(984, 581);
            this.Controls.Add(this.PanelButton);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "震动监测系统";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.MouseEnter += new System.EventHandler(this.Form1_MouseEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PanelButton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 通信ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem SP_Set;
        public System.Windows.Forms.ToolStripMenuItem SP_Ttest;
        public System.Windows.Forms.ToolStripMenuItem SP_Close;
        private System.Windows.Forms.ToolStripMenuItem UserSignIn;
        private System.Windows.Forms.ToolStripMenuItem UserSwitch;
        private System.Windows.Forms.ToolStripMenuItem UserLogOut;
        private System.Windows.Forms.ToolStripMenuItem UserManage;
        private System.Windows.Forms.Panel PanelButton;
        private WindowsFormsControlLibrary1.MyButton ButtonRealData;
        private WindowsFormsControlLibrary1.MyButton ButtonHome;
        private WindowsFormsControlLibrary1.MyButton ButtonSeriportSet;
        private WindowsFormsControlLibrary1.MyButton ButtonHistoryData;
        private WindowsFormsControlLibrary1.MyButton ButtonUserManage;
        //private System.Windows.Forms.Panel panel1;
    }
}

