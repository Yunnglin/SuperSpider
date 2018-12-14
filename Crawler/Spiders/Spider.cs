using HT.Spider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Spider_HUPU
{
    public class Spider_HUPU
    {
  
    }
    public class Spider_HUPU_HOSTPOST:HTSpider
    {
        public List<TopPost> list;

        public Spider_HUPU_HOSTPOST()
        {
            list = new List<TopPost>();

            OnCompleted += Parse;

            OnError += (s, e) =>
            {
                System.Console.WriteLine(e.Message);
            };

            OnStart += (s, e) =>
            {
                Console.Write("ready");
            };

            OnSetting += (s, e) =>
            {
                Console.WriteLine(e.ToString());
            };
        }
        private void Parse(object sender,OnCompletedEventArgs args)
        {
           // Console.Write(args.PageSource);
            string str = @"\b<span\S*<\\span>\b";
            MatchCollection mc = Regex.Matches(args.PageSource, str);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
            //Console.Write(args.PageSource);
        }
    }
}
