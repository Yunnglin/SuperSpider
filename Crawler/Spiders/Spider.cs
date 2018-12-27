using HT.Spider;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Spider_Baidu
{
    public class Spider_Baidu
    {
  
    }
<<<<<<< HEAD
    public class Spider_Baidu_HOSTPOST : HTSpider
=======
    public class Spider_Baidu_HOSTPOST:HTSpider
>>>>>>> bcbb2a4b552d96add6a511166d6258a827299a34
    {
        public List<TopPost> list;

        public Spider_Baidu_HOSTPOST()
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
        public TopPost HotTop()                //获得今日热帖
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
            TopPost List = new TopPost();
            for (i = 12; i < 32; i++)
            {
                TopPost newTop = new TopPost(titleList[i].InnerText, hrefList[i].Attributes["href"].Value, HotList[k].InnerText, emList[j].InnerText);
                List.TopPosts.Add(newTop);
                k = k + 2;
                j++;
            }
            return List;
        }
        public SearchResult LookFor(String input)   //关键词搜索
        {
            HtmlWeb webClient = new HtmlWeb();
            string url = "https://tieba.baidu.com/f/good?kw=" + input;
            Encoding encoder = Encoding.GetEncoding("utf-8");
            HtmlAgilityPack.HtmlDocument doc = webClient.Load(url);
            HtmlNode LookFor = doc.DocumentNode;
            SearchResult result = new SearchResult();
            HtmlNodeCollection ResultHerf = doc.DocumentNode.SelectNodes(".//a[contains(@href,'fr=good')]");
<<<<<<< HEAD
            if (ResultHerf != null)
=======
            if (ResultHerf!=null)
>>>>>>> bcbb2a4b552d96add6a511166d6258a827299a34
            {
                for (int i = 0; i < 30; i++)
                {
                    int j = i + 15;
                    String urlget = "https://tieba.baidu.com" + ResultHerf[i].Attributes["href"].Value;
                    SearchResult newResult = new SearchResult(ResultHerf[i].Attributes["title"].Value, urlget);
                    result.lists.Add(newResult);
                }
                return result;
            }
            else
            {
                Console.WriteLine("关键词无效，未查到该帖子");
                return null;
            }
        }
        private void Parse(object sender,OnCompletedEventArgs args)
        {

            string url = "";
            url = Console.ReadLine();
            LookFor(url);
            //HotTop();
            //尝试历史

            //HtmlWeb webClient = new HtmlWeb();
            //HtmlWeb webClient2 = new HtmlWeb();

            //Encoding encoder = Encoding.GetEncoding("utf-8");
            //HtmlAgilityPack.HtmlDocument doc = webClient.Load("http://tieba.baidu.com/hottopic/browse/topicList?res_type=1&red_tag=q0593629036");
            //Encoding encoder2 = Encoding.GetEncoding("utf-8");
            //HtmlAgilityPack.HtmlDocument doc2 = webClient2.Load("https://tieba.baidu.com/f/good?kw=秦时明月");
            //HtmlNode htmlNode = doc.DocumentNode;
            //HtmlNodeCollection hrefList = doc.DocumentNode.SelectNodes(".//a[@href]");
            //HtmlNodeCollection titleList = doc.DocumentNode.SelectNodes(".//a");
            //HtmlNodeCollection emList = doc.DocumentNode.SelectNodes(".//p");
            //HtmlNodeCollection HotList = doc.DocumentNode.SelectNodes(".//span");
            //int i, j = 1, k = 3;
            //for (i = 12; i < 32; i++)
            //{

            //    Console.WriteLine("热帖标题：" + titleList[i].InnerText);
            //    Console.WriteLine("热帖简述：" + emList[j].InnerText);
            //    Console.WriteLine("热度：" + HotList[k].InnerText);
            //    Console.WriteLine("链接：" + hrefList[i].Attributes["href"].Value);
            //    k = k + 2;
            //    j++;
            //}
            //HtmlNode LookFor = doc2.DocumentNode;
            //HtmlNodeCollection ResultTitle = doc2.DocumentNode.SelectNodes(".//a[@title]");
            //HtmlNodeCollection ResultHerf = doc2.DocumentNode.SelectNodes(".//a[contains(@href,'fr=good')]");

            ////for (int i = 0; i < 30; i++)
            ////{
            ////    int j = i + 15;
            ////    Console.WriteLine("帖子：" + ResultTitle[j].Attributes["title"].Value);
            ////    Console.WriteLine("帖子链接为：" + "https://tieba.baidu.com" + ResultHerf[i].Attributes["href"].Value);
            ////}
            //for (int i = 0; i < 30; i++)
            //{
            //    int j = i + 15;
            //    Console.WriteLine("帖子：" + ResultHerf[i].Attributes["title"].Value);
            //    Console.WriteLine("帖子链接为：" + "https://tieba.baidu.com" + ResultHerf[i].Attributes["href"].Value);
            //}

            //Console.Write(args.PageSource);
        }
    }
}
