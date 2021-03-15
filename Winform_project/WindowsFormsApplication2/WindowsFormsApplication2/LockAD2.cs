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
    public partial class LockAD2 : Form
    {
        int count1;
        int time1;
        public LockAD2()
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
                uiComboBox2.Items.Add(j.ToString() + " 秒");

            }
            uiComboBox2.Text = "10 秒";//下拉框选择的初始化
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string str = uiComboBox2.Text;//获取下拉框中选择的字符串内容
            time1 = Convert.ToInt16(str.Substring(0, 2));//将下拉菜单中的字符串内容转换成整形
            uiProcessBar2.Maximum = time1;//进度条的最大值
            timer2.Start();//开始定时器
            MessageBox.Show("倒计时过程中请勿移动传感器！", "告警");//提示对话框
        }

        public double NextDouble1(Random ran, double minValue, double maxValue, int decimalPlace) //生成随机数
        {
            double randNum = ran.NextDouble() * (maxValue - minValue) + minValue;
            return Convert.ToDouble(randNum.ToString("f" + decimalPlace));
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            count1++;//每到一定时间进入这个私有函数

            uiProcessBar2.Value = count1;
            if (count1 == time1)
            {
                timer2.Stop();
                System.Media.SystemSounds.Asterisk.Play();//提示音
                MessageBox.Show("锁定完成！", "提示");//提示对话框
                Close();
                Random ran = new Random();  //定义一个随机变量存储随机数
                Double randNum = NextDouble1(ran, 1.00, 4.00, 2);// 保留两位小数
                //int randNum = ran.Next(4,20);
                string randNUM = randNum.ToString();
                Settings.pCurrentWin.uiTextBox7.Text = randNUM;//随机数赋值到文本框中
            }
        }  
    }
}
