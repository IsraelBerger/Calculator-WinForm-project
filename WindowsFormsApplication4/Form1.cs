using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }
        List<double> input = new List<double>();
        List<char> inputCalculate = new List<char>();
        bool secondclick = true;
        int i = 0;
        bool clickedThis = true;
     
        private void butt1_Click(object sender, EventArgs e)
        {
            clickedThis = false;
            label1.Text += "1";   
        }

        private void butt2_Click(object sender, EventArgs e)
        {
            clickedThis = false;
            label1.Text += "2";
        }

        private void butt3_Click(object sender, EventArgs e)
        {
            clickedThis = false;
            label1.Text += "3";
        }

        private void butt4_Click(object sender, EventArgs e)
        {
            clickedThis =false;
            label1.Text += "4";
        }

        private void butt5_Click(object sender, EventArgs e)
        {
            label1.Text += "5"; clickedThis = false;
        }

        private void butt6_Click(object sender, EventArgs e)
        {
            clickedThis = false;
            label1.Text += "6";
        }

        private void butt7_Click(object sender, EventArgs e)
        {
            clickedThis = false;
            label1.Text += "7";
        }

        private void butt8_Click(object sender, EventArgs e)
        {
            clickedThis = false;
            label1.Text += "8";
        }

        private void butt9_Click(object sender, EventArgs e)
        {
            clickedThis = false;
            label1.Text += "9";
        }

        private void butt0_Click(object sender, EventArgs e)
        {
            clickedThis = false;
            label1.Text += "0";
        }
 private void buttDot_Click(object sender, EventArgs e)
        {
                                clickedThis =false;
                             label1.Text += ".";
        }
        private void buttA_Click(object sender, EventArgs e)
        {
            CalculationChoice('+');
            
        }
       
        private void buttM_Click(object sender, EventArgs e)
        {
            CalculationChoice('-');
        }

        private void buttT_Click(object sender, EventArgs e)
        {
            CalculationChoice('*');
        }

        private void buttD_Click(object sender, EventArgs e)
        {
            CalculationChoice('/');
        }

        private void buttE_Click(object sender, EventArgs e)
        {
            try {
                if (secondclick == true && i != 0)
                {

                    double c = double.Parse(label1.Text);
                    input.Insert(i, c);
                    double result = input[0];
                    for (int iterate = 0; iterate < i; iterate++)
                    {

                        switch (inputCalculate[iterate])
                        {
                            case '+':
                                result = result + input[iterate + 1];
                                break;
                            case '-':
                                result = result - input[iterate + 1];
                                break;
                            case '*':
                                result = result * input[iterate + 1];
                                break;
                            case '/':
                                result = result / input[iterate + 1];
                                break;
                            default:
                                break;
                        }
                    }
                    input.Clear();
                    inputCalculate.Clear();
                    i = 0;
                    label1.Text = result.ToString();
                    secondclick = false;
                }


            }
            catch (Exception)
                     {

                MessageBox.Show("only enter digits");
            }
            }
 private void CalculationChoice(char Chose)
        {
            try
            {

           
            secondclick = true;
            if (clickedThis && label1.Text.ToString() != string.Empty)
            {
                inputCalculate.Insert(i - 1, Chose);
            }
            if (label1.Text.ToString() != string.Empty && label1.Text.ToString()!=".")
            {
                double c = double.Parse(label1.Text);
                input.Insert(i, c);

                inputCalculate.Insert(i, Chose);
                i++;
                label1.Text = string.Empty;
                clickedThis = true;
            }
            }
            catch (Exception e)
            {
                MessageBox.Show("only enter digits");
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        private void buttClear_Click(object sender, EventArgs e)
        {
            input.Clear();
            inputCalculate.Clear();
            i = 0;
            label1.Text = string.Empty;
            secondclick = true;
        }

       
    }
}
