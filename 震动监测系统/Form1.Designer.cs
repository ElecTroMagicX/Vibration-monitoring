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
            this.myButton1 = new WindowsFormsControlLibrary1.MyButton();
            this.myButton5 = new WindowsFormsControlLibrary1.MyButton();
            this.myButton4 = new WindowsFormsControlLibrary1.MyButton();
            this.ButtonRealData = new WindowsFormsControlLibrary1.MyButton();
            this.ButtonHome = new WindowsFormsControlLibrary1.MyButton();
            this.menuStrip1.SuspendLayout();
            this.PanelButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.用户ToolStripMenuItem,
            this.通信ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(962, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
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
            this.UserSignIn.Size = new System.Drawing.Size(124, 22);
            this.UserSignIn.Text = "用户登录";
            this.UserSignIn.Click += new System.EventHandler(this.UserSignIn_Click);
            // 
            // UserSwitch
            // 
            this.UserSwitch.Name = "UserSwitch";
            this.UserSwitch.Size = new System.Drawing.Size(124, 22);
            this.UserSwitch.Text = "切换用户";
            this.UserSwitch.Click += new System.EventHandler(this.UserSwitch_Click);
            // 
            // UserLogOut
            // 
            this.UserLogOut.Name = "UserLogOut";
            this.UserLogOut.Size = new System.Drawing.Size(124, 22);
            this.UserLogOut.Text = "退出登录";
            this.UserLogOut.Click += new System.EventHandler(this.UserLogOut_Click);
            // 
            // UserManage
            // 
            this.UserManage.Name = "UserManage";
            this.UserManage.Size = new System.Drawing.Size(124, 22);
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
            this.SP_Set.Size = new System.Drawing.Size(124, 22);
            this.SP_Set.Text = "串口设置";
            this.SP_Set.Click += new System.EventHandler(this.SP_Set_Click);
            // 
            // SP_Ttest
            // 
            this.SP_Ttest.Name = "SP_Ttest";
            this.SP_Ttest.Size = new System.Drawing.Size(124, 22);
            this.SP_Ttest.Text = "连接测试";
            this.SP_Ttest.Click += new System.EventHandler(this.SP_Ttest_Click);
            // 
            // SP_Close
            // 
            this.SP_Close.Name = "SP_Close";
            this.SP_Close.Size = new System.Drawing.Size(124, 22);
            this.SP_Close.Text = "断开连接";
            this.SP_Close.Click += new System.EventHandler(this.SP_Close_Click);
            // 
            // PanelButton
            // 
            this.PanelButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelButton.Controls.Add(this.myButton1);
            this.PanelButton.Controls.Add(this.myButton5);
            this.PanelButton.Controls.Add(this.myButton4);
            this.PanelButton.Controls.Add(this.ButtonRealData);
            this.PanelButton.Controls.Add(this.ButtonHome);
            this.PanelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelButton.Location = new System.Drawing.Point(0, 25);
            this.PanelButton.Margin = new System.Windows.Forms.Padding(0);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.Size = new System.Drawing.Size(75, 556);
            this.PanelButton.TabIndex = 1;
            // 
            // myButton1
            // 
            this.myButton1.BackColor = System.Drawing.Color.LightGray;
            this.myButton1.BackColotAll = System.Drawing.Color.LightGray;
            this.myButton1.BackGroundImageAll = ((System.Drawing.Image)(resources.GetObject("myButton1.BackGroundImageAll")));
            this.myButton1.BackgroundImageLayoutAll = System.Windows.Forms.ImageLayout.Zoom;
            this.myButton1.FontColorAll = System.Drawing.SystemColors.ControlText;
            this.myButton1.Location = new System.Drawing.Point(0, 72);
            this.myButton1.Margin = new System.Windows.Forms.Padding(0);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(75, 72);
            this.myButton1.TabIndex = 4;
            this.myButton1.TextAll = "通信设置";
            // 
            // myButton5
            // 
            this.myButton5.BackColor = System.Drawing.Color.LightGray;
            this.myButton5.BackColotAll = System.Drawing.Color.LightGray;
            this.myButton5.BackGroundImageAll = ((System.Drawing.Image)(resources.GetObject("myButton5.BackGroundImageAll")));
            this.myButton5.BackgroundImageLayoutAll = System.Windows.Forms.ImageLayout.Zoom;
            this.myButton5.FontColorAll = System.Drawing.SystemColors.ControlText;
            this.myButton5.Location = new System.Drawing.Point(0, 216);
            this.myButton5.Margin = new System.Windows.Forms.Padding(0);
            this.myButton5.Name = "myButton5";
            this.myButton5.Size = new System.Drawing.Size(75, 72);
            this.myButton5.TabIndex = 3;
            this.myButton5.TextAll = "历史数据";
            // 
            // myButton4
            // 
            this.myButton4.BackColor = System.Drawing.Color.LightGray;
            this.myButton4.BackColotAll = System.Drawing.Color.LightGray;
            this.myButton4.BackGroundImageAll = ((System.Drawing.Image)(resources.GetObject("myButton4.BackGroundImageAll")));
            this.myButton4.BackgroundImageLayoutAll = System.Windows.Forms.ImageLayout.Zoom;
            this.myButton4.FontColorAll = System.Drawing.SystemColors.ControlText;
            this.myButton4.Location = new System.Drawing.Point(0, 288);
            this.myButton4.Margin = new System.Windows.Forms.Padding(0);
            this.myButton4.Name = "myButton4";
            this.myButton4.Size = new System.Drawing.Size(75, 72);
            this.myButton4.TabIndex = 2;
            this.myButton4.TextAll = "用户管理";
            // 
            // ButtonRealData
            // 
            this.ButtonRealData.BackColor = System.Drawing.Color.LightGray;
            this.ButtonRealData.BackColotAll = System.Drawing.Color.LightGray;
            this.ButtonRealData.BackGroundImageAll = ((System.Drawing.Image)(resources.GetObject("ButtonRealData.BackGroundImageAll")));
            this.ButtonRealData.BackgroundImageLayoutAll = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonRealData.FontColorAll = System.Drawing.SystemColors.ControlText;
            this.ButtonRealData.Location = new System.Drawing.Point(0, 144);
            this.ButtonRealData.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonRealData.Name = "ButtonRealData";
            this.ButtonRealData.Size = new System.Drawing.Size(75, 72);
            this.ButtonRealData.TabIndex = 1;
            this.ButtonRealData.TextAll = "实时数据";
            this.ButtonRealData.MyButtonClickEvent += new WindowsFormsControlLibrary1.MyButton.MyButtonClickHandle(this.ButtonRealData_MyButtonClickEvent);
            // 
            // ButtonHome
            // 
            this.ButtonHome.BackColor = System.Drawing.Color.LightGray;
            this.ButtonHome.BackColotAll = System.Drawing.Color.LightGray;
            this.ButtonHome.BackGroundImageAll = ((System.Drawing.Image)(resources.GetObject("ButtonHome.BackGroundImageAll")));
            this.ButtonHome.BackgroundImageLayoutAll = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonHome.FontColorAll = System.Drawing.SystemColors.ControlText;
            this.ButtonHome.Location = new System.Drawing.Point(0, 0);
            this.ButtonHome.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(75, 72);
            this.ButtonHome.TabIndex = 0;
            this.ButtonHome.TextAll = "主页";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(962, 581);
            this.Controls.Add(this.PanelButton);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(500, 400);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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
        private WindowsFormsControlLibrary1.MyButton myButton1;
        private WindowsFormsControlLibrary1.MyButton myButton5;
        private WindowsFormsControlLibrary1.MyButton myButton4;
        //private System.Windows.Forms.Panel panel1;
    }
}

