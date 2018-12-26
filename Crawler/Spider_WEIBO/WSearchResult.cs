using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider_WEIBO
{
    public class WSearchResult
    {
        /// <summary>
        /// 用户名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 转发数
        /// </summary>
        public string Post { get; set; }
        /// <summary>
        /// 点赞数
        /// </summary>
        public string Like { get; set; }
        /// <summary>
        /// 评论数
        /// </summary>
        public string Comment { get; set; }
        /// <summary>
        /// 来自
        /// </summary>
        public string From { get; set; }

        public int Count { get; set; }

        public WSearchResult(int count, string name, string content, string post, string like,string comment,string from)
        {
            Count = count;
            Name = name;
            Content = content;
            Post = post;
            Like = like;
            Comment = comment;
            From = from;
        }

        public override string ToString()
        {
            return Count+"  博主："+Name+Environment.NewLine
                +"内容摘要："+Content + Environment.NewLine
                + Post+"  "+Like+"  "+Comment+ Environment.NewLine
                + "来自："+From+ Environment.NewLine + "--------------------------+"+Environment.NewLine;
        }
    }
}
