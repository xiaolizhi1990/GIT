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
    public partial class Main : Form
    {
        IniFiles ini = new IniFiles(Application.StartupPath + @"\MyConfig.INI");//声明配置文件路径
        public Main()
        {
            InitializeComponent();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Settings f = new Settings();
            f.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            uiLabel35.Text = dt.ToString();
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
                        
            //加载时读取ini文件数据
            if (ini.IniReadValue("1#泥浆罐", "State") == "1")
            {
                uiLight1.State = Sunny.UI.UILightState.On;
                uiSwitch1.Active = true;
                uiLabel6.Text = ini.IniReadValue("1#泥浆罐", "H");
                uiLabel5.Text = ini.IniReadValue("1#泥浆罐", "V");
                String str0 = uiLabel6.Text;
                Double str00 = Convert.ToDouble(str0);
                String str1 = ini.IniReadValue("1#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar1.Value = PP;
                String ALARM_H = ini.IniReadValue("1#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("1#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight5.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar1.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                uiLight1.State = Sunny.UI.UILightState.Off;
                uiSwitch1.Active = false;
            }

            if (ini.IniReadValue("2#泥浆罐", "State") == "1")
            {
                uiLight2.State = Sunny.UI.UILightState.On;
                uiSwitch2.Active = true;
                uiLabel7.Text = ini.IniReadValue("2#泥浆罐", "H");
                uiLabel8.Text = ini.IniReadValue("2#泥浆罐", "V");
                String str0 = uiLabel7.Text;
                Double str00 = Convert.ToDouble(str0);
                String str1 = ini.IniReadValue("2#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar2.Value = PP;
                String ALARM_H = ini.IniReadValue("2#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("2#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight2.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar2.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                uiLight2.State = Sunny.UI.UILightState.Off;
                uiSwitch2.Active = false;
            }

            if (ini.IniReadValue("3#泥浆罐", "State") == "1")
            {
                uiLight3.State = Sunny.UI.UILightState.On;
                uiSwitch3.Active = true;
                uiLabel11.Text = ini.IniReadValue("3#泥浆罐", "H");
                uiLabel12.Text = ini.IniReadValue("3#泥浆罐", "V");
                String str0 = uiLabel11.Text;
                Double str00 = Convert.ToDouble(str0);
                String str1 = ini.IniReadValue("3#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar3.Value = PP;
                String ALARM_H = ini.IniReadValue("3#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("3#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight3.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar3.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                uiLight3.State = Sunny.UI.UILightState.Off;
                uiSwitch3.Active = false;
            }

            if (ini.IniReadValue("4#泥浆罐", "State") == "1")
            {
                uiLight4.State = Sunny.UI.UILightState.On;
                uiSwitch4.Active = true;
                uiLabel15.Text = ini.IniReadValue("4#泥浆罐", "H");
                uiLabel16.Text = ini.IniReadValue("4#泥浆罐", "V");
                String str0 = uiLabel15.Text;
                Double str00 = Convert.ToDouble(str0);
                String str1 = ini.IniReadValue("4#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar4.Value = PP;
                String ALARM_H = ini.IniReadValue("4#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("4#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight4.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar4.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                uiLight4.State = Sunny.UI.UILightState.Off;
                uiSwitch4.Active = false;
            }

            if (ini.IniReadValue("5#泥浆罐", "State") == "1")
            {
                uiLight5.State = Sunny.UI.UILightState.On;
                uiSwitch5.Active = true;
                uiLabel19.Text = ini.IniReadValue("5#泥浆罐", "H");
                uiLabel20.Text = ini.IniReadValue("5#泥浆罐", "V");
                String str0 = uiLabel19.Text;
                Double str00 = Convert.ToDouble(str0);
                //五号罐的进度条，显示的是令X=0，y=kx+B，得到的Y值也就是高度值，再和实际高度的百分比。
                String str1 = ini.IniReadValue("5#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs( Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar5.Value = PP;
                String ALARM_H = ini.IniReadValue("5#泥浆罐","ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("5#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))   //根据设置的阈值判断是否变色
                {
                    uiLight5.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar5.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                uiLight5.State = Sunny.UI.UILightState.Off;
                uiSwitch5.Active = false;
            }

            if (ini.IniReadValue("6#泥浆罐", "State") == "1")
            {
                uiLight6.State = Sunny.UI.UILightState.On;
                uiSwitch6.Active = true;
                uiLabel23.Text = ini.IniReadValue("6#泥浆罐", "H");
                uiLabel24.Text = ini.IniReadValue("6#泥浆罐", "V");
                String str0 = uiLabel23.Text;
                Double str00 = Convert.ToDouble(str0);
                String str1 = ini.IniReadValue("6#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar6.Value = PP;
                String ALARM_H = ini.IniReadValue("6#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("6#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight6.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar6.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                uiLight6.State = Sunny.UI.UILightState.Off;
                uiSwitch6.Active = false;
            }

            if (ini.IniReadValue("7#泥浆罐", "State") == "1")
            {
                uiLight7.State = Sunny.UI.UILightState.On;
                uiSwitch7.Active = true;
                uiLabel27.Text = ini.IniReadValue("7#泥浆罐", "H");
                uiLabel28.Text = ini.IniReadValue("7#泥浆罐", "V");
                String str0 = uiLabel27.Text;
                Double str00 = Convert.ToDouble(str0);
                String str1 = ini.IniReadValue("7#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar7.Value = PP;
                String ALARM_H = ini.IniReadValue("7#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("7#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight7.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar7.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                uiLight7.State = Sunny.UI.UILightState.Off;
                uiSwitch7.Active = false;
            }

            if (ini.IniReadValue("8#泥浆罐", "State") == "1")
            {
                uiLight8.State = Sunny.UI.UILightState.On;
                uiSwitch8.Active = true;
                uiLabel31.Text = ini.IniReadValue("8#泥浆罐", "H");
                uiLabel32.Text = ini.IniReadValue("8#泥浆罐", "V");
                String str0 = uiLabel31.Text;
                Double str00 = Convert.ToDouble(str0);
                String str1 = ini.IniReadValue("8#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar8.Value = PP;
                String ALARM_H = ini.IniReadValue("8#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("8#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight8.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar8.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                uiLight8.State = Sunny.UI.UILightState.Off;
                uiSwitch8.Active = false;
            }
            //首页的循环罐和计量罐体积显示
            Double V = 0, VV = 0;
            for (int i = 1; i < 9; i++) 
            {
                if (ini.IniReadValue(i + "#泥浆罐", "G_Type") == "0")
                {
                    V += Convert.ToDouble(ini.IniReadValue(i + "#泥浆罐", "V"));
                }
                else 
                {
                    VV += Convert.ToDouble(ini.IniReadValue(i + "#泥浆罐", "V"));
                }
            }
            uiTextBox8.Text = Convert.ToString(V);
            uiTextBox1.Text = Convert.ToString(VV);
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
          
            if (this.uiButton2.Text == "关闭警报")
            {
                this.uiButton2.Text = "打开警报";
                this.uiButton2.FillColor = Color.Gray;
            }
            else
            {
                this.uiButton2.Text = "关闭警报";
                this.uiButton2.FillColor = Color.DodgerBlue;
            }

        }

        private void uiSwitch1_ValueChanged(object sender, bool value)        //每个开关单独控制，打开加载数据，关闭清空数据。
        {
            if (uiSwitch1.Active == true)
            {
                uiLight1.State = Sunny.UI.UILightState.On;
                ini.IniWriteValue("1#泥浆罐", "State", "1");
                uiLabel6.Text = ini.IniReadValue("1#泥浆罐", "H");
                uiLabel5.Text = ini.IniReadValue("1#泥浆罐", "V");
                String str0 = uiLabel6.Text;
                Double str00 = Convert.ToDouble(str0);
                String str1 = ini.IniReadValue("1#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar1.Value = PP;
                String ALARM_H = ini.IniReadValue("1#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("1#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight5.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar1.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                uiLight1.State = Sunny.UI.UILightState.Off;
                ini.IniWriteValue("1#泥浆罐", "State", "0");
                uiLabel6.Text = "0.00";
                uiLabel5.Text = "0.00";
                uiProcessBar1.Value = 0;
                uiProcessBar1.RectColor = uiProcessBar1.ForeColor;
            }
        }

        private void uiSwitch2_ValueChanged(object sender, bool value)
        {
            if (uiSwitch2.Active == true)
            {
                uiLight2.State = Sunny.UI.UILightState.On;
                ini.IniWriteValue("2#泥浆罐", "State", "1");
                uiLabel7.Text = ini.IniReadValue("2#泥浆罐", "H");
                uiLabel8.Text = ini.IniReadValue("2#泥浆罐", "V");
                String str0 = uiLabel7.Text;
                Double str00 = Convert.ToDouble(str0);
                String str1 = ini.IniReadValue("2#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar2.Value = PP;
                String ALARM_H = ini.IniReadValue("2#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("2#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight2.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar2.RectColor = System.Drawing.Color.Red;
                }

            }
            else
            {
                uiLight2.State = Sunny.UI.UILightState.Off;
                ini.IniWriteValue("2#泥浆罐", "State", "0");
                uiLabel7.Text = "0.00";
                uiLabel8.Text = "0.00";
                uiProcessBar2.Value = 0;
                uiProcessBar2.RectColor = uiProcessBar2.ForeColor;
            }
        }

        private void uiSwitch3_ValueChanged(object sender, bool value)
        {
            if (uiSwitch3.Active == true)
            {
                uiLight3.State = Sunny.UI.UILightState.On;
                ini.IniWriteValue("3#泥浆罐", "State", "1");
                uiLabel11.Text = ini.IniReadValue("3#泥浆罐", "H");
                uiLabel12.Text = ini.IniReadValue("3#泥浆罐", "V");
                String str0 = uiLabel11.Text;
                Double str00 = Convert.ToDouble(str0);
                String str1 = ini.IniReadValue("3#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar3.Value = PP;
                String ALARM_H = ini.IniReadValue("3#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("3#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight3.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar3.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                uiLight3.State = Sunny.UI.UILightState.Off;
                ini.IniWriteValue("3#泥浆罐", "State", "0");
                uiLabel11.Text = "0.00";
                uiLabel12.Text = "0.00";
                uiProcessBar3.Value = 0;
                uiProcessBar3.RectColor = uiProcessBar3.ForeColor;
            }
        }

        private void uiSwitch4_ValueChanged(object sender, bool value)
        {
            if (uiSwitch4.Active == true)
            {
                uiLight4.State = Sunny.UI.UILightState.On;
                ini.IniWriteValue("4#泥浆罐", "State", "1");
                uiLabel15.Text = ini.IniReadValue("4#泥浆罐", "H");
                uiLabel16.Text = ini.IniReadValue("4#泥浆罐", "V");
                String str0 = uiLabel15.Text;
                Double str00 = Convert.ToDouble(str0);
                String str1 = ini.IniReadValue("4#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar4.Value = PP;
                String ALARM_H = ini.IniReadValue("4#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("4#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight4.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar4.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                uiLight4.State = Sunny.UI.UILightState.Off;
                ini.IniWriteValue("4#泥浆罐", "State", "0");
                uiLabel15.Text = "0.00";
                uiLabel16.Text = "0.00";
                uiProcessBar4.Value = 0;
                uiProcessBar4.RectColor = uiProcessBar4.ForeColor;
            }
        }

        private void uiSwitch5_ValueChanged(object sender, bool value)
        {
            if (uiSwitch5.Active == true)
            {
                uiLight5.State = Sunny.UI.UILightState.On;
                ini.IniWriteValue("5#泥浆罐", "State", "1");
                uiLabel19.Text = ini.IniReadValue("5#泥浆罐", "H");
                uiLabel20.Text = ini.IniReadValue("5#泥浆罐", "V");
                String str0 = uiLabel19.Text;
                Double str00 = Convert.ToDouble(str0);
                //五号罐的进度条，显示的是令X=0，y=kx+B，得到的Y值也就是高度值，再和实际高度的百分比。
                String str1 = ini.IniReadValue("5#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar5.Value = PP;
                String ALARM_H = ini.IniReadValue("5#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("5#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight5.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar5.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {    
                uiLight5.State = Sunny.UI.UILightState.Off;
                ini.IniWriteValue("5#泥浆罐", "State", "0");
                uiLabel19.Text = "0.00";
                uiLabel20.Text = "0.00";
                uiProcessBar5.Value = 0;
                uiProcessBar5.RectColor = uiProcessBar5.ForeColor;
            }
        }

        private void uiSwitch6_ValueChanged(object sender, bool value)
        {
            if (uiSwitch6.Active == true)
            {
                uiLight6.State = Sunny.UI.UILightState.On;
                ini.IniWriteValue("6#泥浆罐", "State", "1");
                uiLabel23.Text = ini.IniReadValue("6#泥浆罐", "H");
                uiLabel24.Text = ini.IniReadValue("6#泥浆罐", "V");
                String str0 = uiLabel23.Text;
                Double str00 = Convert.ToDouble(str0);
                String str1 = ini.IniReadValue("6#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar6.Value = PP;
                String ALARM_H = ini.IniReadValue("6#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("6#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight6.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar6.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                uiLight6.State = Sunny.UI.UILightState.Off;
                ini.IniWriteValue("6#泥浆罐", "State", "0");
                uiLabel23.Text = "0.00";
                uiLabel24.Text = "0.00";
                uiProcessBar6.Value = 0;
                uiProcessBar6.RectColor = uiProcessBar6.ForeColor;
            }
        }

        private void uiSwitch7_ValueChanged(object sender, bool value)
        {
            if (uiSwitch7.Active == true)
            {
                uiLight7.State = Sunny.UI.UILightState.On;
                ini.IniWriteValue("7#泥浆罐", "State", "1");
                uiLabel27.Text = ini.IniReadValue("7#泥浆罐", "H");
                uiLabel28.Text = ini.IniReadValue("7#泥浆罐", "V");
                String str0 = uiLabel27.Text;
                Double str00 = Convert.ToDouble(str0);
                String str1 = ini.IniReadValue("7#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar7.Value = PP;
                String ALARM_H = ini.IniReadValue("7#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("7#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight7.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar7.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                uiLight7.State = Sunny.UI.UILightState.Off;
                ini.IniWriteValue("7#泥浆罐", "State", "0");
                uiLabel27.Text = "0.00";
                uiLabel28.Text = "0.00";
                uiProcessBar7.Value = 0;
                uiProcessBar7.RectColor = uiProcessBar7.ForeColor;
            }
        }

        private void uiSwitch8_ValueChanged(object sender, bool value)
        {
            if (uiSwitch8.Active == true)
            {
                uiLight8.State = Sunny.UI.UILightState.On;
                ini.IniWriteValue("8#泥浆罐", "State", "1");
                uiLabel31.Text = ini.IniReadValue("8#泥浆罐", "H");
                uiLabel32.Text = ini.IniReadValue("8#泥浆罐", "V");
                String str0 = uiLabel31.Text;
                Double str00 = Convert.ToDouble(str0);
                String str1 = ini.IniReadValue("8#泥浆罐", "B");   //AD2
                Double str11 = System.Math.Abs(Convert.ToDouble(str1));
                Double Percent = (str11 / str00) * 100;
                Double P = Math.Round(Percent);
                int PP = Convert.ToInt32(P);
                uiProcessBar8.Value = PP;
                String ALARM_H = ini.IniReadValue("8#泥浆罐", "ALARM_H");
                Double ALARM_HH = Convert.ToDouble(ALARM_H);
                String ALARM_L = ini.IniReadValue("8#泥浆罐", "ALARM_L");
                Double ALARM_LL = Convert.ToDouble(ALARM_L);
                Double H = Math.Round((ALARM_HH / str00) * 100);
                Double L = Math.Round((ALARM_LL / str00) * 100);

                if (PP >= Convert.ToInt32(H) || PP <= Convert.ToInt32(L))
                {
                    uiLight8.State = Sunny.UI.UILightState.Blink;
                    uiProcessBar8.RectColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                uiLight8.State = Sunny.UI.UILightState.Off;
                ini.IniWriteValue("8#泥浆罐", "State", "0");
                uiLabel31.Text = "0.00";
                uiLabel32.Text = "0.00";
                uiProcessBar8.Value = 0;
                uiProcessBar8.RectColor = uiProcessBar8.ForeColor;
            }
        }

    }
}
