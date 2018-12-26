namespace WindowsFormsApp1
{
    partial class Form3
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
            this.hotTabControl = new System.Windows.Forms.TabControl();
            this.sinaTabPage = new System.Windows.Forms.TabPage();
            this.sinaPanel = new System.Windows.Forms.Panel();
            this.zhihuTabPage = new System.Windows.Forms.TabPage();
            this.zhihuPanel = new System.Windows.Forms.Panel();
            this.zhihuLinkLabel = new System.Windows.Forms.LinkLabel();
            this.hupuTabPage = new System.Windows.Forms.TabPage();
            this.hupuPanel = new System.Windows.Forms.Panel();
            this.hotTabControl.SuspendLayout();
            this.sinaTabPage.SuspendLayout();
            this.zhihuTabPage.SuspendLayout();
            this.zhihuPanel.SuspendLayout();
            this.hupuTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // hotTabControl
            // 
            this.hotTabControl.Controls.Add(this.sinaTabPage);
            this.hotTabControl.Controls.Add(this.zhihuTabPage);
            this.hotTabControl.Controls.Add(this.hupuTabPage);
            this.hotTabControl.Location = new System.Drawing.Point(-3, 0);
            this.hotTabControl.Name = "hotTabControl";
            this.hotTabControl.SelectedIndex = 0;
            this.hotTabControl.Size = new System.Drawing.Size(807, 450);
            this.hotTabControl.TabIndex = 0;
            // 
            // sinaTabPage
            // 
            this.sinaTabPage.Controls.Add(this.sinaPanel);
            this.sinaTabPage.Location = new System.Drawing.Point(4, 25);
            this.sinaTabPage.Name = "sinaTabPage";
            this.sinaTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sinaTabPage.Size = new System.Drawing.Size(799, 421);
            this.sinaTabPage.TabIndex = 0;
            this.sinaTabPage.Text = "微博";
            this.sinaTabPage.UseVisualStyleBackColor = true;
            // 
            // sinaPanel
            // 
            this.sinaPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sinaPanel.AutoScroll = true;
            this.sinaPanel.AutoScrollMinSize = new System.Drawing.Size(450, 450);
            this.sinaPanel.Location = new System.Drawing.Point(0, 0);
            this.sinaPanel.Name = "sinaPanel";
            this.sinaPanel.Size = new System.Drawing.Size(799, 425);
            this.sinaPanel.TabIndex = 0;
            this.sinaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sinaPanel_Paint);
            // 
            // zhihuTabPage
            // 
            this.zhihuTabPage.Controls.Add(this.zhihuPanel);
            this.zhihuTabPage.Location = new System.Drawing.Point(4, 25);
            this.zhihuTabPage.Name = "zhihuTabPage";
            this.zhihuTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.zhihuTabPage.Size = new System.Drawing.Size(799, 421);
            this.zhihuTabPage.TabIndex = 1;
            this.zhihuTabPage.Text = "知乎";
            this.zhihuTabPage.UseVisualStyleBackColor = true;
            // 
            // zhihuPanel
            // 
            this.zhihuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zhihuPanel.AutoScroll = true;
            this.zhihuPanel.AutoScrollMinSize = new System.Drawing.Size(450, 450);
            this.zhihuPanel.Controls.Add(this.zhihuLinkLabel);
            this.zhihuPanel.Location = new System.Drawing.Point(0, 0);
            this.zhihuPanel.Name = "zhihuPanel";
            this.zhihuPanel.Size = new System.Drawing.Size(799, 421);
            this.zhihuPanel.TabIndex = 0;
            this.zhihuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.zhihuPanel_Paint);
            // 
            // zhihuLinkLabel
            // 
            this.zhihuLinkLabel.AutoSize = true;
            this.zhihuLinkLabel.Location = new System.Drawing.Point(339, 370);
            this.zhihuLinkLabel.Name = "zhihuLinkLabel";
            this.zhihuLinkLabel.Size = new System.Drawing.Size(127, 15);
            this.zhihuLinkLabel.TabIndex = 7;
            this.zhihuLinkLabel.TabStop = true;
            this.zhihuLinkLabel.Text = "点击此处查看更多";
            // 
            // hupuTabPage
            // 
            this.hupuTabPage.Controls.Add(this.hupuPanel);
            this.hupuTabPage.Location = new System.Drawing.Point(4, 25);
            this.hupuTabPage.Name = "hupuTabPage";
            this.hupuTabPage.Size = new System.Drawing.Size(799, 421);
            this.hupuTabPage.TabIndex = 2;
            this.hupuTabPage.Text = "虎扑社区";
            this.hupuTabPage.UseVisualStyleBackColor = true;
            // 
            // hupuPanel
            // 
            this.hupuPanel.AutoScroll = true;
            this.hupuPanel.AutoScrollMinSize = new System.Drawing.Size(450, 450);
            this.hupuPanel.Location = new System.Drawing.Point(0, 0);
            this.hupuPanel.Name = "hupuPanel";
            this.hupuPanel.Size = new System.Drawing.Size(796, 421);
            this.hupuPanel.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hotTabControl);
            this.Name = "Form3";
            this.Text = "当前热点信息";
            this.hotTabControl.ResumeLayout(false);
            this.sinaTabPage.ResumeLayout(false);
            this.zhihuTabPage.ResumeLayout(false);
            this.zhihuPanel.ResumeLayout(false);
            this.zhihuPanel.PerformLayout();
            this.hupuTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl hotTabControl;
        private System.Windows.Forms.TabPage sinaTabPage;
        private System.Windows.Forms.TabPage zhihuTabPage;
        private System.Windows.Forms.TabPage hupuTabPage;
        private System.Windows.Forms.Panel sinaPanel;
        private System.Windows.Forms.Panel zhihuPanel;
        private System.Windows.Forms.Panel hupuPanel;
        private System.Windows.Forms.LinkLabel zhihuLinkLabel;
    }
}