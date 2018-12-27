using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spider_WEIBO;
using Spider_ZHIHU;
using Spider_Baidu;
using System.IO;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        CheckBox[] info = new CheckBox[3];
        Boolean textboxHasText;//判断输入框是否有文本
        public Form1()
        {
            InitializeComponent();
            info[0] = sinaCheckBox;
            info[1] = hupuCheckBox;
            info[2] = zhihuCheckBox;
            setTextbox();
        }

        private void setTextbox()
        {
            textboxHasText = false;
            Textbox.Text = "请输入关键字";
            Textbox.ForeColor = Color.LightGray;
            Textbox.Enter += Textbox_Enter;
            Textbox.Leave += Textbox_Leave;
        }

        //textbox获得焦点
        private void Textbox_Enter(object sender, EventArgs e)
        {
            if (textboxHasText == false)
                Textbox.Text = "";

            Textbox.ForeColor = Color.Black;
        }
        //textbox失去焦点
        private void Textbox_Leave(object sender, EventArgs e)
        {
            if (Textbox.Text == "")
            {
                Textbox.Text = "请输入关键字";
                Textbox.ForeColor = Color.LightGray;
                textboxHasText = false;
            }
            else
                textboxHasText = true;
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            string keyWord = Textbox.Text;
            if (keyWord == ""||keyWord == "请输入关键字")
            {
                MessageBox.Show("请输入关键字！");
                return;
            }
            if (!sinaCheckBox.Checked & !hupuCheckBox.Checked & !zhihuCheckBox.Checked)
            {
                MessageBox.Show("请选择信息来源！");
                return;
            }

            Form2 form2 = new Form2(Textbox.Text);
            form2.Choose(keyWord,sinaCheckBox.Checked,zhihuCheckBox.Checked,hupuCheckBox.Checked);
        }


        private void sinaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void hupuCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void zhihuCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hotButton_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            Spider_WEIBO_HOT spider_WEIBO_HOT = new Spider_WEIBO_HOT();
            spider_WEIBO_HOT.StartCrawling().ContinueWith(S =>
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    form3.weiBo(spider_WEIBO_HOT.hotPoints);
                }));

            });
            Spider_ZHIHU_HOT spider_ZHIHU_HOT = new Spider_ZHIHU_HOT(50);
            spider_ZHIHU_HOT.StartCrawling().ContinueWith(S =>
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    form3.zhihu(spider_ZHIHU_HOT.hotList);
                }));
            });
            Spider_Baidu_HOSTPOST spider_Baidu = new Spider_Baidu_HOSTPOST();
            TopPost topPost= spider_Baidu.HotTop();
            form3.baidu(topPost.TopPosts);
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HotMonitor hotMonitor = new HotMonitor();
            hotMonitor.Show();
        }

        private void VisualBtn_Click(object sender, EventArgs e)
        {
            //调用系统默认的浏览器 
            FileInfo fileInfo = new FileInfo(@"../../../../Crawler/Visualization/bargraph.html");
           Console.WriteLine( fileInfo.FullName);
            System.Diagnostics.Process.Start(fileInfo.FullName);
        }
    }
}
