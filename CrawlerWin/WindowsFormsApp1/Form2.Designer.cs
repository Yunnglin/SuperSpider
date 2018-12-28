using Spider_Baidu;
using System;

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
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.zhihuTabPage = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hupuTabPage = new System.Windows.Forms.TabPage();
            this.searchTabControl.SuspendLayout();
            this.sinaTabPage.SuspendLayout();
            this.zhihuTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTabControl
            // 
            this.searchTabControl.Controls.Add(this.sinaTabPage);
            this.searchTabControl.Controls.Add(this.zhihuTabPage);
            this.searchTabControl.Controls.Add(this.hupuTabPage);
            this.searchTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchTabControl.Location = new System.Drawing.Point(20, 75);
            this.searchTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchTabControl.Name = "searchTabControl";
            this.searchTabControl.SelectedIndex = 0;
            this.searchTabControl.Size = new System.Drawing.Size(721, 424);
            this.searchTabControl.TabIndex = 0;
            // 
            // sinaTabPage
            // 
            this.sinaTabPage.Controls.Add(this.mainPanel);
            this.sinaTabPage.Location = new System.Drawing.Point(4, 25);
            this.sinaTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sinaTabPage.Name = "sinaTabPage";
            this.sinaTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sinaTabPage.Size = new System.Drawing.Size(713, 395);
            this.sinaTabPage.TabIndex = 0;
            this.sinaTabPage.Text = "微博";
            this.sinaTabPage.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(3, 2);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(707, 391);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint_1);
            // 
            // zhihuTabPage
            // 
            this.zhihuTabPage.Controls.Add(this.flowLayoutPanel1);
            this.zhihuTabPage.Location = new System.Drawing.Point(4, 25);
            this.zhihuTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zhihuTabPage.Name = "zhihuTabPage";
            this.zhihuTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zhihuTabPage.Size = new System.Drawing.Size(751, 415);
            this.zhihuTabPage.TabIndex = 1;
            this.zhihuTabPage.Text = "知乎";
            this.zhihuTabPage.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(745, 411);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // hupuTabPage
            // 
            this.hupuTabPage.AccessibleName = "";
            this.hupuTabPage.Location = new System.Drawing.Point(4, 25);
            this.hupuTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hupuTabPage.Name = "hupuTabPage";
            this.hupuTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hupuTabPage.Size = new System.Drawing.Size(751, 415);
            this.hupuTabPage.TabIndex = 2;
            this.hupuTabPage.Text = "百度贴吧";
            this.hupuTabPage.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 519);
            this.Controls.Add(this.searchTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(20, 75, 20, 20);
            this.Text = "获取到的信息";
            this.searchTabControl.ResumeLayout(false);
            this.sinaTabPage.ResumeLayout(false);
            this.zhihuTabPage.ResumeLayout(false);
            this.zhihuTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl searchTabControl;
        private System.Windows.Forms.Panel BaiduPanel;
        private System.Windows.Forms.TabPage zhihuTabPage;
        private System.Windows.Forms.TabPage hupuTabPage;
        private System.Windows.Forms.TabPage sinaTabPage;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}