using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Spider_Baidu
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            Spider_Baidu_HOSTPOST hOT = new Spider_Baidu_HOSTPOST();
            hOT.GetFunc(new Uri("https://tieba.baidu.com")).Wait();

            //foreach (var i in hOT.list)
            //{
            //    System.Console.WriteLine(i.ToString());
            //}
            Console.WriteLine();
        }
    }
}
