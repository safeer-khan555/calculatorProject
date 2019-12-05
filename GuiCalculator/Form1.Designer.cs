namespace GuiCalculator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resulttxt = new MetroFramework.Controls.MetroTextBox();
            this.btn7 = new MetroFramework.Controls.MetroButton();
            this.btn8 = new MetroFramework.Controls.MetroButton();
            this.btn9 = new MetroFramework.Controls.MetroButton();
            this.btndiv = new MetroFramework.Controls.MetroButton();
            this.btnce = new MetroFramework.Controls.MetroButton();
            this.btn4 = new MetroFramework.Controls.MetroButton();
            this.btn5 = new MetroFramework.Controls.MetroButton();
            this.btn6 = new MetroFramework.Controls.MetroButton();
            this.btnmul = new MetroFramework.Controls.MetroButton();
            this.btnc = new MetroFramework.Controls.MetroButton();
            this.btn1 = new MetroFramework.Controls.MetroButton();
            this.btn2 = new MetroFramework.Controls.MetroButton();
            this.btn3 = new MetroFramework.Controls.MetroButton();
            this.btnminus = new MetroFramework.Controls.MetroButton();
            this.btnequl = new MetroFramework.Controls.MetroButton();
            this.btn0 = new MetroFramework.Controls.MetroButton();
            this.btndot = new MetroFramework.Controls.MetroButton();
            this.btnplus = new MetroFramework.Controls.MetroButton();
            this.resultlbl = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.SuspendLayout();
            // 
            // resulttxt
            // 
            this.resulttxt.CustomBackground = false;
            this.resulttxt.CustomForeColor = false;
            this.resulttxt.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.resulttxt.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.resulttxt.Location = new System.Drawing.Point(24, 88);
            this.resulttxt.Multiline = false;
            this.resulttxt.Name = "resulttxt";
            this.resulttxt.SelectedText = "";
            this.resulttxt.Size = new System.Drawing.Size(335, 30);
            this.resulttxt.Style = MetroFramework.MetroColorStyle.Blue;
            this.resulttxt.StyleManager = null;
            this.resulttxt.TabIndex = 0;
            this.resulttxt.Text = "0";
            this.resulttxt.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.SetToolTip(this.resulttxt, "Only allowed integer value");
            this.resulttxt.UseStyleColors = false;
            this.resulttxt.Click += new System.EventHandler(this.resulttxt_Click);
            this.resulttxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resulttxt_KeyPress);
            // 
            // btn7
            // 
            this.btn7.Highlight = false;
            this.btn7.Location = new System.Drawing.Point(24, 135);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(54, 31);
            this.btn7.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn7.StyleManager = null;
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn7.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn8
            // 
            this.btn8.Highlight = false;
            this.btn8.Location = new System.Drawing.Point(92, 135);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(54, 31);
            this.btn8.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn8.StyleManager = null;
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn8.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn9
            // 
            this.btn9.Highlight = false;
            this.btn9.Location = new System.Drawing.Point(161, 135);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(54, 31);
            this.btn9.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn9.StyleManager = null;
            this.btn9.TabIndex = 1;
            this.btn9.Text = "9";
            this.btn9.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn9.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btndiv
            // 
            this.btndiv.Highlight = false;
            this.btndiv.Location = new System.Drawing.Point(229, 135);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(54, 31);
            this.btndiv.Style = MetroFramework.MetroColorStyle.Blue;
            this.btndiv.StyleManager = null;
            this.btndiv.TabIndex = 1;
            this.btndiv.Text = "/";
            this.btndiv.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btndiv.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnce
            // 
            this.btnce.Highlight = false;
            this.btnce.Location = new System.Drawing.Point(298, 135);
            this.btnce.Name = "btnce";
            this.btnce.Size = new System.Drawing.Size(54, 31);
            this.btnce.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnce.StyleManager = null;
            this.btnce.TabIndex = 1;
            this.btnce.Text = "CE";
            this.btnce.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnce.Click += new System.EventHandler(this.btnce_Click);
            // 
            // btn4
            // 
            this.btn4.Highlight = false;
            this.btn4.Location = new System.Drawing.Point(24, 179);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(54, 31);
            this.btn4.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn4.StyleManager = null;
            this.btn4.TabIndex = 1;
            this.btn4.Text = "4";
            this.btn4.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn4.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn5
            // 
            this.btn5.Highlight = false;
            this.btn5.Location = new System.Drawing.Point(92, 179);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(54, 31);
            this.btn5.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn5.StyleManager = null;
            this.btn5.TabIndex = 1;
            this.btn5.Text = "5";
            this.btn5.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn5.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn6
            // 
            this.btn6.Highlight = false;
            this.btn6.Location = new System.Drawing.Point(161, 179);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(54, 31);
            this.btn6.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn6.StyleManager = null;
            this.btn6.TabIndex = 1;
            this.btn6.Text = "6";
            this.btn6.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn6.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnmul
            // 
            this.btnmul.Highlight = false;
            this.btnmul.Location = new System.Drawing.Point(229, 179);
            this.btnmul.Name = "btnmul";
            this.btnmul.Size = new System.Drawing.Size(54, 31);
            this.btnmul.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnmul.StyleManager = null;
            this.btnmul.TabIndex = 1;
            this.btnmul.Text = "*";
            this.btnmul.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnmul.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnc
            // 
            this.btnc.Highlight = false;
            this.btnc.Location = new System.Drawing.Point(297, 179);
            this.btnc.Name = "btnc";
            this.btnc.Size = new System.Drawing.Size(54, 31);
            this.btnc.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnc.StyleManager = null;
            this.btnc.TabIndex = 1;
            this.btnc.Text = "C";
            this.btnc.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnc.Click += new System.EventHandler(this.btnc_Click);
            // 
            // btn1
            // 
            this.btn1.Highlight = false;
            this.btn1.Location = new System.Drawing.Point(24, 222);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(54, 31);
            this.btn1.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn1.StyleManager = null;
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn1.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn2
            // 
            this.btn2.Highlight = false;
            this.btn2.Location = new System.Drawing.Point(92, 222);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(54, 31);
            this.btn2.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn2.StyleManager = null;
            this.btn2.TabIndex = 1;
            this.btn2.Text = "2";
            this.btn2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn2.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btn3
            // 
            this.btn3.Highlight = false;
            this.btn3.Location = new System.Drawing.Point(161, 222);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(54, 31);
            this.btn3.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn3.StyleManager = null;
            this.btn3.TabIndex = 1;
            this.btn3.Text = "3";
            this.btn3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn3.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnminus
            // 
            this.btnminus.Highlight = false;
            this.btnminus.Location = new System.Drawing.Point(229, 222);
            this.btnminus.Name = "btnminus";
            this.btnminus.Size = new System.Drawing.Size(54, 31);
            this.btnminus.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnminus.StyleManager = null;
            this.btnminus.TabIndex = 1;
            this.btnminus.Text = "-";
            this.btnminus.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnminus.Click += new System.EventHandler(this.btnplus_Click);

            // 
            // btnequl
            // 
            this.btnequl.Highlight = false;
            this.btnequl.Location = new System.Drawing.Point(298, 222);
            this.btnequl.Name = "btnequl";
            this.btnequl.Size = new System.Drawing.Size(54, 73);
            this.btnequl.Style = MetroFramework.MetroColorStyle.Magenta;
            this.btnequl.StyleManager = null;
            this.btnequl.TabIndex = 1;
            this.btnequl.Text = "=";
            this.btnequl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnequl.Click += new System.EventHandler(this.metroButton15_Click);
            // 
            // btn0
            // 
            this.btn0.Highlight = false;
            this.btn0.Location = new System.Drawing.Point(24, 259);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(122, 36);
            this.btn0.Style = MetroFramework.MetroColorStyle.Blue;
            this.btn0.StyleManager = null;
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btndot
            // 
            this.btndot.Highlight = false;
            this.btndot.Location = new System.Drawing.Point(161, 264);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(54, 31);
            this.btndot.Style = MetroFramework.MetroColorStyle.Blue;
            this.btndot.StyleManager = null;
            this.btndot.TabIndex = 1;
            this.btndot.Text = ".";
            this.btndot.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btndot.Click += new System.EventHandler(this.btn0_Click);
            // 
            // btnplus
            // 
            this.btnplus.Highlight = false;
            this.btnplus.Location = new System.Drawing.Point(229, 264);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(54, 31);
            this.btnplus.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnplus.StyleManager = null;
            this.btnplus.TabIndex = 1;
            this.btnplus.Text = "+";
            this.btnplus.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // resultlbl
            // 
            this.resultlbl.AccessibleName = "resultlbl";
            this.resultlbl.AutoSize = true;
            this.resultlbl.CustomBackground = false;
            this.resultlbl.CustomForeColor = false;
            this.resultlbl.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.resultlbl.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.resultlbl.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.resultlbl.Location = new System.Drawing.Point(260, 46);
            this.resultlbl.Name = "resultlbl";
            this.resultlbl.Size = new System.Drawing.Size(0, 0);
            this.resultlbl.Style = MetroFramework.MetroColorStyle.Blue;
            this.resultlbl.StyleManager = null;
            this.resultlbl.TabIndex = 2;
            this.resultlbl.Theme = MetroFramework.MetroThemeStyle.Light;
            this.resultlbl.UseStyleColors = false;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 321);
            this.Controls.Add(this.resultlbl);
            this.Controls.Add(this.btnequl);
            this.Controls.Add(this.btnc);
            this.Controls.Add(this.btnce);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnminus);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnmul);
            this.Controls.Add(this.btndot);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.resulttxt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Standard Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox resulttxt;
        private MetroFramework.Controls.MetroButton btn7;
        private MetroFramework.Controls.MetroButton btn8;
        private MetroFramework.Controls.MetroButton btn9;
        private MetroFramework.Controls.MetroButton btndiv;
        private MetroFramework.Controls.MetroButton btnce;
        private MetroFramework.Controls.MetroButton btn4;
        private MetroFramework.Controls.MetroButton btn5;
        private MetroFramework.Controls.MetroButton btn6;
        private MetroFramework.Controls.MetroButton btnmul;
        private MetroFramework.Controls.MetroButton btnc;
        private MetroFramework.Controls.MetroButton btn1;
        private MetroFramework.Controls.MetroButton btn2;
        private MetroFramework.Controls.MetroButton btn3;
        private MetroFramework.Controls.MetroButton btnminus;
        private MetroFramework.Controls.MetroButton btnequl;
        private MetroFramework.Controls.MetroButton btn0;
        private MetroFramework.Controls.MetroButton btndot;
        private MetroFramework.Controls.MetroButton btnplus;
        private MetroFramework.Controls.MetroLabel resultlbl;
        private MetroFramework.Components.MetroToolTip metroToolTip1;

    }
}

