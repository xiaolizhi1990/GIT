﻿using System;
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

        private void uiProcessBar1_ValueChanged(object sender, int value)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            uiLabel35.Text = dt.ToString();
        }

        private void Form4_Load_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
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


    }
}