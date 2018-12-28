using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
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


namespace WindowsFormsApp1
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        int num = 20;
        public Form2(String keyword,int num)
        {
           this.Font = new Font("Microsoft YaHei UI", 10, FontStyle.Regular);
            this.key = keyword;
            this.num = num;
            InitializeComponent();
            this.Show();            
        }
        String key;
        bool weibo = false;
        bool zhihu = false;
        bool hupu = false;
     

        //List<WSearchResult> wSearchResults = new List<WSearchResult>();
        ConcurrentQueue<WSearchResult> wSearchResults = new ConcurrentQueue<WSearchResult>();
        ConcurrentQueue<String> answerUrls = new ConcurrentQueue<string>();
        public void Choose(string key, bool w, bool z, bool h)
        {
            weibo = w;
            zhihu = z;
            hupu = h;
            this.key = key;
            this.Width = 820;
            Crawling();
            
        }

        private void Crawling()
        {
            /**
             * 这句话别删了
             * 12.28
             * 李沛昊
             */
            this.Width = 855;
            if (weibo)
            {
                weiboCrawling();
            }
            if (zhihu)
            {
                zhihuCrawling();
            }
            if (hupu)
            {
                hupuCrawling();
            }
        }

        public void weiboCrawling()
        {

            Spider_WEIBO_Search s = new Spider_WEIBO_Search(key, num/20+1);
            s.StartCrawling().ContinueWith((S) =>
            {
                Invoke(new MethodInvoker(delegate ()
                {
                    //do something... 

                    foreach (var search in s.searchResults)
                    {
                        Panel p = new FlowLayoutPanel();
                        p.Width = this.Width / 2;
                        p.Height = this.Height / 3;

                        TextBox label1 = new TextBox();
                        label1.AutoSize = true;
                        label1.BorderStyle= System.Windows.Forms.BorderStyle.None;
                        label1.Text = "ID: "+search.Name;
                        label1.Width = p.Width;

                        Label label2 = new Label();
                        label2.AutoSize = true;
                        label2.Text =  search.Post+"  "+search.Comment+"  "+search.Like;
                        label2.Width = p.Width;

                        Label label3 = new Label();
                        label1.AutoSize = true;
                        label3.Text =  search.From;
                        label3.Width = p.Width;

                        TextBox t = new TextBox();
                        t.Multiline = true;
                        t.Width = p.Width-5;
                        t.Height = p.Height *2/ 3;
                        
                        t.Text = search.Content;

                      
                        p.Controls.Add(label1);
                        p.Controls.Add(t);
                        p.Controls.Add(label2);
                        p.Controls.Add(label3);
                        mainPanel.Controls.Add(p);
                    }

                }));
            });
        }

        public void zhihuCrawling()
        {
  
            Spider_ZHIHU_ANSWER answer = new Spider_ZHIHU_ANSWER(key,num);
            answer.StartCrawling().ContinueWith((S) =>
            {

                Invoke(new MethodInvoker(delegate ()
                {
                    //do something... 
                    
                    foreach (var search in answer.AnswerList)
                    {
                        Win_ZHIHU_ANSWER a = new Win_ZHIHU_ANSWER(search);
                        flowLayoutPanel1.Controls.Add(a);

                    }
                }));
            });
        }

        public void hupuCrawling()
        {

            this.BaiduPanel = new ShowResult(key,num);
            this.BaiduPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hupuTabPage.Controls.Add(BaiduPanel);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
