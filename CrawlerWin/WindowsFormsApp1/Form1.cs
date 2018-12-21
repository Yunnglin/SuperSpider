using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        CheckBox[] info = new CheckBox[3];
        public Form1()
        {
            InitializeComponent();
            info[0] = sinaCheckBox;
            info[1] = hupuCheckBox;
            info[2] = zhihuCheckBox;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string keyWord = searchTextBox.Text;
            if (keyWord == "")
            {
                MessageBox.Show("请输入关键字！");
                return;
            }
            if (!sinaCheckBox.Checked & !hupuCheckBox.Checked & !zhihuCheckBox.Checked)
            {
                MessageBox.Show("请选择信息来源！");
                return;
            }
            //定义一个string类型的数组来存储用户选择的信息来源，没有选择就是空字符串。
            string[] infoFrom = { "", "", "" };
            int i = 0;
            foreach (CheckBox info in info)
            {
                if (info.Checked)
                {
                    infoFrom[i] = info.Text;
                }
                i++;
            }


            Form2 form2 = new Form2();
            form2.Show();
        }


        private void sinaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void hupuCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void zhihuCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hotButton_Click(object sender, EventArgs e)
        {
            if (!sinaCheckBox.Checked & !hupuCheckBox.Checked & !zhihuCheckBox.Checked)
            {
                MessageBox.Show("请选择信息来源！");
                return;
            }
            //定义一个string类型的数组来存储用户选择的信息来源，没有选择就是空字符串。
            string[] infoFrom = { "", "", "" };
            int i = 0;
            foreach (CheckBox info in info)
            {
                if (info.Checked)
                {
                    infoFrom[i] = info.Text;
                }
                i++;
            }

            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
