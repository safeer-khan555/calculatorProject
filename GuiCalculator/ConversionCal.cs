using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;
using System.Media;

namespace GuiCalculator
{
    public partial class ConversionCal : MetroForm
    {
        int binval;
        public ConversionCal()
        {
            InitializeComponent();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
          binval   = int.Parse(textBox1.Text);
            string binstr = Convert.ToString(binval, 16);
            textBox1.Text = binstr;
            Form1._sp.Play();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           binval = int.Parse(textBox1.Text);
            string binstr = Convert.ToString(binval, 2);
            textBox1.Text = binstr;
            Form1._sp.Play();
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            binval = 0;
            Form1._sp.Play();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int decval = Convert.ToInt32(textBox1.Text, 2);
            textBox1.Text = decval.ToString();
            Form1._sp.Play();
        }
    }
}
