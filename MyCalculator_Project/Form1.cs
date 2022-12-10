using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator_Project
{
    public partial class Form1 : Form
    {
        private double firstNumber;
        private char sign;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (sign)
            {
                case '+':
                  display.Text =  (firstNumber + Convert.ToDouble(display.Text)).ToString();
                  break;
                case '-':
                    display.Text = (firstNumber - Convert.ToDouble(display.Text)).ToString();
                    break;
                case '*':
                    display.Text = (firstNumber * Convert.ToDouble(display.Text)).ToString();
                    break;
                case '/':
                    display.Text = (firstNumber / Convert.ToDouble(display.Text)).ToString();
                    break;
                case '%':
                    display.Text = ((firstNumber / 100) * Convert.ToDouble(display.Text)).ToString("#.##");
                    break;
                case '^':
                    display.Text = (Math.Pow(firstNumber, Convert.ToDouble(display.Text))).ToString();
                    break;
                case '√':
                    display.Text = (Math.Sqrt(firstNumber).ToString());
                    break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSeven_Click(object sender, EventArgs e)
        {
            display.Text += "7";
        }

        private void buttonEight_Click(object sender, EventArgs e)
        {
            display.Text += "8";

        }

        private void buttonNine_Click(object sender, EventArgs e)
        {
            display.Text += "9";

        }

        private void buttonFour_Click(object sender, EventArgs e)
        {
            display.Text += "4";

        }

        private void buttonFive_Click(object sender, EventArgs e)
        {
            display.Text += "5";

        }

        private void buttonSix_Click(object sender, EventArgs e)
        {
            display.Text += "6";

        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            display.Text += "1";

        }

        private void buttonTwo_Click(object sender, EventArgs e)
        {
            display.Text += "2";

        }

        private void buttonThree_Click(object sender, EventArgs e)
        {
            display.Text += "3";

        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            display.Text += "0";

        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            if (!display.Text.Contains("."))
            {
                display.Text += ".";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            display.Clear();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(display.Text);
            sign = '+';

            display.Clear();

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(display.Text);
            sign = '-';
            
            display.Clear();

        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(display.Text);
            sign = '*';

            display.Clear();
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(display.Text);
            sign = '/';

            display.Clear();
        }

        private void buttonPercentage_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(display.Text);
            sign = '%';

            display.Clear();
        }

        private void buttonPower_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(display.Text);
            sign = '^';

            display.Clear();
        }

        private void buttonRoot_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(display.Text);
            sign = '√';

            display.Clear();
        }
    }
}
