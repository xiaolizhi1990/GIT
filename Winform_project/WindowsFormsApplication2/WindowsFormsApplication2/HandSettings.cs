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
    public partial class HandSettings : Form
    {
        IniFiles ini = new IniFiles(Application.StartupPath + @"\MyConfig.INI");
        public HandSettings()
        {
            InitializeComponent();
        }
        // 添加一个公共属性 StringValue
        public string StringValue1A
        {
            get { return TextBox1A.Text; }
            set { TextBox1A.Text = value; }
        }
        public string StringValue1B
        {
            get { return TextBox1B.Text; }
            set { TextBox1B.Text = value; }
        }
        

        private void Form2_Load(object sender, EventArgs e)
        {
            //如果文件存在，读取文本中的值
            if (ini.ExistINIFile())
            {
                TextBox1A.Text = ini.IniReadValue("1#泥浆罐", "A");
                TextBox1B.Text = ini.IniReadValue("1#泥浆罐", "B");
                TextBox2A.Text = ini.IniReadValue("2#泥浆罐", "A");
                TextBox2B.Text = ini.IniReadValue("2#泥浆罐", "B");
                TextBox3A.Text = ini.IniReadValue("3#泥浆罐", "A");
                TextBox3B.Text = ini.IniReadValue("3#泥浆罐", "B");
                TextBox4A.Text = ini.IniReadValue("4#泥浆罐", "A");
                TextBox4B.Text = ini.IniReadValue("4#泥浆罐", "B");
                TextBox5A.Text = ini.IniReadValue("5#泥浆罐", "A");
                TextBox5B.Text = ini.IniReadValue("5#泥浆罐", "B");
                TextBox6A.Text = ini.IniReadValue("6#泥浆罐", "A");
                TextBox6B.Text = ini.IniReadValue("6#泥浆罐", "B");
                TextBox7A.Text = ini.IniReadValue("7#泥浆罐", "A");
                TextBox7B.Text = ini.IniReadValue("7#泥浆罐", "B");
                TextBox8A.Text = ini.IniReadValue("8#泥浆罐", "A");
                TextBox8B.Text = ini.IniReadValue("8#泥浆罐", "B");
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            String str3 = TextBox2A.Text;
            String str4 = TextBox2B.Text;
            ini.IniWriteValue("2#泥浆罐", "A", str3);
            ini.IniWriteValue("2#泥浆罐", "B", str4);
            MessageBox.Show("罐2系数保存成功！", "提示");
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            String str1 = TextBox1A.Text;//获取文本框中内容
            String str2 = TextBox1B.Text;
            ini.IniWriteValue("1#泥浆罐", "A", str1);
            ini.IniWriteValue("1#泥浆罐", "B", str2);
            MessageBox.Show("罐1系数保存成功！", "提示");
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            String str5 = TextBox3A.Text;//获取文本框中内容
            String str6 = TextBox3B.Text;
            ini.IniWriteValue("3#泥浆罐", "A", str5);
            ini.IniWriteValue("3#泥浆罐", "B", str6);
            MessageBox.Show("罐3系数保存成功！", "提示");
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            String str7 = TextBox4A.Text;//获取文本框中内容
            String str8 = TextBox4B.Text;
            ini.IniWriteValue("4#泥浆罐", "A", str7);
            ini.IniWriteValue("4#泥浆罐", "B", str8);
            MessageBox.Show("罐4系数保存成功！", "提示");
        }

        private void uiButton8_Click(object sender, EventArgs e)
        {
            String str9 = TextBox5A.Text;//获取文本框中内容
            String str10 = TextBox5B.Text;
            ini.IniWriteValue("5#泥浆罐", "A", str9);
            ini.IniWriteValue("5#泥浆罐", "B", str10);
            MessageBox.Show("罐5系数保存成功！", "提示");
        }

        private void uiButton7_Click(object sender, EventArgs e)
        {
            String str11 = TextBox6A.Text;//获取文本框中内容
            String str12 = TextBox6B.Text;
            ini.IniWriteValue("6#泥浆罐", "A", str11);
            ini.IniWriteValue("6#泥浆罐", "B", str12);
            MessageBox.Show("罐6系数保存成功！", "提示");
        }

        private void uiButton6_Click(object sender, EventArgs e)
        {
            String str13 = TextBox7A.Text;//获取文本框中内容
            String str14 = TextBox7B.Text;
            ini.IniWriteValue("7#泥浆罐", "A", str13);
            ini.IniWriteValue("7#泥浆罐", "B", str14);
            MessageBox.Show("罐7系数保存成功！", "提示");
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            String str15 = TextBox8A.Text;//获取文本框中内容
            String str16 = TextBox8B.Text;
            ini.IniWriteValue("8#泥浆罐", "A", str15);
            ini.IniWriteValue("8#泥浆罐", "B", str16);
            MessageBox.Show("罐8系数保存成功！", "提示");
        }

    }
}
