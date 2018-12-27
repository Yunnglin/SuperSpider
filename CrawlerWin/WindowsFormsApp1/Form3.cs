using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spider_ZHIHU;
using Spider_WEIBO;
using Spider_Baidu;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
          
        }
        public void weiBo(List<WHotPoint> whots)
        {
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (WHotPoint h in whots)
            {
                int index = this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[index].Cells[0].Value = h.Title;
                this.dataGridView1.Rows[index].Cells[1].Value = h.HotDegree;
                this.dataGridView1.Rows[index].Cells[2].Value = h.Url;
                dataGridView1.InvalidateRow(index);
            }
        }
        public void zhihu(List<HotPoint_ZHIHU> zhihu_hotlist)
        {
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (HotPoint_ZHIHU m in zhihu_hotlist)
            {
                int index = this.dataGridView2.Rows.Add();
                this.dataGridView2.Rows[index].Cells[0].Value = m.Title;
                this.dataGridView2.Rows[index].Cells[1].Value = m.HotDegree;
                this.dataGridView2.Rows[index].Cells[2].Value = m.Url;
                dataGridView2.InvalidateRow(index);
            }
        }
        public void baidu(List<TopPost> plist)
        {
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            foreach (TopPost m in plist)
            {
                int index = this.dataGridView3.Rows.Add();
                this.dataGridView3.Rows[index].Cells[0].Value = m.Title;
                this.dataGridView3.Rows[index].Cells[1].Value = m.Heat;
                //this.dataGridView3.Rows[index].Cells[2].Value = m.Content;
                this.dataGridView3.Rows[index].Cells[2].Value = m.html;
                dataGridView3.InvalidateRow(index);
            }
        }
        private void zhihuPanel_Paint(object sender, PaintEventArgs e)
        {
            
           
        }

        private void sinaPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void hupuPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
