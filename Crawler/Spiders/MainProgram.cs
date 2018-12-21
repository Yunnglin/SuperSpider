using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Spider_HUPU
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Spider_HUPU_HOSTPOST hOT = new Spider_HUPU_HOSTPOST();
            hOT.GetFunc(new Uri("https://my.hupu.com/search?q=%E6%B8%B8&fid=&type=undefined&sortby=undefined")).Wait();
            //foreach (var i in hOT.list)
            //{
            //    System.Console.WriteLine(i.ToString());
            //}
            Console.WriteLine();
        }
    }
}
