using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HT.Spider;

namespace Spider_WEIBO
{
    class Program
    {
        static void Main(string[] args)
        {
            Spider_WEIBO_HOT h = new Spider_WEIBO_HOT();
            //热榜
            // h.GetFunc(new Uri("https://s.weibo.com/top/summary?Refer=top_hot&topnav=1&wvr=6")).Wait();

            //微博搜索
            h.GetFunc(new Uri("https://s.weibo.com/weibo?q=111&Refer=SWeibo_box")).Wait();
           //  https://s.weibo.com/weibo/111?topnav=1&wvr=6&b=1&page=1
           
            // 
            Console.ReadLine();
        }
    }
}
