using HT.Spider;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Spider_HUPU
{
    public class Spider_HUPU
    {
  
    }
    public class Spider_HUPU_HOSTPOST:HTSpider
    {
        public List<TopPost> list;

        public Spider_HUPU_HOSTPOST()
        {
            list = new List<TopPost>();

            OnCompleted += Parse;

            OnError += (s, e) =>
            {
                System.Console.WriteLine(e.Message);
            };

            OnStart += (s, e) =>
            {
                Console.Write("ready");
            };

            OnSetting += (s, request) =>
            {
                request.Headers.Add("Cache-Control", "no-cache");
            };
        }
        public void HotTop()                //获得今日热帖
        {
            HtmlWeb webClient = new HtmlWeb();
            Encoding encoder = Encoding.GetEncoding("utf-8");
            HtmlAgilityPack.HtmlDocument doc = webClient.Load("http://tieba.baidu.com/hottopic/browse/topicList?res_type=1&red_tag=q0593629036");
            HtmlNode htmlNode = doc.DocumentNode;
            HtmlNodeCollection hrefList = doc.DocumentNode.SelectNodes(".//a[@href]");
            HtmlNodeCollection titleList = doc.DocumentNode.SelectNodes(".//a");
            HtmlNodeCollection emList = doc.DocumentNode.SelectNodes(".//p");
            HtmlNodeCollection HotList = doc.DocumentNode.SelectNodes(".//span");
            int i, j = 1, k = 3;
            for (i = 12; i < 32; i++)
            {

                Console.WriteLine("热帖标题：" + titleList[i].InnerText);
                Console.WriteLine("热帖简述：" + emList[j].InnerText);
                Console.WriteLine("热度：" + HotList[k].InnerText);
                Console.WriteLine("链接：" + hrefList[i].Attributes["href"].Value);
                k = k + 2;
                j++;
            }
        }
        public void LookFor(String input)   //关键词搜索
        {
            HtmlWeb webClient = new HtmlWeb();
            string url = "https://tieba.baidu.com/f/good?kw=" + input;
            Encoding encoder = Encoding.GetEncoding("utf-8");
            HtmlAgilityPack.HtmlDocument doc = webClient.Load(url);
            HtmlNode LookFor = doc.DocumentNode;
            HtmlNodeCollection ResultTitle = doc.DocumentNode.SelectNodes(".//a[@title]");
            HtmlNodeCollection ResultHerf = doc.DocumentNode.SelectNodes(".//a[contains(@href,'fr=good')]");

            for (int i = 0; i < 30; i++)
            {
                int j = i + 15;
                Console.WriteLine("帖子：" + ResultTitle[j].Attributes["title"].Value);
                Console.WriteLine("帖子链接为：" + "https://tieba.baidu.com" + ResultHerf[i].Attributes["href"].Value);
            }
        }
        private void Parse(object sender,OnCompletedEventArgs args)
        {
            //尝试历史

            //HtmlWeb webClient = new HtmlWeb();
            //HtmlWeb webClient2 = new HtmlWeb();
            
            //Encoding encoder = Encoding.GetEncoding("utf-8");
            //HtmlAgilityPack.HtmlDocument doc = webClient.Load("http://tieba.baidu.com/hottopic/browse/topicList?res_type=1&red_tag=q0593629036");
            //Encoding encoder2 = Encoding.GetEncoding("utf-8");
            //HtmlAgilityPack.HtmlDocument doc2 = webClient2.Load("https://tieba.baidu.com/f/good?kw=校花的贴身高手");
            ////HtmlNode htmlNode = doc.DocumentNode;
            ////HtmlNodeCollection hrefList = doc.DocumentNode.SelectNodes(".//a[@href]");
            ////HtmlNodeCollection titleList = doc.DocumentNode.SelectNodes(".//a");
            ////HtmlNodeCollection emList = doc.DocumentNode.SelectNodes(".//p");
            ////HtmlNodeCollection HotList = doc.DocumentNode.SelectNodes(".//span");
            ////int i ,j = 1,k = 3;
            ////for ( i=12;i<32;i++)
            ////{

            ////    Console.WriteLine("热帖标题："+titleList[i].InnerText);
            ////    Console.WriteLine("热帖简述："+emList[j].InnerText);
            ////    Console.WriteLine("热度："+HotList[k].InnerText);
            ////    Console.WriteLine("链接："+hrefList[i].Attributes["href"].Value);
            ////    k = k + 2;
            ////    j++;
            ////}
            //HtmlNode LookFor = doc2.DocumentNode;
            //HtmlNodeCollection ResultTitle = doc2.DocumentNode.SelectNodes(".//a[@title]");
            //HtmlNodeCollection ResultHerf = doc2.DocumentNode.SelectNodes(".//a[contains(@href,'fr=good')]");
            
            //for (int i = 0; i < 30; i++)
            //{
            //    int j = i + 15;
            //    Console.WriteLine("帖子："+ResultTitle[j].Attributes["title"].Value);
            //    Console.WriteLine("帖子链接为："+ "https://tieba.baidu.com"+ResultHerf[i].Attributes["href"].Value );
            //}
          
           
            //Console.Write(args.PageSource);
        }
    }
}
