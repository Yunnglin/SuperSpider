using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider_ZHIHU
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFile writeFile = new WriteFile("test.csv", 500, 100);
            Console.ReadKey();
            //Spider_ZHIHU_ANSWER answer = new Spider_ZHIHU_ANSWER("雪中悍刀行");
            //answer.StartCrawling().Wait();
        }
    }
}
