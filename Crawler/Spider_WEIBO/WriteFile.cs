using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Timers;

namespace Spider_WEIBO
{
    public class WriteFile
    {
        /// <summary>
        /// 记录当前时间
        /// </summary>
        private DateTime now;


        /// <summary>
        /// 写入文件位置
        /// </summary>
        private string path;


        /// <summary>
        /// 计时器
        /// </summary>
        private Timer timer;

        /// <summary>
        /// 已写入数量
        /// </summary>
        int count = 1;

        /// <summary>
        /// 最大写入量
        /// </summary>
        int max;
        /// <summary>
        /// 爬取时间间隔，单位s
        /// </summary>
        int offset;

        /// <summary>
        /// 写入文件
        /// </summary>
        /// <param name="path">写入文件位置</param>
        /// <param name="max">最大写入量</param>
        /// <param name="offset">爬取时间间隔，单位s</param>
        public WriteFile(string path, int max, int offset)
        {
            this.now = DateTime.Now;
            this.path = path;
            this.max = max;
            this.TimeStart();
            this.WriteCsv();
            this.offset = offset;
        }


        private void WriteCsv()
        {
    
            //判断文件是否存在
            if (File.Exists(path))
            {

            }
            else
            {
                StreamWriter file = new StreamWriter(path, true, Encoding.UTF8);
                file.WriteLine("name,value,date");
                file.Close();
            }


            //创建写入流
            StreamWriter writer = new StreamWriter(path, true, Encoding.UTF8);
            Spider_WEIBO_HOT h = new Spider_WEIBO_HOT();
            Timer timer = new Timer();
            h.StartCrawling().Wait();
            //写入
            int i = 0;
            foreach (var hot in h.hotPoints)
            {
                i++;
                writer.WriteLine("{0},{1},{2}", hot.Title, hot.HotDegree, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                if (i >= 20)
                    break;
            }
            writer.Close();
        }

        //开始计时
        private void TimeStart()
        {
            timer = new Timer
            {
                Enabled = true,
                Interval = 1000//执行间隔时间,单位为毫秒;此时时间间隔为1s
            };
            timer.Start();
            timer.Elapsed += Ring;
        }


        public void Ring(object source, ElapsedEventArgs e)//时间到了，执行操作
        {
            if (count >= max)
                timer.Stop();
            TimeSpan timeSpan = DateTime.Now - now;

            if (timeSpan.TotalSeconds >= offset)
            {
                now = DateTime.Now;
                this.WriteCsv();
                count++;
            }

        }
    }
}
