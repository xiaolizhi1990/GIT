using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        int count;
        int time;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void uiRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void uiPanel1_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel29_Click(object sender, EventArgs e)
        {

        }

        private void uiLineChart1_Click(object sender, EventArgs e)
        {

        }

        private void uiRichTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
        }

        private void uiTabControlMenu1_Click(object sender, EventArgs e)
        {
           
        }

        private void uiButton12_Click(object sender, EventArgs e)
        {
            this.Close();
            Form4 f = new Form4();
            f.Show();
      
         
        }

        private void uiButton9_Click(object sender, EventArgs e)
        {
            string str = "5 秒";
            time = Convert.ToInt16(str.Substring(0, 2));//将下拉菜单中的字符串内容转换成整形
            uiProcessBar1.Maximum = time;//进度条的最大值
            timer1.Start();//开始定时器
            ///MessageBox.Show("绘制曲线图中......", "提示");//提示对话框
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;//每到一定时间进入这个私有函数

            uiProcessBar1.Value = count;
            if (count == time)
            {
                timer1.Stop();
                System.Media.SystemSounds.Asterisk.Play();//提示音
                RealChart f = new RealChart();
                f.Show();
            }
        }

        private void uiButton11_Click(object sender, EventArgs e)
        {
            string str = "5 秒";
            time = Convert.ToInt16(str.Substring(0, 2));//将下拉菜单中的字符串内容转换成整形
            uiProcessBar2.Maximum = time;//进度条的最大值
            timer2.Start();//开始定时器
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            count++;//每到一定时间进入这个私有函数

            uiProcessBar2.Value = count;
            if (count == time)
            {
                timer2.Stop();
                System.Media.SystemSounds.Asterisk.Play();//提示音
                MessageBox.Show("数据复制成功！", "提示");
            }
        }

       
         
    }
}
