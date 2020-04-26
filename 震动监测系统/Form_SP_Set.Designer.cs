namespace 震动监测系统
{
    partial class Form_SP_Set
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
            this.com_num = new System.Windows.Forms.Label();
            this.com_list = new System.Windows.Forms.ComboBox();
            this.bode_num = new System.Windows.Forms.Label();
            this.bode_list = new System.Windows.Forms.ComboBox();
            this.data_num = new System.Windows.Forms.Label();
            this.stop_num = new System.Windows.Forms.Label();
            this.data_box = new System.Windows.Forms.TextBox();
            this.stop_box = new System.Windows.Forms.TextBox();
            this.opencom_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // com_num
            // 
            this.com_num.AutoSize = true;
            this.com_num.Font = new System.Drawing.Font("宋体", 10F);
            this.com_num.Location = new System.Drawing.Point(40, 40);
            this.com_num.Name = "com_num";
            this.com_num.Size = new System.Drawing.Size(76, 17);
            this.com_num.TabIndex = 0;
            this.com_num.Text = "端口号：";
            // 
            // com_list
            // 
            this.com_list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.com_list.FormattingEnabled = true;
            this.com_list.Location = new System.Drawing.Point(120, 36);
            this.com_list.Name = "com_list";
            this.com_list.Size = new System.Drawing.Size(100, 23);
            this.com_list.TabIndex = 1;
            // 
            // bode_num
            // 
            this.bode_num.AutoSize = true;
            this.bode_num.Font = new System.Drawing.Font("宋体", 10F);
            this.bode_num.Location = new System.Drawing.Point(40, 80);
            this.bode_num.Name = "bode_num";
            this.bode_num.Size = new System.Drawing.Size(76, 17);
            this.bode_num.TabIndex = 2;
            this.bode_num.Text = "波特率：";
            // 
            // bode_list
            // 
            this.bode_list.FormattingEnabled = true;
            this.bode_list.Location = new System.Drawing.Point(120, 76);
            this.bode_list.Name = "bode_list";
            this.bode_list.Size = new System.Drawing.Size(100, 23);
            this.bode_list.TabIndex = 2;
            this.bode_list.Text = "2400";
            // 
            // data_num
            // 
            this.data_num.AutoSize = true;
            this.data_num.Font = new System.Drawing.Font("宋体", 10F);
            this.data_num.Location = new System.Drawing.Point(40, 120);
            this.data_num.Name = "data_num";
            this.data_num.Size = new System.Drawing.Size(76, 17);
            this.data_num.TabIndex = 4;
            this.data_num.Text = "数据位：";
            // 
            // stop_num
            // 
            this.stop_num.AutoSize = true;
            this.stop_num.Font = new System.Drawing.Font("宋体", 10F);
            this.stop_num.Location = new System.Drawing.Point(40, 160);
            this.stop_num.Name = "stop_num";
            this.stop_num.Size = new System.Drawing.Size(76, 17);
            this.stop_num.TabIndex = 6;
            this.stop_num.Text = "停止位：";
            // 
            // data_box
            // 
            this.data_box.Location = new System.Drawing.Point(120, 116);
            this.data_box.MaxLength = 2;
            this.data_box.Name = "data_box";
            this.data_box.Size = new System.Drawing.Size(100, 25);
            this.data_box.TabIndex = 3;
            this.data_box.Text = "8";
            this.data_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // stop_box
            // 
            this.stop_box.Location = new System.Drawing.Point(120, 156);
            this.stop_box.MaxLength = 1;
            this.stop_box.Name = "stop_box";
            this.stop_box.Size = new System.Drawing.Size(100, 25);
            this.stop_box.TabIndex = 4;
            this.stop_box.Text = "1";
            this.stop_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // opencom_button
            // 
            this.opencom_button.Location = new System.Drawing.Point(43, 204);
            this.opencom_button.Name = "opencom_button";
            this.opencom_button.Size = new System.Drawing.Size(177, 50);
            this.opencom_button.TabIndex = 5;
            this.opencom_button.Text = "打开端口";
            this.opencom_button.UseVisualStyleBackColor = true;
            this.opencom_button.Click += new System.EventHandler(this.Opencom_button_Click);
            // 
            // Form_SP_Set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 293);
            this.Controls.Add(this.opencom_button);
            this.Controls.Add(this.stop_box);
            this.Controls.Add(this.data_box);
            this.Controls.Add(this.stop_num);
            this.Controls.Add(this.data_num);
            this.Controls.Add(this.bode_list);
            this.Controls.Add(this.bode_num);
            this.Controls.Add(this.com_list);
            this.Controls.Add(this.com_num);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SP_Set";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "串口设置";
            this.Shown += new System.EventHandler(this.Form_SP_Set_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label com_num;
        private System.Windows.Forms.ComboBox com_list;
        private System.Windows.Forms.Label bode_num;
        private System.Windows.Forms.ComboBox bode_list;
        private System.Windows.Forms.Label data_num;
        private System.Windows.Forms.Label stop_num;
        private System.Windows.Forms.TextBox data_box;
        private System.Windows.Forms.TextBox stop_box;
        private System.Windows.Forms.Button opencom_button;
    }
}