namespace WindowsFormsApp1
{
    partial class HotMonitor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.numlable = new System.Windows.Forms.Label();
            this.timelable = new System.Windows.Forms.Label();
            this.Resultabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ResumeBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.textBoxOffset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox);
            this.panel1.Controls.Add(this.ResumeBtn);
            this.panel1.Controls.Add(this.StopBtn);
            this.panel1.Controls.Add(this.PauseBtn);
            this.panel1.Controls.Add(this.StartBtn);
            this.panel1.Controls.Add(this.textBoxNum);
            this.panel1.Controls.Add(this.textBoxOffset);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(27, 75);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 654);
            this.panel1.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.numlable);
            this.groupBox.Controls.Add(this.timelable);
            this.groupBox.Controls.Add(this.Resultabel);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox.Location = new System.Drawing.Point(0, 480);
            this.groupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox.Size = new System.Drawing.Size(310, 174);
            this.groupBox.TabIndex = 14;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "运行信息";
            // 
            // numlable
            // 
            this.numlable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numlable.AutoSize = true;
            this.numlable.Location = new System.Drawing.Point(172, 78);
            this.numlable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.numlable.Name = "numlable";
            this.numlable.Size = new System.Drawing.Size(0, 15);
            this.numlable.TabIndex = 19;
            // 
            // timelable
            // 
            this.timelable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timelable.AutoSize = true;
            this.timelable.Location = new System.Drawing.Point(172, 40);
            this.timelable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timelable.Name = "timelable";
            this.timelable.Size = new System.Drawing.Size(0, 15);
            this.timelable.TabIndex = 18;
            // 
            // Resultabel
            // 
            this.Resultabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Resultabel.AutoSize = true;
            this.Resultabel.Location = new System.Drawing.Point(116, 122);
            this.Resultabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Resultabel.Name = "Resultabel";
            this.Resultabel.Size = new System.Drawing.Size(76, 15);
            this.Resultabel.TabIndex = 17;
            this.Resultabel.Text = "运行中...";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 16;
            this.label4.Text = "已爬数量：";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "运行时长：";
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.Location = new System.Drawing.Point(59, 348);
            this.ResumeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(85, 32);
            this.ResumeBtn.TabIndex = 9;
            this.ResumeBtn.Text = "继续";
            this.ResumeBtn.UseVisualStyleBackColor = true;
            this.ResumeBtn.Click += new System.EventHandler(this.ResumeBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StopBtn.Location = new System.Drawing.Point(172, 348);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(84, 32);
            this.StopBtn.TabIndex = 8;
            this.StopBtn.Text = "取消";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PauseBtn.Location = new System.Drawing.Point(59, 348);
            this.PauseBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(85, 32);
            this.PauseBtn.TabIndex = 7;
            this.PauseBtn.Text = "暂停";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StartBtn.Location = new System.Drawing.Point(59, 292);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(197, 32);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "开始";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // textBoxNum
            // 
            this.textBoxNum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxNum.Location = new System.Drawing.Point(59, 79);
            this.textBoxNum.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(197, 25);
            this.textBoxNum.TabIndex = 3;
            // 
            // textBoxOffset
            // 
            this.textBoxOffset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOffset.Location = new System.Drawing.Point(59, 158);
            this.textBoxOffset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxOffset.Name = "textBoxOffset";
            this.textBoxOffset.Size = new System.Drawing.Size(197, 25);
            this.textBoxOffset.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "爬取时间间隔 （/秒）";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(59, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "选择文件保存路径";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "最大爬取数量（/个）";
            // 
            // HotMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(364, 754);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "HotMonitor";
            this.Padding = new System.Windows.Forms.Padding(27, 75, 27, 25);
            this.Text = "HotMonitor";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.TextBox textBoxOffset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StopBtn;
        private System.Windows.Forms.Button PauseBtn;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button ResumeBtn;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label numlable;
        private System.Windows.Forms.Label timelable;
        private System.Windows.Forms.Label Resultabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}