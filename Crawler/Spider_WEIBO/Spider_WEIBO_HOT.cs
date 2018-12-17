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
           //string cookies= "SINAGLOBAL = 9374468169968.848.1544759764946; un = 1073788244@qq.com; wvr = 6; UOR =,,login.sina.com.cn; Ugrow - G0 = 5b31332af1361e117ff29bb32e4d8439; SUBP = 0033WrSXqPxfM725Ws9jqgMF55529P9D9WFCWhNRApjf73YoqnFQbw.x5JpX5KMhUgL.FoqR1hB4SonXehM2dJLoIp7LxKML1KBLBKnLxKqL1hnLBoMXS0 - Xe0 - fShnX; ALF = 1576410670; SSOLoginState = 1544874673; SCF = ApqNez1pTS4tXDkaJFe5zVtKRDsIUcR32lNVVrq6g_KIQwjzxH_XZIqouFMXiQITwdIogur_YlGFFWMrqzLpi4I.; SUB = _2A25xEJriDeRhGeBG41YY9ibIyzuIHXVSZ4sqrDV8PUNbmtBeLRjlkW9NQfhw_AzZFaAjMIJF87gzCIlVnDz21C5s; SUHB = 03oVSoBB2po_Ym; YF - V5 - G0 = bb389e7e25cccb1fadd4b1334ab013c1; _s_tentry = -; Apache = 6696694567241.79.1544874685716; ULV = 1544874685737:4:4:4:6696694567241.79.1544874685716:1544787969783; YF - Page - G0 = 4c69ce1a525bc6d50f53626826cd2894; wb_view_log_6884968407 = 1536 * 8641.5625; WBtopGlobal_register_version = 75a427cc2b27cf18";
           // string cook = CookieHelper.GetCookies(cookies, new Uri("https://weibo.com/u/6884968407/home"));
           // CookieCollection cookieCollection = new CookieCollection();
            //cookieCollection= CookieHelper.GetCookiesByHeader(cookies);
            //CookiesContainer = new CookieContainer();
           //CookiesContainer.Add(cookie);

            OnCompleted += (s, e) => {
                Console.WriteLine(e.PageSource);
            };

            OnStart += (s, e) =>
            {
                Console.Write("ready");
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
