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
             h.GetFunc(new Uri("https://s.weibo.com/top/summary?cate=realtimehot")).Wait();

            //微博搜索
            // h.GetFunc(new Uri(" https://s.weibo.com/weibo?q=xxx&Refer=article_weibo&page=1")).Wait();
            //  https://s.weibo.com/weibo?q=xxx&Refer=article_weibo&page=1  综合
            // https://s.weibo.com/article?q=xxx&Refer=weibo_article 文章

            //首页
            //h.GetFunc(new Uri("https://weibo.com")).Wait();
            // 

            foreach(var hot in h.hotPoints)
            {
                Console.WriteLine(hot);
            }
        
        }
    }
}
