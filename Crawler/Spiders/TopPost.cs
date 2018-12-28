using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider_Baidu
{
    public class TopPost
    {
        public String html { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public String Heat { get; set; }
        public List<TopPost> TopPosts { get; set; }
        public TopPost(string Title, string HT, string Heat, string Content)
        {
            this.html = HT;
            this.Content = Content;
            this.Heat = Heat;
            this.Title = Title;
        }
        public TopPost()
        {
            TopPosts = new List<TopPost>();
        }
        public override string ToString()
        {
            return html + "  " + Content + "  " + Heat;
        }

    }

}
