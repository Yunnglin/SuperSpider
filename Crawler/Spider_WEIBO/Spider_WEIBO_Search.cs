using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HT.Spider;
namespace Spider_WEIBO
{
   public class Spider_WEIBO_Search: HTSpider,IController
    {
        public ConcurrentQueue<WSearchResult> searchResults;
        private string key;//关键字
        private int count;//数量
        public Spider_WEIBO_Search()
        {
            searchResults = new ConcurrentQueue<WSearchResult>();


        }

        public Task<bool> StartCrawling()
        {
            throw new NotImplementedException();
        }
    }
}
