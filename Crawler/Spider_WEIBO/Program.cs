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

            //Spider_WEIBO_HOT h = new Spider_WEIBO_HOT();

            //h.StartCrawling().Wait();
            ////写入
            //foreach (var hot in h.hotPoints)
            //{
            //    Console.WriteLine(hot);
            //}

            //WriteFile w = new WriteFile(@"D:\hotdata6.csv",500,100);


            Spider_WEIBO_Search s = new Spider_WEIBO_Search("哈哈哈", 5);
            s.StartCrawling().Wait();
            foreach (var search in s.searchResults)
            {
                Console.WriteLine(search);
            }
        }
    }
}
