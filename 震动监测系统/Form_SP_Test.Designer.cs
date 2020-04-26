namespace 震动监测系统
{
    partial class Form_SP_Test
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
            this.boxtest_result = new System.Windows.Forms.TextBox();
            this.button_sp_tests_start = new System.Windows.Forms.Button();
            this.boxtest_com_num = new System.Windows.Forms.TextBox();
            this.labtest_com_num = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.boxtest_bode_num = new System.Windows.Forms.TextBox();
            this.button_sp_test_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxtest_result
            // 
            this.boxtest_result.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.boxtest_result.Location = new System.Drawing.Point(24, 129);
            this.boxtest_result.Margin = new System.Windows.Forms.Padding(15);
            this.boxtest_result.Multiline = true;
            this.boxtest_result.Name = "boxtest_result";
            this.boxtest_result.ReadOnly = true;
            this.boxtest_result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxtest_result.Size = new System.Drawing.Size(484, 200);
            this.boxtest_result.TabIndex = 0;
            this.boxtest_result.TabStop = false;
            // 
            // button_sp_tests_start
            // 
            this.button_sp_tests_start.Location = new System.Drawing.Point(258, 32);
            this.button_sp_tests_start.Name = "button_sp_tests_start";
            this.button_sp_tests_start.Size = new System.Drawing.Size(100, 56);
            this.button_sp_tests_start.TabIndex = 1;
            this.button_sp_tests_start.Text = "开始测试";
            this.button_sp_tests_start.UseVisualStyleBackColor = true;
            this.button_sp_tests_start.Click += new System.EventHandler(this.Button_sp_test_Click);
            // 
            // boxtest_com_num
            // 
            this.boxtest_com_num.Location = new System.Drawing.Point(110, 29);
            this.boxtest_com_num.Name = "boxtest_com_num";
            this.boxtest_com_num.ReadOnly = true;
            this.boxtest_com_num.Size = new System.Drawing.Size(76, 25);
            this.boxtest_com_num.TabIndex = 2;
            // 
            // labtest_com_num
            // 
            this.labtest_com_num.AutoSize = true;
            this.labtest_com_num.Location = new System.Drawing.Point(37, 32);
            this.labtest_com_num.Name = "labtest_com_num";
            this.labtest_com_num.Size = new System.Drawing.Size(67, 15);
            this.labtest_com_num.TabIndex = 3;
            this.labtest_com_num.Text = "端口号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "波特率：";
            // 
            // boxtest_bode_num
            // 
            this.boxtest_bode_num.Location = new System.Drawing.Point(110, 70);
            this.boxtest_bode_num.Name = "boxtest_bode_num";
            this.boxtest_bode_num.ReadOnly = true;
            this.boxtest_bode_num.Size = new System.Drawing.Size(76, 25);
            this.boxtest_bode_num.TabIndex = 5;
            // 
            // button_sp_test_close
            // 
            this.button_sp_test_close.Location = new System.Drawing.Point(384, 32);
            this.button_sp_test_close.Name = "button_sp_test_close";
            this.button_sp_test_close.Size = new System.Drawing.Size(100, 56);
            this.button_sp_test_close.TabIndex = 6;
            this.button_sp_test_close.Text = "停止测试";
            this.button_sp_test_close.UseVisualStyleBackColor = true;
            this.button_sp_test_close.Click += new System.EventHandler(this.button_sp_test_close_Click);
            // 
            // Form_SP_Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 353);
            this.Controls.Add(this.button_sp_test_close);
            this.Controls.Add(this.boxtest_bode_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labtest_com_num);
            this.Controls.Add(this.boxtest_com_num);
            this.Controls.Add(this.button_sp_tests_start);
            this.Controls.Add(this.boxtest_result);
            this.Name = "Form_SP_Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "连接测试";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_SP_Test_FormClosing);
            this.Shown += new System.EventHandler(this.Form_SP_Test_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxtest_result;
        private System.Windows.Forms.Button button_sp_tests_start;
        private System.Windows.Forms.TextBox boxtest_com_num;
        private System.Windows.Forms.Label labtest_com_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxtest_bode_num;
        private System.Windows.Forms.Button button_sp_test_close;
    }
}