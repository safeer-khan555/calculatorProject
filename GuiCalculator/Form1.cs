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
    public partial class Form1 : MetroForm
    {
    public  static SoundPlayer _sp = new SoundPlayer(Properties.Resources.iPhone_typing_on_keyboard__6E7D336_MSH_);
    public static   SoundPlayer _sp1 = new SoundPlayer(Properties.Resources.Mechanical_Keyboard_single_button_presses_8_www_FesliyanStudios_com);
        string Isoperator="";
        float value1;
        bool operation = false;
        bool isequal;
        bool Opcode = false;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void metroButton15_Click(object sender, EventArgs e)
        {
            _sp.Play();
            if (string.IsNullOrEmpty(resulttxt.Text))
            {
                MessageBox.Show("please enter some values");
            }
            else
            {
                isequal = true;
                switch (Isoperator)
                {
                    case "+":
                        resulttxt.Text = value1 + "+" + resulttxt.Text + "=" + (value1 + (float.Parse(resulttxt.Text)));
                        resultlbl.Text = resulttxt.Text;
                        break;
                    case "-":
                        resulttxt.Text = value1 + "-" + resulttxt.Text + "=" + (value1 - (float.Parse(resulttxt.Text)));
                        resultlbl.Text = resulttxt.Text;
                        break;
                    case "*":
                        resulttxt.Text = value1 + "*" + resulttxt.Text + "=" + (value1 * (float.Parse(resulttxt.Text)));
                        resultlbl.Text = resulttxt.Text;
                        break;
                    case "/":
                        resulttxt.Text = value1 + "/" + resulttxt.Text + "=" + (value1 / (float.Parse(resulttxt.Text)));
                        resultlbl.Text = resulttxt.Text;
                        break;
                    default:
                        break;
                }
            }
           
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            MetroButton btn = (MetroButton)sender;
            if (resulttxt.Text=="0" || operation || isequal)
            {
                resulttxt.Text = "";
            }
            operation = false;
            isequal = false;
            resulttxt.Text += btn.Text;
            resultlbl.Text += btn.Text;
            _sp.Play();
        }

        private void btnc_Click(object sender, EventArgs e)
        {
            _sp.Play();
            resulttxt.Text = "0";
            resultlbl.Text = "";
            value1 =0.0f;
            Opcode = false;
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            if (!Opcode)
            {
                MetroButton btnoperator = (MetroButton)sender;
                Isoperator = btnoperator.Text;
                resultlbl.Text += btnoperator.Text;


                value1 = float.Parse(resulttxt.Text);
                operation = true;
                _sp1.Play();
                Opcode=true;
            }
            else
            {
                MessageBox.Show("Not allowed");
            }
        }

        private void resulttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) ||char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
              

                MessageBox.Show("string not allowed please enter digit value");
            }
            if (e.KeyChar==46)
            {
                e.Handled = false;
                
            }
        }

        private void resulttxt_Click(object sender, EventArgs e)
        {

        }

        private void btnce_Click(object sender, EventArgs e)
        {
            int lastindex = resulttxt.Text.Length - 1;
            int lastIndexofLabresult = resultlbl.Text.Length - 1;
            if (operation)
            {
                resultlbl.Text = resultlbl.Text.Remove(lastIndexofLabresult);
                operation = false;
            }

          
            else
            {
                try
                {
                    resulttxt.Text = resulttxt.Text.Remove(lastindex);
                    resultlbl.Text = resultlbl.Text.Remove(lastIndexofLabresult);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                
            }
            
        }
    }
}
