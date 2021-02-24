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
    public partial class Form2 : Form
    {
        IniFiles ini = new IniFiles(Application.StartupPath + @"\MyConfig.INI");
        public Form2()
        {
            InitializeComponent();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            String str1 = uiTextBox6.Text;//获取文本框中内容
            String str2 = uiTextBox8.Text;
           
            //String str3 = uiTextBox2.Text;
            //String str4 = uiTextBox1.Text;
            //String str5 = uiTextBox4.Text;
            //String str6 = uiTextBox3.Text;
            //String str7 = uiTextBox7.Text;
            //String str8 = uiTextBox5.Text;
            //String str9 = uiTextBox16.Text;
            //String str10 = uiTextBox15.Text;
            //String str11 = uiTextBox14.Text;
            //String str12 = uiTextBox13.Text;
            //String str13 = uiTextBox12.Text;
            //String str14 = uiTextBox11.Text;
            //String str15 = uiTextBox10.Text;
            //String str16 = uiTextBox9.Text;

            ini.IniWriteValue("1#泥浆罐", "A", str1);
            ini.IniWriteValue("1#泥浆罐", "B", str2);

            MessageBox.Show("罐1系数保存成功！", "提示");
            //ini.IniWriteValue("1#泥浆罐", "A", str3);
            //ini.IniWriteValue("1#泥浆罐", "B", str4);
            //ini.IniWriteValue("1#泥浆罐", "A", str5);
            //ini.IniWriteValue("1#泥浆罐", "B", str6);
            //ini.IniWriteValue("1#泥浆罐", "A", str7);
            //ini.IniWriteValue("1#泥浆罐", "B", str8);
            //ini.IniWriteValue("1#泥浆罐", "A", str9);
            //ini.IniWriteValue("1#泥浆罐", "B", str10);
            //ini.IniWriteValue("1#泥浆罐", "A", str11);
            //ini.IniWriteValue("1#泥浆罐", "B", str12);
            //ini.IniWriteValue("1#泥浆罐", "A", str13);
            //ini.IniWriteValue("1#泥浆罐", "B", str14);
            //ini.IniWriteValue("1#泥浆罐", "A", str15);
            //ini.IniWriteValue("1#泥浆罐", "B", str16);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            if (ini.ExistINIFile())
            {
                uiTextBox6.Text = ini.IniReadValue("1#泥浆罐", "A");
                uiTextBox8.Text = ini.IniReadValue("1#泥浆罐", "B");
                uiTextBox2.Text = ini.IniReadValue("2#泥浆罐", "A");
                uiTextBox1.Text = ini.IniReadValue("2#泥浆罐", "B");
                //uiTextBox4.Text = ini.IniReadValue("3#泥浆罐", "A");
                //uiTextBox3.Text = ini.IniReadValue("3#泥浆罐", "B");
                //uiTextBox7.Text = ini.IniReadValue("4#泥浆罐", "A");
                //uiTextBox5.Text = ini.IniReadValue("4#泥浆罐", "B");
                //uiTextBox16.Text = ini.IniReadValue("5#泥浆罐", "A");
                //uiTextBox15.Text = ini.IniReadValue("5#泥浆罐", "B");
                //uiTextBox14.Text = ini.IniReadValue("6#泥浆罐", "A");
                //uiTextBox13.Text = ini.IniReadValue("6#泥浆罐", "B");
                //uiTextBox12.Text = ini.IniReadValue("7#泥浆罐", "A");
                //uiTextBox11.Text = ini.IniReadValue("7#泥浆罐", "B");
                //uiTextBox10.Text = ini.IniReadValue("8#泥浆罐", "A");
                //uiTextBox9.Text = ini.IniReadValue("8#泥浆罐", "B");
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            String str3 = uiTextBox2.Text;
            String str4 = uiTextBox1.Text;
            ini.IniWriteValue("2#泥浆罐", "A", str3);
            ini.IniWriteValue("2#泥浆罐", "B", str4);
            MessageBox.Show("罐1系数保存成功！", "提示");
        }

    }
}
