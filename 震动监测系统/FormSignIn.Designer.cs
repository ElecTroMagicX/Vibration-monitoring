namespace 震动监测系统
{
    partial class FormSignIn
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
            this.btmSignIn = new System.Windows.Forms.Button();
            this.lblAccount = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtbxPassword = new System.Windows.Forms.TextBox();
            this.txtbxAccount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btmSignIn
            // 
            this.btmSignIn.AutoSize = true;
            this.btmSignIn.Font = new System.Drawing.Font("宋体", 12F);
            this.btmSignIn.Location = new System.Drawing.Point(14, 77);
            this.btmSignIn.Margin = new System.Windows.Forms.Padding(5);
            this.btmSignIn.Name = "btmSignIn";
            this.btmSignIn.Size = new System.Drawing.Size(246, 30);
            this.btmSignIn.TabIndex = 2;
            this.btmSignIn.Text = "登录";
            this.btmSignIn.UseVisualStyleBackColor = true;
            this.btmSignIn.Click += new System.EventHandler(this.btmSignIn_Click);
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.BackColor = System.Drawing.SystemColors.Control;
            this.lblAccount.CausesValidation = false;
            this.lblAccount.Font = new System.Drawing.Font("宋体", 9F);
            this.lblAccount.Location = new System.Drawing.Point(14, 14);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(5);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(52, 15);
            this.lblAccount.TabIndex = 1;
            this.lblAccount.Text = "账号：";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.CausesValidation = false;
            this.lblPassword.Location = new System.Drawing.Point(14, 47);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(5);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(52, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "密码：";
            // 
            // txtbxPassword
            // 
            this.txtbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxPassword.Font = new System.Drawing.Font("宋体", 9F);
            this.txtbxPassword.Location = new System.Drawing.Point(60, 42);
            this.txtbxPassword.Margin = new System.Windows.Forms.Padding(5);
            this.txtbxPassword.MaxLength = 16;
            this.txtbxPassword.Name = "txtbxPassword";
            this.txtbxPassword.PasswordChar = '*';
            this.txtbxPassword.Size = new System.Drawing.Size(200, 25);
            this.txtbxPassword.TabIndex = 1;
            this.txtbxPassword.UseSystemPasswordChar = true;
            this.txtbxPassword.WordWrap = false;
            this.txtbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxPassword_KeyPress);
            // 
            // txtbxAccount
            // 
            this.txtbxAccount.Location = new System.Drawing.Point(60, 9);
            this.txtbxAccount.Name = "txtbxAccount";
            this.txtbxAccount.Size = new System.Drawing.Size(200, 25);
            this.txtbxAccount.TabIndex = 0;
            this.txtbxAccount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbxAccount_KeyPress);
            // 
            // FormSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 121);
            this.Controls.Add(this.txtbxAccount);
            this.Controls.Add(this.txtbxPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.btmSignIn);
            this.MaximizeBox = false;
            this.Name = "FormSignIn";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "系统登录";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FormSignIn_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmSignIn;
        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtbxPassword;
        private System.Windows.Forms.TextBox txtbxAccount;
    }
}