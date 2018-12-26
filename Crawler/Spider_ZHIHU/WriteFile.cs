using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using System.IO;
using HT.Spider;

namespace Spider_ZHIHU
{
    public class WriteFile
    {
        private DateTime now;

        private string path;

        private Timer timer;

        int count = 1;

        int max;

        int offset;

        public WriteFile(string path, int max, int offset)
        {

            this.offset = offset;
            this.now = DateTime.Now;
            this.path = path;
            this.max = max;
            this.WriteCsv();
            this.TimeStart();
        }

        public void WriteCsv()
        {
            if(!File.Exists(path))
            {
                using (StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8))
                {
                    writer.WriteLine("name,value,date");
                }
            }
            
            using (StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8))
            {
                Spider_ZHIHU_HOT spider = new Spider_ZHIHU_HOT(20);
                spider.StartCrawling().Wait();

                int i = 0;
                foreach(var hot in spider.hotList)
                {
                    i++;
                    writer.WriteLine("{0},{1},{2}", hot.Title, hot.HotDegree, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    if (i >= 20)
                        break;
                }
            }
        }

        private void TimeStart()
        {
            timer = new Timer
            {
                Enabled = true,
                Interval = 1000
            };
            timer.Start(); 
            timer.Elapsed += Ring;
        }

        private void Ring(Object source, ElapsedEventArgs e)
        {
            if (count >= max)
                timer.Stop();
            TimeSpan timeSpan = DateTime.Now-now;
            if (timeSpan.TotalSeconds >= offset)
            {
                now = DateTime.Now;
                this.WriteCsv();
                count++;
            }
        }
    }
}
