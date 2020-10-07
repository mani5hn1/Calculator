using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_new
{
    public partial class Form1 : Form
    {
        string input = string.Empty;
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        char operation;
        double result = 0.0;

        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Console.Text = "";
            input += "2";
            this.Console.Text += input;
        }

        private void One_Click(object sender, EventArgs e)
        {
            this.Console.Text = "";
            input += "1";
            this.Console.Text += input;
        }

        private void Three_Click_1(object sender, EventArgs e)
        {
            this.Console.Text = "";
            input += "3";
            this.Console.Text += input;
        }
        private void Four_Click_1(object sender, EventArgs e)
        {
            this.Console.Text = "";
            input += "4";
            this.Console.Text += input;
        }
        
        private void Five_Click_1(object sender, EventArgs e)
        {
            this.Console.Text = "";
            input += "5";
            this.Console.Text += input;
        }

        private void Six_Click_1(object sender, EventArgs e)
        {
            this.Console.Text = "";
            input += "6";
            this.Console.Text += input;
        }

        private void Seven_Click_1(object sender, EventArgs e)
        {
            this.Console.Text = "";
            input += "7";
            this.Console.Text += input;
        }

        private void Eight_Click_1(object sender, EventArgs e)
        {
            this.Console.Text = "";
            input += "8";
            this.Console.Text += input;
        }

        private void Nine_Click_1(object sender, EventArgs e)
        {
            this.Console.Text = "";
            input += "9";
            this.Console.Text += input;
        }

        private void Zero_Click_1(object sender, EventArgs e)
        {
            this.Console.Text = "";
            input += "0";
            this.Console.Text += input;
        }

        private void Clear_Click_1(object sender, EventArgs e)
        {
            this.Console.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;
        }

        private void Plus_Click_1(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '+';
            input = string.Empty;
        }

        private void Times_Click_1(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '*';
            input = string.Empty;
        }

        private void Divide_Click_1(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '/';
            input = string.Empty;
        }

        private void Minus_Click_1(object sender, EventArgs e)
        {
            operand1 = input;
            operation = '-';
            input = string.Empty;
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            operand2 = input;
            double num1, num2;
            double.TryParse(operand1, out num1);
            double.TryParse(operand2, out num2);

            this.Console.Text = "";
            this.input = string.Empty;
            this.operand1 = string.Empty;
            this.operand2 = string.Empty;

            if (operation == '+')
            {
                result = num1 + num2;
                Console.Text = result.ToString();
            }
            else if (operation == '-')
            {
                result = num1 - num2;
                Console.Text = result.ToString();
            }
            else if (operation == '*')
            {
                result = num1 * num2;
                Console.Text = result.ToString();
            }
            else if (operation == '/')
            {
                if (num2 != 0)
                {
                    result = num1 / num2;
                    Console.Text = result.ToString();
                }
                else
                {
                    Console.Text = "DIV/Zero!";
                }
            }
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            this.Console.Text = "";
            input += ".";
            this.Console.Text += input;
        }
    }

}
