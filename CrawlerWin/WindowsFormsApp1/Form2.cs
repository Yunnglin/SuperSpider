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
        public Form2(String keyword)
        {
            this.key = keyword;
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
            Spider_WEIBO_Search s = new Spider_WEIBO_Search(key, 2);
            s.StartCrawling().ContinueWith((S) =>
            {
                //wSearchResults = s.searchResults;
                //Add();
                //foreach (var search in s.searchResults)
                //{
                //    Console.WriteLine(search);
                //}
                Invoke(new MethodInvoker(delegate ()
                {
                    //do something... 

                    foreach (var search in s.searchResults)
                    {
                        Panel p = new Panel();
                        Label label1 = new Label();
                        label1.AutoSize = true;
                        label1.Text = "ID:"+search.Name;
                        TextBox t = new TextBox();
                        t.Multiline = true;
                        t.Width=400;
                        t.Height = 300;
                        t.Text = search.Content;
               
                        p.Controls.Add(label1);
                        p.Controls.Add(t);
                        //text.Width = this.Width / 4;
                        //  text.Height = this.Height;

                        //text.Text += search.ToString();
                        mainPanel.Controls.Add(p);
                    }

                }));
            });
        }

        public void zhihuCrawling()
        {
            Spider_ZHIHU_ANSWER answer = new Spider_ZHIHU_ANSWER(key);
            answer.StartCrawling().ContinueWith((S) =>
            {
                //wSearchResults = s.searchResults;
                //Add();
                //foreach (var search in s.searchResults)
                //{
                //    Console.WriteLine(search);
                //}
                Invoke(new MethodInvoker(delegate ()
                {
                    //do something... 
                    
                    foreach (var search in answer.AnswerList)
                    {
                        Win_ZHIHU_ANSWER a = new Win_ZHIHU_ANSWER(search);
                        flowLayoutPanel1.Controls.Add(a);
                        //TextBox text = new TextBox();
                        //text.Multiline = true;
                        //text.AutoSize = true;

                        //text.Width = this.Width / 4;
                        ////  text.Height = this.Height;

                        //text.Text += search.ToString();
                        //mainPanel.Controls.Add(text);
                    }
                }));
            });
        }

        public void hupuCrawling()
        {
            //ShowResult newpanel = new ShowResult();
            //newpanel.Show();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
