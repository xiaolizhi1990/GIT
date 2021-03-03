namespace WindowsFormsApplication2
{
    partial class LockAD2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LockAD2));
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiProcessBar2 = new Sunny.UI.UIProcessBar();
            this.uiComboBox2 = new Sunny.UI.UIComboBox();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick_1);
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiButton2.Location = new System.Drawing.Point(392, 99);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(100, 35);
            this.uiButton2.TabIndex = 6;
            this.uiButton2.Text = "开始倒计时";
            this.uiButton2.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // uiProcessBar2
            // 
            this.uiProcessBar2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiProcessBar2.Location = new System.Drawing.Point(102, 246);
            this.uiProcessBar2.MinimumSize = new System.Drawing.Size(70, 5);
            this.uiProcessBar2.Name = "uiProcessBar2";
            this.uiProcessBar2.Size = new System.Drawing.Size(390, 52);
            this.uiProcessBar2.TabIndex = 7;
            this.uiProcessBar2.Text = "0.0%";
            // 
            // uiComboBox2
            // 
            this.uiComboBox2.FillColor = System.Drawing.Color.White;
            this.uiComboBox2.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiComboBox2.Location = new System.Drawing.Point(200, 102);
            this.uiComboBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiComboBox2.MinimumSize = new System.Drawing.Size(63, 0);
            this.uiComboBox2.Name = "uiComboBox2";
            this.uiComboBox2.Padding = new System.Windows.Forms.Padding(0, 0, 30, 2);
            this.uiComboBox2.Size = new System.Drawing.Size(150, 29);
            this.uiComboBox2.TabIndex = 9;
            this.uiComboBox2.Text = "uiComboBox2";
            this.uiComboBox2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.uiLabel3.Location = new System.Drawing.Point(98, 105);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(100, 23);
            this.uiLabel3.TabIndex = 12;
            this.uiLabel3.Text = "定时时间：";
            this.uiLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LockAD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(581, 414);
            this.Controls.Add(this.uiLabel3);
            this.Controls.Add(this.uiComboBox2);
            this.Controls.Add(this.uiProcessBar2);
            this.Controls.Add(this.uiButton2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LockAD2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "锁定AD";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer2;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIProcessBar uiProcessBar2;
        private Sunny.UI.UIComboBox uiComboBox2;
        private Sunny.UI.UILabel uiLabel3;

    }
}