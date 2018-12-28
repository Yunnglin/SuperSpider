using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spider_Baidu
{
   public class ShowResult:Panel
    {
        public Panel panel1;

        public DataGridView dataGridView1;
        public DataGridViewTextBoxColumn Name;
        public DataGridViewLinkColumn Link;
        public ShowResult(String key)
        {
            InitializeComponent();
            this.ShowResults(key);
        }
        public void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Link = new System.Windows.Forms.DataGridViewLinkColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
         
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(131, 79);
            this.Size = new System.Drawing.Size(799, 284);
            this.TabIndex = 0;
            this.Visible = true;
            
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Name,Link});
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(0, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new System.Drawing.Size(799, 248);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Name
            // 
            Name.HeaderText = "帖子名称：";
            Name.Name = "Name";
            Name.Width = 111;
            // 
            // Link
            // 
            Link.HeaderText = "链接";
            Link.Name = "Link";
            Link.Width = 66;
         

            this.Text = "百度贴吧搜索结果";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }
        public void ShowResults(String str)
        {
            
            Spider_Baidu_HOSTPOST resu = new Spider_Baidu_HOSTPOST();
            SearchResult result = resu.LookFor(str);
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            try
            {
                foreach (var res in result.lists)
                {
                    int index = this.dataGridView1.Rows.Add();
                    this.dataGridView1.Rows[index].Cells[0].Value = res.Title;
                    this.dataGridView1.Rows[index].Cells[1].Value = res.Url;
                    dataGridView1.InvalidateRow(index);
                }
            }
            catch(Exception e)
            {
                MessageBox.Show("未找到百度贴吧相关内容");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                String str = (string)this.dataGridView1.Rows[e.RowIndex].Cells[1].Value;
                System.Diagnostics.Process.Start(str);
            }
            
        }
    }
   
}
