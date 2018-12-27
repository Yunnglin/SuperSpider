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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.title_sina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotdegree_sina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url_sina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zhihuTabPage = new System.Windows.Forms.TabPage();
            this.zhihuPanel = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.title_zhihu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotdegree_zhihu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.url_zhihu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hupuTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.bd_tittle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd_degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bd_url = new System.Windows.Forms.DataGridViewLinkColumn();
            this.hotTabControl.SuspendLayout();
            this.sinaTabPage.SuspendLayout();
            this.sinaPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.zhihuTabPage.SuspendLayout();
            this.zhihuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.hupuTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // hotTabControl
            // 
            this.hotTabControl.Controls.Add(this.sinaTabPage);
            this.hotTabControl.Controls.Add(this.zhihuTabPage);
            this.hotTabControl.Controls.Add(this.hupuTabPage);
            this.hotTabControl.Location = new System.Drawing.Point(-3, 0);
            this.hotTabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hotTabControl.Name = "hotTabControl";
            this.hotTabControl.SelectedIndex = 0;
            this.hotTabControl.Size = new System.Drawing.Size(908, 540);
            this.hotTabControl.TabIndex = 0;
            // 
            // sinaTabPage
            // 
            this.sinaTabPage.Controls.Add(this.sinaPanel);
            this.sinaTabPage.Location = new System.Drawing.Point(4, 28);
            this.sinaTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sinaTabPage.Name = "sinaTabPage";
            this.sinaTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sinaTabPage.Size = new System.Drawing.Size(900, 508);
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
            this.sinaPanel.Controls.Add(this.dataGridView1);
            this.sinaPanel.Location = new System.Drawing.Point(0, 0);
            this.sinaPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.sinaPanel.Name = "sinaPanel";
            this.sinaPanel.Size = new System.Drawing.Size(899, 510);
            this.sinaPanel.TabIndex = 0;
            this.sinaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sinaPanel_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title_sina,
            this.hotdegree_sina,
            this.url_sina});
            this.dataGridView1.Location = new System.Drawing.Point(6, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(861, 558);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // title_sina
            // 
            this.title_sina.HeaderText = "标题";
            this.title_sina.Name = "title_sina";
            this.title_sina.Width = 400;
            // 
            // hotdegree_sina
            // 
            this.hotdegree_sina.HeaderText = "热度";
            this.hotdegree_sina.Name = "hotdegree_sina";
            this.hotdegree_sina.Width = 150;
            // 
            // url_sina
            // 
            this.url_sina.HeaderText = "超链接";
            this.url_sina.Name = "url_sina";
            this.url_sina.Width = 300;
            // 
            // zhihuTabPage
            // 
            this.zhihuTabPage.Controls.Add(this.zhihuPanel);
            this.zhihuTabPage.Location = new System.Drawing.Point(4, 28);
            this.zhihuTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zhihuTabPage.Name = "zhihuTabPage";
            this.zhihuTabPage.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zhihuTabPage.Size = new System.Drawing.Size(900, 508);
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
            this.zhihuPanel.Controls.Add(this.dataGridView2);
            this.zhihuPanel.Location = new System.Drawing.Point(0, 0);
            this.zhihuPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.zhihuPanel.Name = "zhihuPanel";
            this.zhihuPanel.Size = new System.Drawing.Size(899, 505);
            this.zhihuPanel.TabIndex = 0;
            this.zhihuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.zhihuPanel_Paint);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.title_zhihu,
            this.hotdegree_zhihu,
            this.url_zhihu});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(899, 505);
            this.dataGridView2.TabIndex = 0;
            // 
            // title_zhihu
            // 
            this.title_zhihu.HeaderText = "回答";
            this.title_zhihu.Name = "title_zhihu";
            this.title_zhihu.Width = 400;
            // 
            // hotdegree_zhihu
            // 
            this.hotdegree_zhihu.HeaderText = "热度";
            this.hotdegree_zhihu.Name = "hotdegree_zhihu";
            this.hotdegree_zhihu.Width = 150;
            // 
            // url_zhihu
            // 
            this.url_zhihu.HeaderText = "超链接";
            this.url_zhihu.Name = "url_zhihu";
            this.url_zhihu.Width = 300;
            // 
            // hupuTabPage
            // 
            this.hupuTabPage.Controls.Add(this.dataGridView3);
            this.hupuTabPage.Location = new System.Drawing.Point(4, 28);
            this.hupuTabPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hupuTabPage.Name = "hupuTabPage";
            this.hupuTabPage.Size = new System.Drawing.Size(900, 508);
            this.hupuTabPage.TabIndex = 2;
            this.hupuTabPage.Text = "百度贴吧";
            this.hupuTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bd_tittle,
            this.bd_degree,
            this.bd_content,
            this.bd_url});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 30;
            this.dataGridView3.Size = new System.Drawing.Size(900, 508);
            this.dataGridView3.TabIndex = 0;
            // 
            // bd_tittle
            // 
            this.bd_tittle.HeaderText = "主题";
            this.bd_tittle.Name = "bd_tittle";
            this.bd_tittle.Width = 200;
            // 
            // bd_degree
            // 
            this.bd_degree.HeaderText = "热度";
            this.bd_degree.Name = "bd_degree";
            // 
            // bd_content
            // 
            this.bd_content.HeaderText = "内容";
            this.bd_content.Name = "bd_content";
            this.bd_content.Width = 300;
            // 
            // bd_url
            // 
            this.bd_url.HeaderText = "超链接";
            this.bd_url.Name = "bd_url";
            this.bd_url.Width = 200;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.hotTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "当前热点信息";
            this.hotTabControl.ResumeLayout(false);
            this.sinaTabPage.ResumeLayout(false);
            this.sinaPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.zhihuTabPage.ResumeLayout(false);
            this.zhihuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.hupuTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl hotTabControl;
        private System.Windows.Forms.TabPage sinaTabPage;
        private System.Windows.Forms.TabPage zhihuTabPage;
        private System.Windows.Forms.Panel sinaPanel;
        private System.Windows.Forms.Panel zhihuPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title_sina;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotdegree_sina;
        private System.Windows.Forms.DataGridViewTextBoxColumn url_sina;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn title_zhihu;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotdegree_zhihu;
        private System.Windows.Forms.DataGridViewTextBoxColumn url_zhihu;
        private System.Windows.Forms.TabPage hupuTabPage;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bd_tittle;
        private System.Windows.Forms.DataGridViewTextBoxColumn bd_degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn bd_content;
        private System.Windows.Forms.DataGridViewLinkColumn bd_url;
    }
}