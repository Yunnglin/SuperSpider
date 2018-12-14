using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spider_HUPU
{
   public class TopPost
   {
     public String html { get; set; }
     public String Content { get; set; }
     public String Heat { get; set; }

     public TopPost(string a,string b,string c)
     {
            this.html = a;
            this.Content = b;
            this.Heat = c;
     }
        public override string ToString()
        {
            return html+"  "+Content+"  "+Heat;
        }
    }
   
}
