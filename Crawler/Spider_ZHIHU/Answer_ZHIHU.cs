using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider_ZHIHU
{
    public class Answer_ZHIHU
    {
        /// <summary>
        /// 标题
        /// </summary>
        public String Title { get; set; }

        /// <summary>
        /// 概要
        /// </summary>
        public String MultiLine { get; set; }

        /// <summary>
        /// 回答列表
        /// </summary>
        public List<AnswerDetail> List { get; set; }

        /// <summary>
        /// 题目链接
        /// </summary>
        public String Url { get; set; }
    }

    public class AnswerDetail
    {
        /// <summary>
        /// 回答内容
        /// </summary>
        public String Content { get; set; }

        /// <summary>
        /// 回答者
        /// </summary>
        public String Responder { get; set; }

        /// <summary>
        /// 赞数
        /// </summary>
        public int UpNumber { get; set; }

        public AnswerDetail(String content,String responder, int voteUp)
        {
            Content = content;
            Responder = responder;
            UpNumber = voteUp;
        }
    }
}
