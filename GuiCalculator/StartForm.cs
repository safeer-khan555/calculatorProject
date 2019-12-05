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


namespace GuiCalculator
{
    public partial class StartForm : MetroForm
    {
        public StartForm()
        {
            InitializeComponent();

        }

        private void StartForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            metroProgressBar1.Increment(1);
            if (metroProgressBar1.Value==100)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
