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
            Add();
        }

        public void Crawling()
        {
            if (weibo)
            {
                Spider_WEIBO_Search s = new Spider_WEIBO_Search(key, 1);
                s.StartCrawling().ContinueWith((S) =>
                {
                    foreach (var search in s.searchResults)
                    {
                        Console.WriteLine(search);
                    }

                });
                //Console.WriteLine("SFA");
                //foreach (var search in s.searchResults)
                //{
                //    Label label = new Label();
                //    label.Text = search.ToString();
                //    mainPanel.Controls.Add(label);
                //}
            }
        }

        public void Add()
        {
            foreach (var search in wSearchResults)
            {
                Label label = new Label();
                label.Text = search.ToString();
                mainPanel.Controls.Add(label);
            }
        }
    }
}
