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
    public class Spider_ZHIHU_ANSWER:IController
    {
        public List<Answer_ZHIHU> AnswerList{get => getAnswerSpider.AnswerList; } 
        private String key;
        private SearchSpider_ZHIHU searchSpider;
        private GetAnswerSpider_ZHIHU getAnswerSpider;
        public Spider_ZHIHU_ANSWER(String key)
        {
            this.key = key;
            searchSpider = new SearchSpider_ZHIHU();
            getAnswerSpider = new GetAnswerSpider_ZHIHU();
        }


        public async Task<bool> StartCrawling()
        {
            return await Task.Run(() =>
            {
                //爬行搜索api
                searchSpider.GetFunc(new Uri("https://www.zhihu.com/api/v4/search_v3?t=general&q=" + key + "&correction=1&offset=0&limit=20&show_all_topics=0&search_hash_id=5db763fd484e1b10478ed46f3e1e7f64&vertical_info=0%2C1%2C0%2C1%2C1%2C0%2C0%2C0%2C0%2C1"));//ContinueWith((a)=> { Console.WriteLine(a); });
                while (true)
                {
                    //爬取5个问题
                    if (getAnswerSpider.Count > 4)
                    {
                        break;
                    }
                    if (searchSpider.answerUrls.IsEmpty)
                    {
                        continue;
                    }
                    String url;
                    if (searchSpider.answerUrls.TryDequeue(out url))
                    {
                        getAnswerSpider.GetFunc(new Uri("https://www.zhihu.com/api/v4/questions/"+url+"/answers?include=data%5B%2A%5D.is_normal%2Cadmin_closed_comment%2Creward_info%2Cis_collapsed%2Cannotation_action%2Cannotation_detail%2Ccollapse_reason%2Cis_sticky%2Ccollapsed_by%2Csuggest_edit%2Ccomment_count%2Ccan_comment%2Ccontent%2Ceditable_content%2Cvoteup_count%2Creshipment_settings%2Ccomment_permission%2Ccreated_time%2Cupdated_time%2Creview_info%2Crelevant_info%2Cquestion%2Cexcerpt%2Crelationship.is_authorized%2Cis_author%2Cvoting%2Cis_thanked%2Cis_nothelp%2Cis_labeled%3Bdata%5B%2A%5D.mark_infos%5B%2A%5D.url%3Bdata%5B%2A%5D.author.follower_count%2Cbadge%5B%2A%5D.topics&limit=5&offset=0&platform=desktfop&sort_by=default")).Wait();
                    }
                }
                return true;
            });
            
        }

    }

    public class SearchSpider_ZHIHU:HTSpider
    {
        public ConcurrentQueue<String> answerUrls;
        private int count;
        public bool Downloaded { get; private set; }
        public SearchSpider_ZHIHU()
        {
            answerUrls = new ConcurrentQueue<string>();
            count = 0;
            OnCompleted += Parse;
            OnError += (s, e) =>
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            };
        }


        private void Parse(object sender, OnCompletedEventArgs e)
        {
            Downloaded = true;
            String strRef = @"""url"":""https:\/\/api.zhihu.com\/questions\/[0-9]+?""";
            MatchCollection matches = new Regex(strRef).Matches(e.PageSource);
            foreach(Match match in matches)
            {
                //爬取5个问题
                if (count>4)
                {
                    break;
                }
                try
                {
                    String url = new Regex(@"[0-9]+?""").Match(match.Value).Value.Trim('"', '\\');
                    answerUrls.Enqueue(url);
                    count++;
                }
                catch(Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
                
            }
        }
    }

    class GetAnswerSpider_ZHIHU:HTSpider
    {
        public int Count { get; private set; }
        private int index;
        private Object lock1;
        private Object lock2;
        public List<Answer_ZHIHU> AnswerList { get; private set; }
        private HTSpider multiSpider;
        public GetAnswerSpider_ZHIHU()
        {
            lock1 = new Object();
            lock2 = new Object();
            this.AnswerList = new List<Answer_ZHIHU>();
            OnCompleted += Parse;
            OnError += (s, e) =>
            {
                Console.WriteLine(e.Message);
            };
            Count = 0;
            multiSpider = new HTSpider();
            multiSpider.OnCompleted += MultiParse;
            multiSpider.OnError += (s, e) =>
            {
                Console.WriteLine(e.Message);
            };
        }

        private void Parse(Object sendor,OnCompletedEventArgs args)
        {
            lock(lock1)
            {
                Count++;
                Answer_ZHIHU answer = new Answer_ZHIHU();
                try
                {
                    String strRef = @"{""id""[\s|\S]+?""upvoted_followees"":";
                    MatchCollection matches = new Regex(strRef).Matches(args.PageSource);
                    strRef = @"title"":""[\s|\S]+?""";
                    answer.Title = new Regex(strRef).Match(matches[0].Value).Value.Substring(7).Trim('"');
                    strRef = @"url"":""[\s|\S]+?""";
                    answer.Url = new Regex(strRef).Match(matches[0].Value).Value.Substring(5).Trim('"');
                    answer.Url = Regex.Replace(answer.Url, @"\/api\/v4\/questions", @"/question");
                    
                    String author, content, voteUp;
                    answer.List = new List<AnswerDetail>();
                    foreach (Match match in matches)
                    {
                        author = new Regex(@"name"":""[\s|\S]+?""").Match(match.Value).Value.Substring(7).Trim('"');
                        voteUp = new Regex(@"voteup_count"":[0-9]+?,").Match(match.Value).Value.Substring(14).Trim(',');
                        content = new Regex(@"content"":""[\s|\S]+?"",""").Match(match.Value).Value.Substring(10).Trim('"', ',');
                        content = Regex.Replace(content, @"\\u003c[\s|\S]+?\\u003e", "");
                        answer.List.Add(new AnswerDetail(content, author, Convert.ToInt32(voteUp)));
                    }
                    AnswerList.Add(answer);
                    multiSpider.GetFunc(new Uri(answer.Url)).Wait();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private void MultiParse(Object sendor,OnCompletedEventArgs args)
        {
            try
            {
                String strRef = @"RichText ztext"" itemProp=""text"">[\s|\S]+?<";
                String multiLine = new Regex(strRef).Match(args.PageSource).Value.Substring(32);
                AnswerList[Count - 1].MultiLine = Regex.Replace(multiLine, @"<[\s|\S]+?>", "").Trim('<');
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                AnswerList[Count - 1].MultiLine = "无";
            }
            
        }
    }
}
