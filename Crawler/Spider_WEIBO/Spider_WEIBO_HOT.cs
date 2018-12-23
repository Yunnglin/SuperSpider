using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HT.Spider;
using System.Net;
using System.Text.RegularExpressions;
using HtmlAgilityPack;


namespace Spider_WEIBO
{/// <summary>
 /// 爬取微博热搜
 /// </summary>
    public class Spider_WEIBO_HOT : HTSpider,IController
    {
        //热搜列表
        public List<WHotPoint> hotPoints;
        /// <summary>
        /// 事件驱动爬取热搜
        /// </summary>
        public Spider_WEIBO_HOT()
        {
            hotPoints = new List<WHotPoint>();
            //添加cookie
            //Cookie cookie = new Cookie("SUBP", "0033WrSXqPxfM725Ws9jqgMF55529P9D9WFCWhNRApjf73YoqnFQbw.x5JpX5K2hUgL.FoqR1hB4SonXehM2dJLoIp7LxKML1KBLBKnLxKqL1hnLBoMXS0-Xe0-fShnX", "/", ".weibo.com");
            // string set_cookies= "login_sid_t=e949e9e70fd13adcc29d364afc153682; cross_origin_proto=SSL; Ugrow-G0=370f21725a3b0b57d0baaf8dd6f16a18; YF-V5-G0=fec5de0eebb24ef556f426c61e53833b; _s_tentry=passport.weibo.com; Apache=7638869583718.113.1545026860933; SINAGLOBAL=7638869583718.113.1545026860933; ULV=1545026860945:1:1:1:7638869583718.113.1545026860933:; YF-Page-G0=091b90e49b7b3ab2860004fba404a078; wb_view_log_6884968407=1536*8641.5625; WBtopGlobal_register_version=75a427cc2b27cf18; UOR=,,login.sina.com.cn; wb_view_log=1536*8641.5625; un=1073788244@qq.com; WBStorage=bfb29263adc46711|undefined; SUBP=0033WrSXqPxfM725Ws9jqgMF55529P9D9WFCWhNRApjf73YoqnFQbw.x5JpX5K2hUgL.FoqR1hB4SonXehM2dJLoIp7LxKML1KBLBKnLxKqL1hnLBoMXS0-Xe0-fShnX; ALF=1576587057; SSOLoginState=1545051060; SCF=ApqNez1pTS4tXDkaJFe5zVtKRDsIUcR32lNVVrq6g_KI6xQtnuAZjQ_8ra9Yx4ZfwJx1WvzeG6aQjMpeF1dHSK4.; SUB=_2A25xE-vlDeRhGeBG41YY9ibIyzuIHXVSaVotrDV8PUNbmtBeLXTNkW9NQfhw_Fx9ba0wn79l64e41hxwn_fbricU; SUHB=0sqR7SW8uLAwAC; wvr=6; path=/; domain=.weibo.com";
            //  string cook = CookieHelper.GetCookies(cookies, new Uri("https://weibo.com/u/6884968407/home"));
            // CookieCollection cookieCollection = new CookieCollection();
            //  cookieCollection= CookieHelper.GetCookiesByHeader(set_cookies);
            // CookiesContainer = new CookieContainer();
            // CookiesContainer.Add(cookieCollection);

            OnCompleted += Parse;

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


        /// <summary>
        /// 对页面内容进行解析抓取
        /// </summary>
        /// <param name="sendor"></param>
        /// <param name="args"></param>
        private void Parse(object sendor, OnCompletedEventArgs args)
        {
            string pattern = @"(?s)(?<=<tr class="""">).+?(?=</tr>)";
            RegexOptions regexOptions = RegexOptions.None;
            Regex regex = new Regex(pattern, regexOptions);
            string inputData = args.PageSource;
            foreach (Match match in regex.Matches(inputData))
            {
                if (match.Success)
                {
                    try
                    {
                        HtmlDocument doc = new HtmlDocument();
                        doc.LoadHtml(match.Value);
                        String url = "https://s.weibo.com" + new Regex(@"(?<=href="").+?(?="")").Match(match.Value).Value;
                        String title = new Regex(@"(?<=>).+?(?=</a>)").Match(match.Value).Value;
                        title= Regex.Replace(title, @"<img\b[^>]*>", "");
                        String rank = new Regex(@"(?<=<td class=""td-01 ranktop"">).+?(?=</td>)").Match(match.Value).Value;
                        String degree = new Regex(@"(?<=<span>).+?(?=</span>)").Match(match.Value).Value;
                        HtmlNode icon = doc.DocumentNode.SelectSingleNode(".//i");
                        if (icon != null)
                        {
                            if (icon.InnerText == "荐")
                                continue;
                        }
                        if (rank == "")
                            continue;
                        hotPoints.Add(new WHotPoint(Convert.ToInt32(rank), url, title, degree));
                    }
                    catch (Exception e)
                    {
                       // Console.WriteLine(e.Message);
                    }
                }
            }
        }

        /// <summary>
        /// 继承总控制器，开始爬取
        /// </summary>
        /// <returns>布尔值</returns>
       public async Task<bool> StartCrawling()
        {
            return await Task.Run(() =>
            {
                this.GetFunc(new Uri("https://s.weibo.com/top/summary?cate=realtimehot")).Wait();
                return true;
            });
        }
    }
}
