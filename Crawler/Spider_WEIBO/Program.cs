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
            h.GetFunc(new Uri("https://weibo.com/")).Wait();
        }
    }
}
