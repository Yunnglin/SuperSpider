using Spider_ZHIHU;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class Win_ZHIHU_ANSWER:Panel
    {
        private Win_ZHIHU_HeadPanel headPanel;
        //private List<Win_ZHIHU_Response> answers;
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="answer"></param>
        public Win_ZHIHU_ANSWER(Answer_ZHIHU answer)
        {
            headPanel = new Win_ZHIHU_HeadPanel(answer.Title, answer.MultiLine, answer.Url);
            this.Controls.Add(headPanel);
            foreach(var detail in answer.List)
            {
                Win_ZHIHU_Response response = new Win_ZHIHU_Response(detail);
                this.Controls.Add(response);
            }
        }

    }

    class Win_ZHIHU_HeadPanel : Panel
    {
        private LinkLabel title;
        private Label multiLine;

        public Win_ZHIHU_HeadPanel(String title,String multiLine, String url)
        {
            this.title.Text = title;
            this.title.AutoSize = true;
            this.title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.title.Dock = System.Windows.Forms.DockStyle.Top;
            this.title.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.LinkColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.title.Size = new System.Drawing.Size(156, 25);
            this.title.TabIndex = 0;
            this.title.TabStop = true;
            this.title.Name = url;
            this.title.LinkClicked += OpenWeb;

            this.multiLine.Text = multiLine;
            this.multiLine.AutoSize = true;
            this.multiLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.multiLine.Location = new System.Drawing.Point(0, 25);
            this.multiLine.Margin = new System.Windows.Forms.Padding(0);
            this.multiLine.Name = "label12";
            this.multiLine.Padding = new System.Windows.Forms.Padding(0, 15, 0, 5);
            this.multiLine.Size = new System.Drawing.Size(405, 35);
            this.multiLine.TabIndex = 1;

            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.title);
            this.Controls.Add(this.multiLine);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = title;
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Size = new System.Drawing.Size(756, 72);
            this.TabIndex = 0;

            
        }

        private void OpenWeb(object sendor, LinkLabelLinkClickedEventArgs args)
        {
            System.Diagnostics.Process.Start("iexplore.exe", title.Name);
        }
    }

    class Win_ZHIHU_Response : Panel
    {
        private Panel basicInfo;
        private FlowLayoutPanel content;

        public Win_ZHIHU_Response(AnswerDetail detail)
        {
            Label userName = new Label();
            userName.AutoSize = true;
            userName.Dock = System.Windows.Forms.DockStyle.Top;
            userName.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            userName.Location = new System.Drawing.Point(0, 0);
            userName.Size = new System.Drawing.Size(85, 19);
            userName.TabIndex = 0;
            userName.Text = "作者："+detail.Responder;

            Label upNumber = new Label();
            upNumber.AutoSize = true;
            upNumber.Dock = System.Windows.Forms.DockStyle.Bottom;
            upNumber.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            upNumber.Location = new System.Drawing.Point(0, 19);
            upNumber.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            upNumber.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            upNumber.Size = new System.Drawing.Size(76, 25);
            upNumber.TabIndex = 2;
            upNumber.Text = "赞数：" + detail.UpNumber;

            this.basicInfo.AutoSize = true;
            this.basicInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.basicInfo.Controls.Add(userName);
            this.basicInfo.Controls.Add(upNumber);
            this.basicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.basicInfo.Location = new System.Drawing.Point(0, 0);
            this.basicInfo.Name = "panel11";
            this.basicInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.basicInfo.Size = new System.Drawing.Size(754, 56);
            this.basicInfo.TabIndex = 0;

            Label contentText = new Label();
            contentText.AutoSize = true;
            contentText.Dock = System.Windows.Forms.DockStyle.Fill;
            contentText.Location = new System.Drawing.Point(3, 0);
            contentText.Name = "label9";
            contentText.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            contentText.Size = new System.Drawing.Size(742, 85);
            contentText.TabIndex = 0;
            contentText.Text = detail.Content;

            this.content = new FlowLayoutPanel();
            this.content.Controls.Add(contentText);
            this.content.Dock = System.Windows.Forms.DockStyle.Top;
            this.content.Location = new System.Drawing.Point(0, 56);
            this.content.Size = contentText.Size;
            this.content.TabIndex = 1;

            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.basicInfo);
            this.Controls.Add(this.content);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Location = new System.Drawing.Point(0, 72);
            this.Size = new System.Drawing.Size(756, 115);
            this.TabIndex = 1;
        }
    }
}
