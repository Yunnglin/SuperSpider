using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spider_WEIBO;
using Spider_ZHIHU;

namespace WindowsFormsApp1
{
    public partial class HotMonitor : Form
    {
        string foldPath;
        Timer timer1;
        Spider_WEIBO.WriteFile w;
        Stopwatch myWatch;
        public HotMonitor()
        {
            InitializeComponent();
            ResumeBtn.Visible = false;
            PauseBtn.Visible = true;
            Resultabel.Text = "设置中...";
        }

        private void timer1EventProcessor(object source, EventArgs e)
        {
            if (w == null)
            {
                return;
            }
            timelable.Text = myWatch.Elapsed.ToString();
            numlable.Text = w.GetCount().ToString();
            if(w.GetCount().ToString()== textBoxNum.Text)
            {
                myWatch.Stop();
                Resultabel.Text = "监控完成！！！";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                foldPath = dialog.SelectedPath;
                Console.WriteLine(foldPath);
                
            }
        }

        private void StartBtn_Click(object sender, EventArgs e)//开始
        {
            if (foldPath == "")
            {
                MessageBox.Show("选择文件路径！");
                return;
            }
            try
            {
                timer1 = new Timer();
                timer1.Interval = 10;
                timer1.Tick += new EventHandler(timer1EventProcessor);//添加事件
                timer1.Enabled = true;
                timer1.Start();
                myWatch = Stopwatch.StartNew();
                myWatch.Start();
                w = new Spider_WEIBO.WriteFile(foldPath + '\\' +"微博热榜"+ DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".csv", Convert.ToInt32(textBoxNum.Text), Convert.ToInt32(textBoxOffset.Text));
                StartBtn.Enabled = false;
                Resultabel.Text = "运行中...";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PauseBtn_Click(object sender, EventArgs e)//暂停
        {
            if (w != null)
            {
                w.TimePause();
                ResumeBtn.Visible = true;
                PauseBtn.Visible = false;
                timer1.Stop();
                myWatch.Stop();
                Resultabel.Text = "暂停中...";
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)//取消
        {
            if (w != null)
            {
                w.TimeStop();
                timer1.Dispose();
                StartBtn.Enabled = true;
                Resultabel.Text = "设置中...";
            }
        }

        private void ResumeBtn_Click(object sender, EventArgs e)//继续
        {
            if (w != null)
            {
                w.TimeResume();
                ResumeBtn.Visible = false;
                PauseBtn.Visible = true;
                timer1.Start();
                myWatch.Start();
                Resultabel.Text = "运行中...";
            }

        }

        private void ResuBtn_Click(object sender, EventArgs e)
        {
            //调用系统默认的浏览器 
            System.Diagnostics.Process.Start("");
        }
    }
}
