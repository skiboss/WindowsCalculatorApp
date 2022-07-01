using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcWin
{
    public partial class calculator : Form
    {
        //declare variables
        private double prev; //hold decimal number
        private string opr; //hold operator
        private bool oprOn; //hold true or false
        public calculator()
        {
            InitializeComponent();
        }

        private void DisplayNumber(int num)
        {
            //set the length so the label will not take more than 15 char
            if (labelDisplay.Text.Length > 13) return;
            if (labelDisplay.Text == "0" || oprOn)
            {
                labelDisplay.Text = Convert.ToString(num);
                oprOn = false;
            }
            else
            {
                //+= concatenate the values
                labelDisplay.Text += Convert.ToString(num);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double curValue;
            switch (opr)
            {
                case "+":
                    curValue = prev + Convert.ToDouble(labelDisplay.Text);
                    labelDisplay.Text = curValue.ToString("");
                    break;
                case "-":
                    curValue = prev - Convert.ToDouble(labelDisplay.Text);
                    labelDisplay.Text = curValue.ToString("");
                    break;
                case "/":
                    curValue = prev / Convert.ToDouble(labelDisplay.Text);
                    labelDisplay.Text = curValue.ToString("");
                    break;
                case "x":
                    curValue = prev * Convert.ToDouble(labelDisplay.Text);
                    labelDisplay.Text = curValue.ToString("");
                    break;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "0";
        }

        private void buttonPeriod_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text.Contains(".")) return;
            labelDisplay.Text += ".";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            DisplayNumber(0);
        }

        private void one_Click(object sender, EventArgs e)
        {
            DisplayNumber(1);
        }

        private void two_Click(object sender, EventArgs e)
        {
            DisplayNumber(2);
        }

        private void t_Click(object sender, EventArgs e)
        {
            DisplayNumber(3);
        }

        private void four_Click(object sender, EventArgs e)
        {
            DisplayNumber(4);
        }

        private void five_Click(object sender, EventArgs e)
        {
            DisplayNumber(5);
        }

        private void six_Click(object sender, EventArgs e)
        {
            DisplayNumber(6);
        }

        private void seven_Click(object sender, EventArgs e)
        {
            DisplayNumber(7);
        }

        private void eight_Click(object sender, EventArgs e)
        {
            DisplayNumber(8);
        }

        private void nine_Click(object sender, EventArgs e)
        {
            DisplayNumber(9);
        }

        private void goBack_Click(object sender, EventArgs e)
        {
            if (labelDisplay.Text.Length < 2)
            {
                labelDisplay.Text = "0";
                return;
            }
            int lastIndex = labelDisplay.Text.Length - 1;
            labelDisplay.Text = labelDisplay.Text.Remove(lastIndex);
        }

        private void add_Click(object sender, EventArgs e)
        {
            oprOn = true;
            opr = "+";
            prev = Convert.ToDouble(labelDisplay.Text);
        }

        private void minus_Click(object sender, EventArgs e)
        {
            oprOn = true;
            opr = "-";
            prev = Convert.ToDouble(labelDisplay.Text);
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            oprOn = true;
            opr = "x";
            prev = Convert.ToDouble(labelDisplay.Text);
        }

        private void divide_Click(object sender, EventArgs e)
        {
            oprOn = true;
            opr = "/";
            prev = Convert.ToDouble(labelDisplay.Text);
        }

        private void clearAll_Click(object sender, EventArgs e)
        {
            labelDisplay.Text = "0";
        }
    }
}
