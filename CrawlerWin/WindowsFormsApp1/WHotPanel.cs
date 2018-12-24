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
namespace WindowsFormsApp1
{
    class WHotPanel
    {
        class HotPointPanel : Panel
        {
            private List<WHotPoint> hotPoints;
            public List<WHotPoint> getList()
            {
                List<WHotPoint> hotPoints = new List<WHotPoint>();
                Spider_WEIBO_HOT spider_WEIBO_HOT = new Spider_WEIBO_HOT();
                hotPoints = spider_WEIBO_HOT.hotPoints;
                return hotPoints;
            }
            Label title;
            Label rank;
            Label hotDgree;
            LinkLabel url;

            public HotPointPanel()
            {
                List<WHotPoint> hotPoints = this.getList();
                foreach (WHotPoint p in hotPoints)
                {
                    rank = new Label();
                    rank.Text = p.Rank.ToString();
                    title = new Label();
                    title.Text = p.Title;
                    hotDgree = new Label();
                    hotDgree.Text = p.HotDegree;
                    url = new LinkLabel();
                    url.Text = p.Url;
                    //this.url.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.url_LinkClicked);
                    this.Controls.Add(rank);
                    this.Controls.Add(title);
                    this.Controls.Add(hotDgree);
                    this.Controls.Add(url);
                    
                   
                }
                //void url_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
                //{
                //    this.url.Link.LinkData = "[图片]http://www.sina.com";
                //    System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
                //}
            }
        }
    }
}
