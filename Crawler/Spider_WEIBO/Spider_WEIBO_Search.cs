using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HT.Spider;
using System.Net;
using HtmlAgilityPack;
using System.Text.RegularExpressions;

namespace Spider_WEIBO
{
    public class Spider_WEIBO_Search : HTSpider, IController
    {

        public ConcurrentQueue<WSearchResult> searchResults;
        private string key;//关键字
        private int count;//数量
        private int page;//页面数
        public Spider_WEIBO_Search(string key, int page)
        {
            searchResults = new ConcurrentQueue<WSearchResult>();
            this.key = key;
            this.page = page;
            this.count = 0;
            //添加cookie
            Cookie cookie = new Cookie("SUB", "_2A25xGLHADeRhGeBG41YY9ibIyzuIHXVS4t-IrDV6PUJbktANLWnikW1NQfhw_BkLDGR5c17J1WGLNd9jEC59heNf", "/", ".weibo.cn");
            string set_cookies = "WEIBOCN_FROM=deleted; expires=Thu, 01-Jan-1970 00:00:01 GMT; path=/; domain=.weibo.cn";
            string set_cookies2 = "M_WEIBOCN_PARAMS=luicode%3D10000011%26lfid%3D100103type%253D1%2526q%253D000; expires=Fri, 21-Dec-2018 10:27:11 GMT; path=/; domain=.weibo.cn";
            CookieCollection cookieCollection1 = new CookieCollection();
            cookieCollection1 = CookieHelper.GetCookiesByHeader(set_cookies);
            CookieCollection cookieCollection2 = new CookieCollection();
            cookieCollection2 = CookieHelper.GetCookiesByHeader(set_cookies2);
            CookiesContainer = new CookieContainer();
            CookiesContainer.Add(cookieCollection1);
            CookiesContainer.Add(cookieCollection2);
            CookiesContainer.Add(cookie);

            OnCompleted += Parse;
            //OnCompleted += (s, e) =>
            //{
            //    Console.WriteLine(e.PageSource);
            //};

            OnStart += (s, e) =>
            {
            };

            OnSetting += (s, e) =>
            {
                Console.WriteLine(e.ToString());
            };


            OnError += (s, e) =>
            {
                Console.WriteLine(e.Message);
            };

        }

        public async Task<bool> StartCrawling()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= page; i++)
                {
                    this.GetFunc(new Uri("https://s.weibo.com/weibo?q=" + key + "&Refer=article_weibo&page=" + i)).Wait();
                }
            });
            return true;
        }



        private void Parse(object sendor, OnCompletedEventArgs args)
        {
            try
            {
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(args.PageSource);
                HtmlNodeCollection cards = doc.DocumentNode.SelectNodes("//div[@class='card']");

                foreach (var card in cards)
                {
                    HtmlNode cardfeed = card.SelectSingleNode(".//div[@class='card-feed']");

                    //昵称
                    HtmlNode n = cardfeed.SelectSingleNode(".//a[1][@class='name']");
                    string name = n.InnerText.Trim();
                    // Console.WriteLine(name);
                    //内容简介
                    HtmlNode c = cardfeed.SelectSingleNode(".//p[1]");
                    string content = c.InnerText.Trim();
                    content = Regex.Replace(content, @"(展开全文c|\?)", "");
                    content = Regex.Replace(content, @"\?", "");
                    // Console.WriteLine(content);
                    //来自
                    HtmlNode f = cardfeed.SelectSingleNode(".//p[@class='from']");
                    string from = f.InnerText.Trim();
                    from = Regex.Replace(from, @"\s", "");
                    // Console.WriteLine(from);

                    HtmlNode cardAction = card.SelectSingleNode(".//div[@class='card-act']");

                    //转发
                    HtmlNode p = cardAction.SelectSingleNode(".//li[2]/a");
                    string post = p.InnerText.Trim();

                    //评论
                    HtmlNode com = cardAction.SelectSingleNode(".//li[3]/a");
                    string comment = com.InnerText.Trim();

                    //点赞
                    HtmlNode li = cardAction.SelectSingleNode(".//ul/li[4]/a");
                    string like = "赞 " + li.InnerText.Trim();
                    count++;
                    searchResults.Enqueue(new WSearchResult(count, name, content, post, like, comment, from));
                    //Console.WriteLine(count);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
