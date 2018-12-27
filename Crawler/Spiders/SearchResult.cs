using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider_Baidu
{
    public class SearchResult
    {
        public string Title { set; get; }
        public String Url { set; get; }
        public List<SearchResult> lists { set; get; }
        public SearchResult()
        {
            lists = new List<SearchResult>();
        }
        public SearchResult(string Tit,String Url)
        {
            this.Title = Tit;
            this.Url = Url;
        }
    }
}
