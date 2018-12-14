using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider_ZHIHU
{
    public class HotPoint_ZHIHU
    {
        public String Url { get; set; }

        public String MultiLine { get; set; }

        public String Title { get; set; }

        /// <summary>
        /// 热度（以万为单位）
        /// </summary>
        public int HotDegree { get; set; }

        public HotPoint_ZHIHU(String url, String multiLine, String title, int hotDegree)
        {
            this.Url = url;
            this.MultiLine = multiLine;
            this.Title = title;
            this.HotDegree = hotDegree;
        }


        public override String ToString()
        {
            return Title + "     " + HotDegree + "万热度\n" + MultiLine + "\n超链接:" + Url + "\n------------------------\n";
        }
    }
}
