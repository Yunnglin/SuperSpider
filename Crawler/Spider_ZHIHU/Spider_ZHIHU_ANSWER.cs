using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using HT.Spider;

namespace Spider_ZHIHU
{
    public class Spider_ZHIHU_ANSWER : HTSpider, IController
    {
        List<Answer_ZHIHU> answerList;
        private String key;
        SearchSpider_ZHIHU searchSpider;
        GetAnswerSpider_ZHIHU getAnswerSpider;
        Spider_ZHIHU_ANSWER()
        {
            answerList = new List<Answer_ZHIHU>();


        }


        public void StartCrawling()
        {
            searchSpider.GetFunc(new Uri("https://www.zhihu.com/search?type=content&q=" + key));
            while(true)
            {
                if(getAnswerSpider.Count>9)
                {
                    break;
                }
                if(searchSpider.answerUrls.IsEmpty)
                {
                    continue;
                }
                String url;
                if(searchSpider.answerUrls.TryDequeue(out url))
                {
                    getAnswerSpider.GetFunc(new Uri(url));
                }
            }
        }
    }

    class SearchSpider_ZHIHU:HTSpider
    {
        public ConcurrentQueue<String> answerUrls;
        private int count;
        public bool Downloaded { get; private set; }
        public SearchSpider_ZHIHU()
        {
            answerUrls = new ConcurrentQueue<string>();
            count = 0;
            OnCompleted += Parse;
        }
        private void Parse(object sender, OnCompletedEventArgs e)
        {
            Downloaded = true;
            String strRef = @"(data-za-detail-view-id)+?<\/a>";
            MatchCollection matches = new Regex(strRef).Matches(e.PageSource);
            foreach(Match match in matches)
            {
                if(count>9)
                {
                    break;
                }
                String url = new Regex(@"(href="")[\s|\S]+?("">)").Match(match.Value).Value.Substring(5).Trim('"','>');
                answerUrls.Enqueue(url);
                count++;
            }
        }
    }

    class GetAnswerSpider_ZHIHU:HTSpider
    {
        public int Count { get; private set; }
    }
}
