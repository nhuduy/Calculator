using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /*
         * Variable
         */
        double firstNumber;
        double secondNumber;
        double result;
        string operation;

        // Delete all button
        private void btnAC_Click(object sender, EventArgs e)
        {
            result = 0;
            txtView.Text = "0";
        }

        //√

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtView.Text);
            txtView.Text = "0";
            operation = "√";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtView.Text);
            txtView.Text = "0";
            operation = "/";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtView.Text);
            txtView.Text = "0";
            operation = "*";
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtView.Text);
            txtView.Text = "0";
            operation = "-";
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtView.Text);
            txtView.Text = "0";
            operation = "+";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(txtView.Text);
            
            if(operation == "+")
            {
                result = firstNumber + secondNumber;
                txtView.Text = Convert.ToString(result);
                firstNumber = result;
            }

            else if (operation == "-")
            {
                result = firstNumber - secondNumber;
                txtView.Text = Convert.ToString(result);
                firstNumber = result;
            }

            else if (operation == "*")
            {
                result = firstNumber * secondNumber;
                txtView.Text = Convert.ToString(result);
                firstNumber = result;
            }

            else if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    txtView.Text = "Can't divide by zero";
                }

                else
                {
                    result = firstNumber / secondNumber;
                    txtView.Text = Convert.ToString(result);
                    firstNumber = result;
                }
            }

            else if (operation == "√")
            {
                
                result = (float)Math.Sqrt(secondNumber);
                txtView.Text = Convert.ToString(result);
                firstNumber = result;

                /*
                 * √
                 * If use firstNumber  . 
                 *  Example: 4√ = 2
                 *  If use secondNumber  . 
                 *  Example: √4 = 2
                 */
            }
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            txtView.Text = txtView.Text + ".";
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0" && txtView.Text != null)
            {
                txtView.Text = "0";
            }

            else
            {
                txtView.Text = txtView.Text + 0;
            }
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0" && txtView.Text != null)
            {
                txtView.Text = "1";
            }

            else
            {
                txtView.Text = txtView.Text + 1;
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0" && txtView.Text != null)
            {
                txtView.Text = "2";
            }

            else
            {
                txtView.Text = txtView.Text + 2;
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0" && txtView.Text != null)
            {
                txtView.Text = "3";
            }

            else
            {
                txtView.Text = txtView.Text + 3;
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0" && txtView.Text != null)
            {
                txtView.Text = "4";
            }

            else
            {
                txtView.Text = txtView.Text + 4;
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0" && txtView.Text != null)
            {
                txtView.Text = "5";
            }

            else
            {
                txtView.Text = txtView.Text + 5;
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0" && txtView.Text != null)
            {
                txtView.Text = "6";
            }

            else
            {
                txtView.Text = txtView.Text + 6;
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0" && txtView.Text != null)
            {
                txtView.Text = "7";
            }

            else
            {
                txtView.Text = txtView.Text + 7;
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0" && txtView.Text != null)
            {
                txtView.Text = "8";
            }

            else
            {
                txtView.Text = txtView.Text + 8;
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (txtView.Text == "0" && txtView.Text != null)
            {
                txtView.Text = "9";
            }

            else
            {
                txtView.Text = txtView.Text + 9;
            }
        }
    }
}
