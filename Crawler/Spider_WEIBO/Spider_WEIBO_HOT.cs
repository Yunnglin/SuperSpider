using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HT.Spider;
using System.Net;
using System.Text.RegularExpressions;


namespace Spider_WEIBO
{/// <summary>
 /// 爬取微博热搜
 /// </summary>
    public class Spider_WEIBO_HOT : HTSpider
    {
        //热搜列表
        public List<WHotPoint> hotPoints;

        public Spider_WEIBO_HOT()
        {
            hotPoints = new List<WHotPoint>();
            //添加cookie
            Cookie cookie = new Cookie("SUBP", "0033WrSXqPxfM725Ws9jqgMF55529P9D9WFCWhNRApjf73YoqnFQbw.x5JpX5K2hUgL.FoqR1hB4SonXehM2dJLoIp7LxKML1KBLBKnLxKqL1hnLBoMXS0-Xe0-fShnX", "/", ".weibo.com");
            this.CookiesContainer = new CookieContainer();
            this.CookiesContainer.Add(cookie);

            OnSetting += (s, e) =>
            {
                Console.WriteLine(e);
            };

            OnCompleted += (s, e) => {
                System.Console.WriteLine(e.PageSource);
            };

                

            OnError += (s, e) =>
            {
                System.Console.WriteLine(e.Message);
            };
        }
        /// <summary>
        /// 对页面内容进行解析抓取
        /// </summary>
        /// <param name="sendor"></param>
        /// <param name="args"></param>
        private void Parse(object sendor, OnCompletedEventArgs args)
        {
            string strRef = @"(<div class=""HotItem-content"">)[\s|\S]+?<\/div><\/div><\/span><\/div><\/div>";//@"(href|HREF)[ ]*=[ ]*[""'][^""'#(img)]+[""']"
            MatchCollection matches = new Regex(strRef).Matches(args.PageSource);
            foreach (Match match in matches)
            {
                String url = new Regex(@"href="".+?""").Match(match.Value).Value.Substring(5).Trim('"');
                String title = new Regex(@"h2 class=""HotItem-title"".+?<").Match(match.Value).Value.Substring(25).Trim('<');
                String rank = String.Empty;
                String degree = new Regex(@"<\/svg>.+?万").Match(match.Value).Value.Substring(6).Trim('万');
                hotPoints.Add(new WHotPoint(Convert.ToInt32(rank), url, title, degree));
            }
        }
    }
}
