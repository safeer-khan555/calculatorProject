namespace GuiCalculator
{
    partial class ConversionCal
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
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton5 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.CustomBackground = false;
            this.textBox1.CustomForeColor = false;
            this.textBox1.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.textBox1.FontWeight = MetroFramework.MetroTextBoxWeight.Regular;
            this.textBox1.Location = new System.Drawing.Point(140, 78);
            this.textBox1.Multiline = false;
            this.textBox1.Name = "textBox1";
            this.textBox1.SelectedText = "";
            this.textBox1.Size = new System.Drawing.Size(217, 23);
            this.textBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.StyleManager = null;
            this.textBox1.TabIndex = 0;
            this.textBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.UseStyleColors = false;
            // 
            // metroButton1
            // 
            this.metroButton1.Highlight = false;
            this.metroButton1.Location = new System.Drawing.Point(140, 121);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(55, 38);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton1.StyleManager = null;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Bin";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Highlight = false;
            this.metroButton2.Location = new System.Drawing.Point(223, 122);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(55, 38);
            this.metroButton2.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton2.StyleManager = null;
            this.metroButton2.TabIndex = 1;
            this.metroButton2.Text = "Dec";
            this.metroButton2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.Highlight = false;
            this.metroButton4.Location = new System.Drawing.Point(302, 122);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(55, 38);
            this.metroButton4.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton4.StyleManager = null;
            this.metroButton4.TabIndex = 1;
            this.metroButton4.Text = "Hexa";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton4.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton5
            // 
            this.metroButton5.Highlight = false;
            this.metroButton5.Location = new System.Drawing.Point(140, 166);
            this.metroButton5.Name = "metroButton5";
            this.metroButton5.Size = new System.Drawing.Size(217, 41);
            this.metroButton5.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroButton5.StyleManager = null;
            this.metroButton5.TabIndex = 2;
            this.metroButton5.Text = "Clear";
            this.metroButton5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroButton5.Click += new System.EventHandler(this.metroButton5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GuiCalculator.Properties.Resources.Calculator_icon;
            this.pictureBox1.Location = new System.Drawing.Point(9, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ConversionCal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 246);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton5);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.textBox1);
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConversionCal";
            this.Text = "Conversion Calculator";
            this.TextAlign = MetroFramework.Forms.TextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox textBox1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton metroButton5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}