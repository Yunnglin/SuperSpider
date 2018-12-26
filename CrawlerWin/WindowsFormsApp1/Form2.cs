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
using Spider_HUPU;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Show();
        }

        bool weibo = false;
        bool zhihu = false;
        bool hupu = false;
        string key = "";

        //List<WSearchResult> wSearchResults = new List<WSearchResult>();
        ConcurrentQueue<WSearchResult> wSearchResults = new ConcurrentQueue<WSearchResult>();
        public void Choose(string key, bool w, bool z, bool h)
        {
            weibo = w;
            zhihu = z;
            hupu = h;
            this.key = key;
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
                        TextBox text = new TextBox();
                        text.Multiline = true;
                        text.AutoSize = true;

                        text.Width = this.Width / 4;
                        //  text.Height = this.Height;

                        text.Text += search.ToString();
                        mainPanel.Controls.Add(text);
                    }

                }));
            });
        }

        public void zhihuCrawling()
        {

        }

        public void hupuCrawling()
        {

        }

        //public void Add()
        //{
        //    Invoke(new MethodInvoker(delegate ()
        //    {
        //        //do something... 
               
        //        foreach (var search in wSearchResults)
        //        {
        //            TextBox text = new TextBox();
        //            text.Multiline = true;
        //            text.AutoSize = true;

        //            text.Width = this.Width/4;
        //          //  text.Height = this.Height;
                    
        //            text.Text += search.ToString();
        //            mainPanel.Controls.Add(text);
        //        }
           
        //    }));
               
        //}
    }
}
