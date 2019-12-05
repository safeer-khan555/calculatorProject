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

using System.Threading;
namespace GuiCalculator
{
    public partial class SelectionForm : MetroForm
    {
        SoundPlayer sp = new SoundPlayer(Properties.Resources.Mechanical_Keyboard_single_button_presses_8_www_FesliyanStudios_com);
        public SelectionForm()
        {
            Thread td=new Thread (show);
            td.Start();
            InitializeComponent();
            Thread.Sleep(11000);
          
            
        }
        public void show()
        {
            Application.Run(new StartForm());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.Play();
            Form1 standard = new Form1();
            standard.ShowDialog();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sp.Play();
            ConversionCal conversion = new ConversionCal();
            conversion.ShowDialog();
            
        }
    }
}
