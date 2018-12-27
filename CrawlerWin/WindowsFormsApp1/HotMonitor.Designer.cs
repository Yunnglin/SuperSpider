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
            this.ResumeBtn = new System.Windows.Forms.Button();
            this.StopBtn = new System.Windows.Forms.Button();
            this.PauseBtn = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.textBoxOffset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.Resulabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timelable = new System.Windows.Forms.Label();
            this.numlable = new System.Windows.Forms.Label();
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 458);
            this.panel1.TabIndex = 0;
            // 
            // ResumeBtn
            // 
            this.ResumeBtn.Location = new System.Drawing.Point(44, 278);
            this.ResumeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ResumeBtn.Name = "ResumeBtn";
            this.ResumeBtn.Size = new System.Drawing.Size(64, 26);
            this.ResumeBtn.TabIndex = 9;
            this.ResumeBtn.Text = "继续";
            this.ResumeBtn.UseVisualStyleBackColor = true;
            this.ResumeBtn.Click += new System.EventHandler(this.ResumeBtn_Click);
            // 
            // StopBtn
            // 
            this.StopBtn.Location = new System.Drawing.Point(129, 278);
            this.StopBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StopBtn.Name = "StopBtn";
            this.StopBtn.Size = new System.Drawing.Size(63, 26);
            this.StopBtn.TabIndex = 8;
            this.StopBtn.Text = "取消";
            this.StopBtn.UseVisualStyleBackColor = true;
            this.StopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // PauseBtn
            // 
            this.PauseBtn.Location = new System.Drawing.Point(44, 278);
            this.PauseBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PauseBtn.Name = "PauseBtn";
            this.PauseBtn.Size = new System.Drawing.Size(64, 26);
            this.PauseBtn.TabIndex = 7;
            this.PauseBtn.Text = "暂停";
            this.PauseBtn.UseVisualStyleBackColor = true;
            this.PauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(44, 234);
            this.StartBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(148, 26);
            this.StartBtn.TabIndex = 6;
            this.StartBtn.Text = "开始";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(44, 63);
            this.textBoxNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(149, 21);
            this.textBoxNum.TabIndex = 3;
            // 
            // textBoxOffset
            // 
            this.textBoxOffset.Location = new System.Drawing.Point(44, 126);
            this.textBoxOffset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxOffset.Name = "textBoxOffset";
            this.textBoxOffset.Size = new System.Drawing.Size(149, 21);
            this.textBoxOffset.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "爬取时间间隔 （/秒）";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 179);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "选择文件保存路径";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "最大爬取数量（/个）";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.numlable);
            this.groupBox.Controls.Add(this.timelable);
            this.groupBox.Controls.Add(this.Resulabel);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox.Location = new System.Drawing.Point(0, 319);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(232, 139);
            this.groupBox.TabIndex = 14;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "运行信息";
            // 
            // Resulabel
            // 
            this.Resulabel.AutoSize = true;
            this.Resulabel.Location = new System.Drawing.Point(87, 98);
            this.Resulabel.Name = "Resulabel";
            this.Resulabel.Size = new System.Drawing.Size(59, 12);
            this.Resulabel.TabIndex = 17;
            this.Resulabel.Text = "运行中...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 16;
            this.label4.Text = "已爬数量：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "运行时长：";
            // 
            // timelable
            // 
            this.timelable.AutoSize = true;
            this.timelable.Location = new System.Drawing.Point(129, 32);
            this.timelable.Name = "timelable";
            this.timelable.Size = new System.Drawing.Size(0, 12);
            this.timelable.TabIndex = 18;
            // 
            // numlable
            // 
            this.numlable.AutoSize = true;
            this.numlable.Location = new System.Drawing.Point(129, 62);
            this.numlable.Name = "numlable";
            this.numlable.Size = new System.Drawing.Size(0, 12);
            this.numlable.TabIndex = 19;
            // 
            // HotMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 458);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HotMonitor";
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
        private System.Windows.Forms.Label Resulabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}