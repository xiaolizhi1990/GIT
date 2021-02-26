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
    public partial class Settings : Form
    {
        int count;
        int time;
        
        IniFiles ini = new IniFiles(Application.StartupPath + @"\MyConfig.INI");//声明配置文件路径

        public Settings()
        {
            InitializeComponent();
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (ini.ExistINIFile())               //读取ini配置文件，并在窗体加载时显示数据
            {               
                uiTextBox2.Text = ini.IniReadValue("井名", "ProjectName");
                uiComboTreeView5.Text = ini.IniReadValue("存储间隔", "TIME");
                uiTextBox3.Text = ini.IniReadValue("1#泥浆罐", "ALARM_H");
                uiTextBox4.Text = ini.IniReadValue("1#泥浆罐", "ALARM_L");

            }
        }

        private void uiRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            HandSettings f = new HandSettings();
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
            LockAD f = new LockAD();
            f.Show();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            LockAD f = new LockAD();
            f.Show();
        }

        private void uiTabControlMenu1_Click(object sender, EventArgs e)
        {
           
        }

        private void uiButton12_Click(object sender, EventArgs e)
        {
            this.Close();
            Main f = new Main();
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

        private void uiButton6_Click(object sender, EventArgs e)
        {
            String str = uiTextBox2.Text;
            String str1 = uiComboTreeView5.Text;
            ini.IniWriteValue("井名", "ProjectName", str);
            ini.IniWriteValue("存储间隔", "TIME", str1);
            MessageBox.Show("保存成功！", "提示");
        }

        private void uiButton7_Click(object sender, EventArgs e)
        {
            if (uiComboTreeView6.Enabled == true)    //下拉框已启用
            {
                int Num;
                String str = uiComboTreeView6.Text;
                Num = Convert.ToInt32(str);
                String str1 = uiTextBox3.Text;       //获取输入的最大值
                String str2 = uiTextBox4.Text;       //获取输入的最小值
                switch (Num)                        //循环写入数据
                {
                    case 1: ini.IniWriteValue("1#泥浆罐", "ALARM_H", str1); ini.IniWriteValue("1#泥浆罐", "ALARM_L", str2); MessageBox.Show("1#泥浆罐设置成功！", "提示"); break;
                    case 2: ini.IniWriteValue("2#泥浆罐", "ALARM_H", str1); ini.IniWriteValue("2#泥浆罐", "ALARM_L", str2); MessageBox.Show("2#泥浆罐设置成功！", "提示"); break;
                    case 3: ini.IniWriteValue("3#泥浆罐", "ALARM_H", str1); ini.IniWriteValue("3#泥浆罐", "ALARM_L", str2); MessageBox.Show("3#泥浆罐设置成功！", "提示"); break;
                    case 4: ini.IniWriteValue("4#泥浆罐", "ALARM_H", str1); ini.IniWriteValue("4#泥浆罐", "ALARM_L", str2); MessageBox.Show("4#泥浆罐设置成功！", "提示"); break;
                    case 5: ini.IniWriteValue("5#泥浆罐", "ALARM_H", str1); ini.IniWriteValue("5#泥浆罐", "ALARM_L", str2); MessageBox.Show("5#泥浆罐设置成功！", "提示"); break;
                    case 6: ini.IniWriteValue("6#泥浆罐", "ALARM_H", str1); ini.IniWriteValue("6#泥浆罐", "ALARM_L", str2); MessageBox.Show("6#泥浆罐设置成功！", "提示"); break;
                    case 7: ini.IniWriteValue("7#泥浆罐", "ALARM_H", str1); ini.IniWriteValue("7#泥浆罐", "ALARM_L", str2); MessageBox.Show("7#泥浆罐设置成功！", "提示"); break;
                    case 8: ini.IniWriteValue("8#泥浆罐", "ALARM_H", str1); ini.IniWriteValue("8#泥浆罐", "ALARM_L", str2); MessageBox.Show("8#泥浆罐设置成功！", "提示"); break;

                }
            }
            else if (uiComboTreeView6.Enabled == false) //下拉框不可用时，统一修改数据
            {
                int i;
                for (i = 1; i < 9; i++) 
                {
                    String str1 = uiTextBox3.Text;       //获取输入的最大值
                    String str2 = uiTextBox4.Text;       //获取输入的最小值
                    ini.IniWriteValue(i+"#泥浆罐", "ALARM_H", str1); 
                    ini.IniWriteValue(i+"#泥浆罐", "ALARM_L", str2); 
                }
                MessageBox.Show("全部泥浆罐设置成功！", "提示");
            }

        }

        private void uiComboTreeView6_NodeSelected(object sender, TreeNode node)    //下拉框的对应显示数值
        {
            if (uiComboTreeView6.Enabled == true)
            {
                int Num;
                String str = uiComboTreeView6.Text;
                Num = Convert.ToInt32(str);
                switch (Num)
                {
                    case 1: uiTextBox3.Text = ini.IniReadValue("1#泥浆罐", "ALARM_H"); uiTextBox4.Text = ini.IniReadValue("1#泥浆罐", "ALARM_L"); break;
                    case 2: uiTextBox3.Text = ini.IniReadValue("2#泥浆罐", "ALARM_H"); uiTextBox4.Text = ini.IniReadValue("2#泥浆罐", "ALARM_L"); break;
                    case 3: uiTextBox3.Text = ini.IniReadValue("3#泥浆罐", "ALARM_H"); uiTextBox4.Text = ini.IniReadValue("3#泥浆罐", "ALARM_L"); break;
                    case 4: uiTextBox3.Text = ini.IniReadValue("4#泥浆罐", "ALARM_H"); uiTextBox4.Text = ini.IniReadValue("4#泥浆罐", "ALARM_L"); break;
                    case 5: uiTextBox3.Text = ini.IniReadValue("5#泥浆罐", "ALARM_H"); uiTextBox4.Text = ini.IniReadValue("5#泥浆罐", "ALARM_L"); break;
                    case 6: uiTextBox3.Text = ini.IniReadValue("6#泥浆罐", "ALARM_H"); uiTextBox4.Text = ini.IniReadValue("6#泥浆罐", "ALARM_L"); break;
                    case 7: uiTextBox3.Text = ini.IniReadValue("7#泥浆罐", "ALARM_H"); uiTextBox4.Text = ini.IniReadValue("7#泥浆罐", "ALARM_L"); break;
                    case 8: uiTextBox3.Text = ini.IniReadValue("8#泥浆罐", "ALARM_H"); uiTextBox4.Text = ini.IniReadValue("8#泥浆罐", "ALARM_L"); break;
                }
            }
           
        }

        private void uiSwitch3_ValueChanged(object sender, bool value)      //开关按钮开启改变下拉选择框为不可选中
        {
            if (uiSwitch3.Active == true) 
            {
                uiComboTreeView6.Enabled = false;
            }
            else
                uiComboTreeView6.Enabled = true;
        }
         
    }
}
