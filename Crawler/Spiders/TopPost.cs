using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider_Baidu
{
<<<<<<< HEAD
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
=======
   public class TopPost
   {
     public String html { get; set; }
     public String Title { get; set; }
     public String Content { get; set; }
     public String Heat { get; set; }

     public TopPost(string Title,string HT,string Heat,string Content)
     {
            this.html = HT;
            this.Content =Content;
            this.Heat = Heat;
            this.Title = Title;
     }
     public TopPost()
     {
        TopPosts = new List<TopPost>();
     }
     public  List<TopPost> TopPosts { get;set; }
     public override string ToString()
     {
            return html+"  "+Content+"  "+Heat;
     }
>>>>>>> bcbb2a4b552d96add6a511166d6258a827299a34
    }

}
