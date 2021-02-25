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
    public partial class LockAD : Form
    {
        int count;
        int time;
        public LockAD()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            int i;
            int j;
            for (i = 1; i < 11; i++)
            {
                j = i * 10;
                uiComboBox1.Items.Add(j.ToString() + " 秒");

            }
            uiComboBox1.Text = "10 秒";//下拉框选择的初始化
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string str = uiComboBox1.Text;//获取下拉框中选择的字符串内容
            time = Convert.ToInt16(str.Substring(0, 2));//将下拉菜单中的字符串内容转换成整形
            uiProcessBar1.Maximum = time;//进度条的最大值
            timer1.Start();//开始定时器
            MessageBox.Show("倒计时过程中请勿移动传感器！", "告警");//提示对话框
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {
            count++;//每到一定时间进入这个私有函数

            uiProcessBar1.Value = count;
            if (count == time)
            {
                timer1.Stop();
                System.Media.SystemSounds.Asterisk.Play();//提示音
                MessageBox.Show("锁定完成！", "提示");//提示对话框
            }
        }

       

       

    }
}
