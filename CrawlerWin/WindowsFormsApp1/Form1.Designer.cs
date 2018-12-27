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
            this.searchButton = new System.Windows.Forms.Button();
            this.Textbox = new System.Windows.Forms.TextBox();
            this.sinaCheckBox = new System.Windows.Forms.CheckBox();
            this.zhihuCheckBox = new System.Windows.Forms.CheckBox();
            this.hupuCheckBox = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.hotButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(506, 158);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(78, 25);
            this.searchButton.TabIndex = 0;
            this.searchButton.Text = "开始搜索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Textbox
            // 
            this.Textbox.Location = new System.Drawing.Point(237, 158);
            this.Textbox.Name = "Textbox";
            this.Textbox.Size = new System.Drawing.Size(263, 21);
            this.Textbox.TabIndex = 1;
            this.Textbox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // sinaCheckBox
            // 
            this.sinaCheckBox.AutoSize = true;
            this.sinaCheckBox.Location = new System.Drawing.Point(237, 221);
            this.sinaCheckBox.Name = "sinaCheckBox";
            this.sinaCheckBox.Size = new System.Drawing.Size(72, 16);
            this.sinaCheckBox.TabIndex = 2;
            this.sinaCheckBox.Text = "新浪微博";
            this.sinaCheckBox.UseVisualStyleBackColor = true;
            this.sinaCheckBox.CheckedChanged += new System.EventHandler(this.sinaCheckBox_CheckedChanged);
            // 
            // zhihuCheckBox
            // 
            this.zhihuCheckBox.AutoSize = true;
            this.zhihuCheckBox.Location = new System.Drawing.Point(478, 221);
            this.zhihuCheckBox.Name = "zhihuCheckBox";
            this.zhihuCheckBox.Size = new System.Drawing.Size(48, 16);
            this.zhihuCheckBox.TabIndex = 4;
            this.zhihuCheckBox.Text = "知乎";
            this.zhihuCheckBox.UseVisualStyleBackColor = true;
            this.zhihuCheckBox.CheckedChanged += new System.EventHandler(this.zhihuCheckBox_CheckedChanged);
            // 
            // hupuCheckBox
            // 
            this.hupuCheckBox.AutoSize = true;
            this.hupuCheckBox.Location = new System.Drawing.Point(353, 221);
            this.hupuCheckBox.Name = "hupuCheckBox";
            this.hupuCheckBox.Size = new System.Drawing.Size(72, 16);
            this.hupuCheckBox.TabIndex = 5;
            this.hupuCheckBox.Text = "虎扑社区";
            this.hupuCheckBox.UseVisualStyleBackColor = true;
            this.hupuCheckBox.CheckedChanged += new System.EventHandler(this.hupuCheckBox_CheckedChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(253, 364);
            this.textBox2.Name = "textBox2";
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(238, 14);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "联系我们：123456789@sina.com";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hotButton
            // 
            this.hotButton.Location = new System.Drawing.Point(237, 263);
            this.hotButton.Name = "hotButton";
            this.hotButton.Size = new System.Drawing.Size(263, 23);
            this.hotButton.TabIndex = 8;
            this.hotButton.Text = "点击此处获取当前热门话题";
            this.hotButton.UseVisualStyleBackColor = true;
            this.hotButton.Click += new System.EventHandler(this.hotButton_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(745, 404);
            this.Controls.Add(this.hotButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.hupuCheckBox);
            this.Controls.Add(this.zhihuCheckBox);
            this.Controls.Add(this.sinaCheckBox);
            this.Controls.Add(this.Textbox);
            this.Controls.Add(this.searchButton);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox Textbox;
        private System.Windows.Forms.CheckBox sinaCheckBox;
        private System.Windows.Forms.CheckBox zhihuCheckBox;
        private System.Windows.Forms.CheckBox hupuCheckBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button hotButton;
    }
}

