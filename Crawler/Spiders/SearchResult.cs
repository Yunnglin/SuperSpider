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
<<<<<<< HEAD
        public SearchResult(string Tit, String Url)
=======
        public SearchResult(string Tit,String Url)
>>>>>>> bcbb2a4b552d96add6a511166d6258a827299a34
        {
            this.Title = Tit;
            this.Url = Url;
        }
    }
}
