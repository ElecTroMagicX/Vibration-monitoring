namespace 数据模拟发送
{
    partial class MainForm
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
            this.portlab = new System.Windows.Forms.Label();
            this.datalab = new System.Windows.Forms.Label();
            this.stoplab = new System.Windows.Forms.Label();
            this.bodelab = new System.Windows.Forms.Label();
            this.porttxt = new System.Windows.Forms.TextBox();
            this.datatxt = new System.Windows.Forms.TextBox();
            this.bodetxt = new System.Windows.Forms.TextBox();
            this.stoptxt = new System.Windows.Forms.TextBox();
            this.range1lab = new System.Windows.Forms.Label();
            this.range1txt = new System.Windows.Forms.TextBox();
            this.rand1midlab = new System.Windows.Forms.Label();
            this.mid1txt = new System.Windows.Forms.TextBox();
            this.rand1but = new System.Windows.Forms.Button();
            this.rand2but = new System.Windows.Forms.Button();
            this.mid2txt = new System.Windows.Forms.TextBox();
            this.rand2midlab = new System.Windows.Forms.Label();
            this.range2txt = new System.Windows.Forms.TextBox();
            this.range2lab = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.linebut = new System.Windows.Forms.Button();
            this.lineValtxt = new System.Windows.Forms.TextBox();
            this.lineVal = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timetxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // portlab
            // 
            this.portlab.AutoSize = true;
            this.portlab.Location = new System.Drawing.Point(21, 28);
            this.portlab.Name = "portlab";
            this.portlab.Size = new System.Drawing.Size(47, 15);
            this.portlab.TabIndex = 0;
            this.portlab.Text = "Port:";
            // 
            // datalab
            // 
            this.datalab.AutoSize = true;
            this.datalab.Location = new System.Drawing.Point(21, 71);
            this.datalab.Name = "datalab";
            this.datalab.Size = new System.Drawing.Size(47, 15);
            this.datalab.TabIndex = 1;
            this.datalab.Text = "Data:";
            // 
            // stoplab
            // 
            this.stoplab.AutoSize = true;
            this.stoplab.Location = new System.Drawing.Point(203, 71);
            this.stoplab.Name = "stoplab";
            this.stoplab.Size = new System.Drawing.Size(47, 15);
            this.stoplab.TabIndex = 2;
            this.stoplab.Text = "Stop:";
            // 
            // bodelab
            // 
            this.bodelab.AutoSize = true;
            this.bodelab.Location = new System.Drawing.Point(203, 28);
            this.bodelab.Name = "bodelab";
            this.bodelab.Size = new System.Drawing.Size(47, 15);
            this.bodelab.TabIndex = 3;
            this.bodelab.Text = "Bode:";
            // 
            // porttxt
            // 
            this.porttxt.Location = new System.Drawing.Point(88, 25);
            this.porttxt.Name = "porttxt";
            this.porttxt.Size = new System.Drawing.Size(100, 25);
            this.porttxt.TabIndex = 1;
            this.porttxt.Text = "COM5";
            this.porttxt.TextChanged += new System.EventHandler(this.porttxt_TextChanged);
            // 
            // datatxt
            // 
            this.datatxt.Location = new System.Drawing.Point(88, 68);
            this.datatxt.Name = "datatxt";
            this.datatxt.Size = new System.Drawing.Size(100, 25);
            this.datatxt.TabIndex = 3;
            this.datatxt.Text = "8";
            this.datatxt.TextChanged += new System.EventHandler(this.datatxt_TextChanged);
            // 
            // bodetxt
            // 
            this.bodetxt.Location = new System.Drawing.Point(281, 25);
            this.bodetxt.Name = "bodetxt";
            this.bodetxt.Size = new System.Drawing.Size(100, 25);
            this.bodetxt.TabIndex = 2;
            this.bodetxt.Text = "115200";
            this.bodetxt.TextChanged += new System.EventHandler(this.bodetxt_TextChanged);
            // 
            // stoptxt
            // 
            this.stoptxt.Location = new System.Drawing.Point(281, 68);
            this.stoptxt.Name = "stoptxt";
            this.stoptxt.Size = new System.Drawing.Size(100, 25);
            this.stoptxt.TabIndex = 4;
            this.stoptxt.Text = "1";
            this.stoptxt.TextChanged += new System.EventHandler(this.stoptxt_TextChanged);
            // 
            // range1lab
            // 
            this.range1lab.AutoSize = true;
            this.range1lab.Location = new System.Drawing.Point(21, 113);
            this.range1lab.Name = "range1lab";
            this.range1lab.Size = new System.Drawing.Size(63, 15);
            this.range1lab.TabIndex = 8;
            this.range1lab.Text = "Range1:";
            // 
            // range1txt
            // 
            this.range1txt.Location = new System.Drawing.Point(88, 110);
            this.range1txt.Name = "range1txt";
            this.range1txt.Size = new System.Drawing.Size(100, 25);
            this.range1txt.TabIndex = 5;
            this.range1txt.Text = "100";
            this.range1txt.TextChanged += new System.EventHandler(this.range1txt_TextChanged);
            // 
            // rand1midlab
            // 
            this.rand1midlab.AutoSize = true;
            this.rand1midlab.Location = new System.Drawing.Point(196, 113);
            this.rand1midlab.Name = "rand1midlab";
            this.rand1midlab.Size = new System.Drawing.Size(79, 15);
            this.rand1midlab.TabIndex = 10;
            this.rand1midlab.Text = "Rand1Mid:";
            // 
            // mid1txt
            // 
            this.mid1txt.Location = new System.Drawing.Point(281, 110);
            this.mid1txt.Name = "mid1txt";
            this.mid1txt.Size = new System.Drawing.Size(100, 25);
            this.mid1txt.TabIndex = 6;
            this.mid1txt.Text = "30000";
            this.mid1txt.TextChanged += new System.EventHandler(this.mid1txt_TextChanged);
            // 
            // rand1but
            // 
            this.rand1but.Location = new System.Drawing.Point(88, 154);
            this.rand1but.Name = "rand1but";
            this.rand1but.Size = new System.Drawing.Size(100, 42);
            this.rand1but.TabIndex = 12;
            this.rand1but.TabStop = false;
            this.rand1but.Text = "Rand1";
            this.rand1but.UseVisualStyleBackColor = true;
            this.rand1but.Click += new System.EventHandler(this.rand1but_Click);
            // 
            // rand2but
            // 
            this.rand2but.Location = new System.Drawing.Point(281, 154);
            this.rand2but.Name = "rand2but";
            this.rand2but.Size = new System.Drawing.Size(100, 42);
            this.rand2but.TabIndex = 13;
            this.rand2but.TabStop = false;
            this.rand2but.Text = "Rand2";
            this.rand2but.UseVisualStyleBackColor = true;
            this.rand2but.Click += new System.EventHandler(this.rand2but_Click);
            // 
            // mid2txt
            // 
            this.mid2txt.Location = new System.Drawing.Point(281, 216);
            this.mid2txt.Name = "mid2txt";
            this.mid2txt.Size = new System.Drawing.Size(100, 25);
            this.mid2txt.TabIndex = 8;
            this.mid2txt.Text = "30000";
            this.mid2txt.TextChanged += new System.EventHandler(this.mid2txt_TextChanged);
            // 
            // rand2midlab
            // 
            this.rand2midlab.AutoSize = true;
            this.rand2midlab.Location = new System.Drawing.Point(196, 219);
            this.rand2midlab.Name = "rand2midlab";
            this.rand2midlab.Size = new System.Drawing.Size(79, 15);
            this.rand2midlab.TabIndex = 16;
            this.rand2midlab.Text = "Rand2Mid:";
            // 
            // range2txt
            // 
            this.range2txt.Location = new System.Drawing.Point(88, 216);
            this.range2txt.Name = "range2txt";
            this.range2txt.Size = new System.Drawing.Size(100, 25);
            this.range2txt.TabIndex = 7;
            this.range2txt.Text = "10000";
            this.range2txt.TextChanged += new System.EventHandler(this.range2txt_TextChanged);
            // 
            // range2lab
            // 
            this.range2lab.AutoSize = true;
            this.range2lab.Location = new System.Drawing.Point(21, 219);
            this.range2lab.Name = "range2lab";
            this.range2lab.Size = new System.Drawing.Size(63, 15);
            this.range2lab.TabIndex = 14;
            this.range2lab.Text = "Range2:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 309);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(251, 169);
            this.textBox1.TabIndex = 18;
            this.textBox1.TabStop = false;
            // 
            // linebut
            // 
            this.linebut.Location = new System.Drawing.Point(281, 257);
            this.linebut.Name = "linebut";
            this.linebut.Size = new System.Drawing.Size(100, 42);
            this.linebut.TabIndex = 19;
            this.linebut.TabStop = false;
            this.linebut.Text = "Line";
            this.linebut.UseVisualStyleBackColor = true;
            this.linebut.Click += new System.EventHandler(this.linebut_Click);
            // 
            // lineValtxt
            // 
            this.lineValtxt.Location = new System.Drawing.Point(114, 268);
            this.lineValtxt.Name = "lineValtxt";
            this.lineValtxt.Size = new System.Drawing.Size(74, 25);
            this.lineValtxt.TabIndex = 9;
            this.lineValtxt.Text = "30000";
            this.lineValtxt.TextChanged += new System.EventHandler(this.lineValtxt_TextChanged);
            // 
            // lineVal
            // 
            this.lineVal.AutoSize = true;
            this.lineVal.Location = new System.Drawing.Point(21, 271);
            this.lineVal.Name = "lineVal";
            this.lineVal.Size = new System.Drawing.Size(87, 15);
            this.lineVal.TabIndex = 21;
            this.lineVal.Text = "LineValue:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 99);
            this.button1.TabIndex = 0;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "发送间隔(ms)";
            // 
            // timetxt
            // 
            this.timetxt.Location = new System.Drawing.Point(284, 334);
            this.timetxt.Name = "timetxt";
            this.timetxt.Size = new System.Drawing.Size(96, 25);
            this.timetxt.TabIndex = 10;
            this.timetxt.Text = "1000";
            this.timetxt.TextChanged += new System.EventHandler(this.timetxt_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 502);
            this.Controls.Add(this.timetxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lineVal);
            this.Controls.Add(this.lineValtxt);
            this.Controls.Add(this.linebut);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.mid2txt);
            this.Controls.Add(this.rand2midlab);
            this.Controls.Add(this.range2txt);
            this.Controls.Add(this.range2lab);
            this.Controls.Add(this.rand2but);
            this.Controls.Add(this.rand1but);
            this.Controls.Add(this.mid1txt);
            this.Controls.Add(this.rand1midlab);
            this.Controls.Add(this.range1txt);
            this.Controls.Add(this.range1lab);
            this.Controls.Add(this.stoptxt);
            this.Controls.Add(this.bodetxt);
            this.Controls.Add(this.datatxt);
            this.Controls.Add(this.porttxt);
            this.Controls.Add(this.bodelab);
            this.Controls.Add(this.stoplab);
            this.Controls.Add(this.datalab);
            this.Controls.Add(this.portlab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "数据模拟发送";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label portlab;
        private System.Windows.Forms.Label datalab;
        private System.Windows.Forms.Label stoplab;
        private System.Windows.Forms.Label bodelab;
        private System.Windows.Forms.TextBox porttxt;
        private System.Windows.Forms.TextBox datatxt;
        private System.Windows.Forms.TextBox bodetxt;
        private System.Windows.Forms.TextBox stoptxt;
        private System.Windows.Forms.Label range1lab;
        private System.Windows.Forms.TextBox range1txt;
        private System.Windows.Forms.Label rand1midlab;
        private System.Windows.Forms.TextBox mid1txt;
        private System.Windows.Forms.Button rand1but;
        private System.Windows.Forms.Button rand2but;
        private System.Windows.Forms.TextBox mid2txt;
        private System.Windows.Forms.Label rand2midlab;
        private System.Windows.Forms.TextBox range2txt;
        private System.Windows.Forms.Label range2lab;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button linebut;
        private System.Windows.Forms.TextBox lineValtxt;
        private System.Windows.Forms.Label lineVal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox timetxt;
    }
}

