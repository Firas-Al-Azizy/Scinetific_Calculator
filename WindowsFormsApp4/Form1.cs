using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class calc : Form
    {
        double num1, num2, result;
        char op;
         
        public calc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {         
        }

        private void zero_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "0";
        }

        private void calc_Load(object sender, EventArgs e)
        {
           
        }

        private void sign_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "-";
        }

        private void dot_Click(object sender, EventArgs e)
        {
            txtCalc.Text += ".";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtCalc.Text);
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                case '%':
                    result = num1 % num2;
                    break;
            }
            txtCalc.Text = Convert.ToString(result);
        }

        private void sin_Click(object sender, EventArgs e)
        {
            result = Math.Sin(Math.PI * Convert.ToDouble(txtCalc.Text) / 180);

        }

        private void cos_Click(object sender, EventArgs e)
        {
            result = Math.Cos(Math.PI*Convert.ToDouble(txtCalc.Text)/180);

        }

        private void tan_Click(object sender, EventArgs e)
        {
            result = Math.Tan(Math.PI * Convert.ToDouble(txtCalc.Text) / 180);

        }

        private void div_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtCalc.Text);
            op = '/';
            txtCalc.Clear();

        }

        private void mul_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtCalc.Text);
            op = '*';
            txtCalc.Clear();

        }

        private void min_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtCalc.Text);
            op = '-';
            txtCalc.Clear();

        }

        private void plus_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtCalc.Text);
            op = '+';
            txtCalc.Clear();
        }

        private void one_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "3";
        }

        private void six_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "6";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "9";
        }

        private void mod_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtCalc.Text);
            op = '%';
            txtCalc.Clear();

        }

        private void pow2_Click(object sender, EventArgs e)
        {
            result = Math.Pow(Convert.ToDouble(txtCalc.Text),2);
        }

        private void c_Click(object sender, EventArgs e)
        {
            txtCalc.Clear();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            result = Math.Sqrt(Convert.ToDouble(txtCalc.Text)) ;
          
        }

        private void seven_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "8";
        }

        private void five_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "5";
        }

        private void four_Click(object sender, EventArgs e)
        {
            txtCalc.Text += "4";
        }

        private void erase_Click(object sender, EventArgs e)
        {
            txtCalc.Text = txtCalc.Text.Remove(txtCalc.TextLength-1,1);
        }
    }
}
