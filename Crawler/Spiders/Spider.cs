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
        private void Parse(object sender,OnCompletedEventArgs args)
        {


            //Console.Write(args.PageSource);

            HtmlWeb webClient = new HtmlWeb();
            HtmlWeb webClient2 = new HtmlWeb();
            Encoding encoder = Encoding.GetEncoding("utf-8");
            HtmlAgilityPack.HtmlDocument doc = webClient.Load("https://my.hupu.com/search?q=%E7%A0%94%E7%A9%B6%E7%94%9F");
            HtmlAgilityPack.HtmlDocument doc2 = webClient2.Load("https://my.hupu.com/search?q=%E7%A0%94%E7%A9%B6%E7%94%9F");

            Console.Write(doc);
            Console.WriteLine();
            Console.Write(doc2);
            HtmlNode htmlNode = doc.DocumentNode;
            HtmlNodeCollection hrefList = doc.DocumentNode.SelectNodes(".//a[@href]");
            HtmlNodeCollection titleList = doc.DocumentNode.SelectNodes(".//a[@title]");
            HtmlNodeCollection emList = doc.DocumentNode.SelectNodes(".//em");
            
            int j = 1;int k = 0;
            for (int i = 54; i < 155; i++, i++)
            {
                string s = emList[k].InnerText;
                Console.WriteLine(titleList[j].Attributes["title"].Value + "     热度："+s);
                Console.WriteLine("热帖链接："+"https://bbs.hupu.com" + hrefList[i].Attributes["href"].Value);
              
                j++;
                k++;

            }
          
            //if (titleList != null)
            //{
            //    int i = 1;
            //    foreach (HtmlNode title in titleList)
            //    {
            //        HtmlAttribute att = title.Attributes["title"];
            //        Console.WriteLine(att.Value+"    "+i);
            //        i++;
            //    }
            //}
            //Console.Write(args.PageSource);
        }
    }
}
