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
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(3, 3);
            this.Size = new System.Drawing.Size(760, 236);
            this.TabIndex = 3;
            this.MinimumSize = new System.Drawing.Size(760, 0);
            headPanel = new Win_ZHIHU_HeadPanel(answer.Title, answer.MultiLine, answer.Url);
            for(int i = answer.List.Count-1;i>=0;i--)
            {
                this.Controls.Add(new Win_ZHIHU_Response(answer.List[i]));
            }
            this.Controls.Add(headPanel);
        }

    }

    class Win_ZHIHU_HeadPanel : Panel
    {
        private LinkLabel title;
        private Label multiLine;

        public Win_ZHIHU_HeadPanel(String title,String multiLine, String url)
        {
            this.title = new LinkLabel
            {
                Text = title,
                AutoSize = true,
                Cursor = System.Windows.Forms.Cursors.Hand,
                Dock = System.Windows.Forms.DockStyle.Top,
                Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                LinkColor = System.Drawing.Color.Black,
                Location = new System.Drawing.Point(0, 0),
                Padding = new System.Windows.Forms.Padding(0, 5, 0, 0),
                Size = new System.Drawing.Size(156, 25),
                MaximumSize = new System.Drawing.Size(750, 0),
                TabIndex = 0,
                TabStop = true,
                Name = url
            };
            this.title.LinkClicked += OpenWeb;

            this.multiLine = new Label
            {
                Text = multiLine,
                AutoSize = true,
                Dock = System.Windows.Forms.DockStyle.Fill,
                Location = new System.Drawing.Point(0, 25),
                Margin = new System.Windows.Forms.Padding(0),
                Name = "label12",
                Padding = new System.Windows.Forms.Padding(0, 15, 0, 5),
                Size = new System.Drawing.Size(405, 35),
                MaximumSize = new System.Drawing.Size(750, 0),
                TabIndex = 1
            };

            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.Controls.Add(this.multiLine);
            this.Controls.Add(this.title);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Location = new System.Drawing.Point(0, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.Name = title;
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.Size = new System.Drawing.Size(760, 72);
            this.TabIndex = 0;
            
            
        }

        private void OpenWeb(object sendor, LinkLabelLinkClickedEventArgs args)
        {
            System.Diagnostics.Process.Start("iexplore.exe", title.Name);
        }

        public int GetHeight()
        {

            int height = this.Height;
            return height;
        }
    }

    class Win_ZHIHU_Response : Panel
    {
        private Panel basicInfo;
        private Panel content;

        public Win_ZHIHU_Response(AnswerDetail detail)
        {
            this.SuspendLayout();
            Label userName = new Label
            {
                AutoSize = true,
                Dock = System.Windows.Forms.DockStyle.Top,
                Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                Location = new System.Drawing.Point(0, 0),
                Size = new System.Drawing.Size(85, 19),
                TabIndex = 0,
                Text = "作者：" + detail.Responder
            };

            Label upNumber = new Label
            {
                AutoSize = true,
                Dock = System.Windows.Forms.DockStyle.Bottom,
                Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134))),
                Location = new System.Drawing.Point(0, 19),
                Margin = new System.Windows.Forms.Padding(3, 10, 3, 0),
                Padding = new System.Windows.Forms.Padding(0, 10, 0, 0),
                Size = new System.Drawing.Size(76, 25),
                TabIndex = 2,
                Text = "赞数：" + detail.UpNumber
            };

            this.basicInfo = new Panel
            {
                AutoSize = true,
                BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            };
            this.basicInfo.Controls.Add(userName);
            this.basicInfo.Controls.Add(upNumber);
            this.basicInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.basicInfo.Location = new System.Drawing.Point(0, 0);
            this.basicInfo.Name = "panel11";
            this.basicInfo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.basicInfo.Size = new System.Drawing.Size(754, 56);
            this.basicInfo.TabIndex = 0;

            Label contentText = new Label
            {
                AutoSize = true,
                Dock = System.Windows.Forms.DockStyle.Top,
                Location = new System.Drawing.Point(3, 0),
                Name = "label9",
                Padding = new System.Windows.Forms.Padding(5, 10, 0, 15),
                Size = new System.Drawing.Size(742, 85),
                MaximumSize = new System.Drawing.Size(742, 0),
                TabIndex = 0,
                Text = detail.Content
            };
            
            this.content = new Panel
            {
                AutoSize = true,
                Dock = System.Windows.Forms.DockStyle.Top,
                Location = new System.Drawing.Point(0, 56),
                Size = new System.Drawing.Size(760, 100),
                TabIndex = 1,
            };
            this.content.Controls.Add(contentText);

            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.content);
            this.Controls.Add(this.basicInfo);
            this.Dock = System.Windows.Forms.DockStyle.Top;
            this.Location = new System.Drawing.Point(0, 72);
            this.TabIndex = 1;
            this.ResumeLayout(true);
        }

        public int GetHeight()
        {
            return this.content.Height + this.basicInfo.Height;
        }
    }
}
