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
        public Label label1;
        public DataGridView dataGridView1;
        public DataGridViewTextBoxColumn Name;
        public DataGridViewTextBoxColumn Link;
        public ShowResult(String key)
        {
            InitializeComponent();
            this.ShowResults(key);
        }
        public void InitializeComponent()
        {
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Link = new System.Windows.Forms.DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Location = new System.Drawing.Point(131, 79);
            this.Size = new System.Drawing.Size(799, 284);
            this.TabIndex = 0;
            this.Visible = true;
            // 
            // label1
            // 
            label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(245, 33);
            label1.TabIndex = 1;
            label1.Text = "搜索结果如下：";
            
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            Name,Link});
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            foreach (var res in result.lists)
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = res.Title;
                this.dataGridView1.Rows[index].Cells[1].Value = res.Url;
                dataGridView1.InvalidateRow(index);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String str = (string)this.dataGridView1.Rows[e.RowIndex].Cells[1].Value;
            System.Diagnostics.Process.Start(str);
        }
    }
   
}
