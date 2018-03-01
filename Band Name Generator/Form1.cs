using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Band_Name_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string BandName = textBox1.Text;    //從textBox1中取得字串
            string lower = BandName.ToLower();    //將字串中的所有字元轉換成小寫
            var split = lower.ToCharArray();    //切割字串中的字元成陣列

            if (split[0] != split[split.Length-1])    //若字首不等於字尾
            {
                label1.Text = "The " + BandName;   //於label1顯示
            }
            else
            {
                label1.Text = BandName.Substring(0, BandName.Length - 1) + lower.ToLower();    //先移除BandName字串最後一個字元，再加上一次BandName字串，顯示於label1
            }
        }
    }
}
