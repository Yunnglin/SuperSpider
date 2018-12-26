using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HT.Spider;
namespace Spider_ZHIHU
{
    public class Spider_ZHIHU_HOT:HTSpider,IController
    {
        public List<HotPoint_ZHIHU> hotList;
        public Spider_ZHIHU_HOT()
        {
            //初始化热点列表
            hotList = new List<HotPoint_ZHIHU>();

            //添加cookie实现模拟登录
            Cookie cookie = new Cookie("z_c0", "2|1:0|10:1544258229|4:z_c0|92:Mi4xdk04Z0F3QUFBQUFBRUdGU0x0bU1EU1lBQUFCZ0FsVk50ZEQ0WEFDR2RYNDd3UU9rUGZXNGY2bXl6bW82QWV2NUJB|eec6d9ebaa4334e00fa08bfa930f3d4ab9e565e6a0c55ee15edefd44b4791d46", "/", ".zhihu.com");
            this.CookiesContainer = new System.Net.CookieContainer();
            this.CookiesContainer.Add(cookie);

            //添加OnCompleted事件
            OnCompleted += Parse;
            //OnCompleted += (s, args) =>
            //{
            //    Console.WriteLine(args.PageSource);
            //};

            //添加异常处理
            OnError += (s, e) =>
            {
                System.Console.WriteLine(e.Message);
            };
        }

        
        public async Task<bool> StartCrawling()
        {
            return await Task.Run(()=>{
                this.GetFunc(new Uri("https://www.zhihu.com/hot")).Wait();
                return true;
            });
        }

        /// <summary>
        /// 对页面内容进行解析抓取
        /// </summary>
        /// <param name="sendor"></param>
        /// <param name="args"></param>
        private void Parse(object sendor, OnCompletedEventArgs args)
        {
            string strRef = @"(<div class=""HotItem-content"">)[\s|\S]+?<\/div><\/div><\/span><\/div><\/div>";
            MatchCollection matches = new Regex(strRef).Matches(args.PageSource);
            foreach (Match match in matches)
            {
                String url = new Regex(@"href="".+?""").Match(match.Value).Value.Substring(5).Trim('"');
                String title = new Regex(@"h2 class=""HotItem-title"".+?<").Match(match.Value).Value.Substring(25).Trim('<');
                String multiLine = String.Empty;
                try
                {
                    multiLine = new Regex(@"HotItem-excerpt"">.+?<").Match(match.Value).Value.Substring(17).Trim('<');
                }
                catch (Exception excep)
                {
                    Console.WriteLine("内部问题");
                    System.Console.WriteLine(excep.Message);
                }

                String degree = new Regex(@"<\/svg>.+?万").Match(match.Value).Value.Substring(6).Trim('万');
                hotList.Add(new HotPoint_ZHIHU(url, multiLine, title, Convert.ToInt32(degree)));
            }
        }
        
    }
}
