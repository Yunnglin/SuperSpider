namespace WindowsFormsApp1
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
            this.MaximizeBox = false;//使最大化窗口失效
             //下一句用来禁止对窗口大小进行拖拽
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Textbox = new System.Windows.Forms.TextBox();
            this.sinaCheckBox = new System.Windows.Forms.CheckBox();
            this.zhihuCheckBox = new System.Windows.Forms.CheckBox();
            this.hupuCheckBox = new System.Windows.Forms.CheckBox();
            this.hotButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.VisualBtn = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Textbox
            // 
            this.Textbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Textbox.Location = new System.Drawing.Point(37, 47);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(285, 29);
            this.Textbox.TabIndex = 1;
            this.Textbox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // sinaCheckBox
            // 
            this.sinaCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sinaCheckBox.AutoSize = true;
            this.sinaCheckBox.Checked = true;
            this.sinaCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sinaCheckBox.Location = new System.Drawing.Point(17, 106);
            this.sinaCheckBox.Name = "sinaCheckBox";
            this.sinaCheckBox.Size = new System.Drawing.Size(100, 27);
            this.sinaCheckBox.TabIndex = 2;
            this.sinaCheckBox.Text = "新浪微博";
            this.sinaCheckBox.UseVisualStyleBackColor = true;
            this.sinaCheckBox.CheckedChanged += new System.EventHandler(this.sinaCheckBox_CheckedChanged);
            // 
            // zhihuCheckBox
            // 
            this.zhihuCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.zhihuCheckBox.AutoSize = true;
            this.zhihuCheckBox.Checked = true;
            this.zhihuCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.zhihuCheckBox.Location = new System.Drawing.Point(272, 106);
            this.zhihuCheckBox.Name = "zhihuCheckBox";
            this.zhihuCheckBox.Size = new System.Drawing.Size(66, 27);
            this.zhihuCheckBox.TabIndex = 4;
            this.zhihuCheckBox.Text = "知乎";
            this.zhihuCheckBox.UseVisualStyleBackColor = true;
            this.zhihuCheckBox.CheckedChanged += new System.EventHandler(this.zhihuCheckBox_CheckedChanged);
            // 
            // hupuCheckBox
            // 
            this.hupuCheckBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hupuCheckBox.AutoSize = true;
            this.hupuCheckBox.Checked = true;
            this.hupuCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hupuCheckBox.Location = new System.Drawing.Point(134, 106);
            this.hupuCheckBox.Name = "hupuCheckBox";
            this.hupuCheckBox.Size = new System.Drawing.Size(100, 27);
            this.hupuCheckBox.TabIndex = 5;
            this.hupuCheckBox.Text = "百度贴吧";
            this.hupuCheckBox.UseVisualStyleBackColor = true;
            this.hupuCheckBox.CheckedChanged += new System.EventHandler(this.hupuCheckBox_CheckedChanged);
            // 
            // hotButton
            // 
            this.hotButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.hotButton.Location = new System.Drawing.Point(38, 231);
            this.hotButton.Name = "hotButton";
            this.hotButton.Size = new System.Drawing.Size(285, 41);
            this.hotButton.TabIndex = 8;
            this.hotButton.Text = "获取当前热门话题";
            this.hotButton.UseVisualStyleBackColor = true;
            this.hotButton.Click += new System.EventHandler(this.hotButton_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(36, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(285, 37);
            this.button1.TabIndex = 9;
            this.button1.Text = "热点监控";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBoxNum);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.VisualBtn);
            this.panel3.Controls.Add(this.zhihuCheckBox);
            this.panel3.Controls.Add(this.Textbox);
            this.panel3.Controls.Add(this.searchButton);
            this.panel3.Controls.Add(this.sinaCheckBox);
            this.panel3.Controls.Add(this.hotButton);
            this.panel3.Controls.Add(this.hupuCheckBox);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(20, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(354, 543);
            this.panel3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 46);
            this.label1.TabIndex = 11;
            this.label1.Text = "                            关于我们\r\nhttps://github.com/Yunnglin/SuperSpider";
            // 
            // VisualBtn
            // 
            this.VisualBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisualBtn.Location = new System.Drawing.Point(37, 378);
            this.VisualBtn.Name = "VisualBtn";
            this.VisualBtn.Size = new System.Drawing.Size(284, 37);
            this.VisualBtn.TabIndex = 10;
            this.VisualBtn.Text = "数据可视化";
            this.VisualBtn.UseVisualStyleBackColor = true;
            this.VisualBtn.Click += new System.EventHandler(this.VisualBtn_Click);
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchButton.Location = new System.Drawing.Point(210, 152);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(111, 50);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "开始搜索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "搜索数量：";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Location = new System.Drawing.Point(37, 172);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(114, 29);
            this.textBoxNum.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(394, 623);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Super Spider";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.TextBox Textbox;
        private System.Windows.Forms.CheckBox sinaCheckBox;
        private System.Windows.Forms.CheckBox zhihuCheckBox;
        private System.Windows.Forms.CheckBox hupuCheckBox;
        private System.Windows.Forms.Button hotButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button VisualBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label label2;
    }
}

