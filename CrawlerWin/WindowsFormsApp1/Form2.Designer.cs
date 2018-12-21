namespace WindowsFormsApp1
{
    partial class Form2
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
            this.searchTabControl = new System.Windows.Forms.TabControl();
            this.sinaTabPage = new System.Windows.Forms.TabPage();
            this.zhihuTabPage = new System.Windows.Forms.TabPage();
            this.hupuTabPage = new System.Windows.Forms.TabPage();
            this.searchTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTabControl
            // 
            this.searchTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchTabControl.Controls.Add(this.sinaTabPage);
            this.searchTabControl.Controls.Add(this.zhihuTabPage);
            this.searchTabControl.Controls.Add(this.hupuTabPage);
            this.searchTabControl.Location = new System.Drawing.Point(3, -2);
            this.searchTabControl.Name = "searchTabControl";
            this.searchTabControl.SelectedIndex = 0;
            this.searchTabControl.Size = new System.Drawing.Size(797, 456);
            this.searchTabControl.TabIndex = 0;
            // 
            // sinaTabPage
            // 
            this.sinaTabPage.Location = new System.Drawing.Point(4, 25);
            this.sinaTabPage.Name = "sinaTabPage";
            this.sinaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sinaTabPage.Size = new System.Drawing.Size(789, 427);
            this.sinaTabPage.TabIndex = 0;
            this.sinaTabPage.Text = "微博";
            this.sinaTabPage.UseVisualStyleBackColor = true;
            // 
            // zhihuTabPage
            // 
            this.zhihuTabPage.Location = new System.Drawing.Point(4, 25);
            this.zhihuTabPage.Name = "zhihuTabPage";
            this.zhihuTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.zhihuTabPage.Size = new System.Drawing.Size(789, 427);
            this.zhihuTabPage.TabIndex = 1;
            this.zhihuTabPage.Text = "知乎";
            this.zhihuTabPage.UseVisualStyleBackColor = true;
            // 
            // hupuTabPage
            // 
            this.hupuTabPage.AccessibleName = "";
            this.hupuTabPage.Location = new System.Drawing.Point(4, 25);
            this.hupuTabPage.Name = "hupuTabPage";
            this.hupuTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.hupuTabPage.Size = new System.Drawing.Size(789, 427);
            this.hupuTabPage.TabIndex = 2;
            this.hupuTabPage.Text = "虎扑社区";
            this.hupuTabPage.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchTabControl);
            this.Name = "Form2";
            this.Text = "获取到的信息";
            this.searchTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl searchTabControl;
        private System.Windows.Forms.TabPage sinaTabPage;
        private System.Windows.Forms.TabPage zhihuTabPage;
        private System.Windows.Forms.TabPage hupuTabPage;
    }
}