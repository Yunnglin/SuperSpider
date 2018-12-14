using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider_ZHIHU
{
    public class Answer_ZHIHU
    {
        public String Title { get; set; }
        public String MultiLine { get; set; }
        public List<AnswerDetail> List { get; set; }
        public String Url { get; set; }
    }

    public class AnswerDetail
    {
        public String Content { get; set; }
        public String Responder { get; set; }
    }
}
