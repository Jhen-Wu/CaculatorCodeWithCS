using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        float firstNumber, secondNumber; 
        int operators = -1; 
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = ""; 
            textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "";
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "";
            textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "";
            textBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "";
            textBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "";
            textBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "";
            textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "";
            textBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text = "";
            textBox2.Text += "9";
        }

        private void add_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(textBox2.Text);
            textBox2.Text = "0"; 
            operators = 0; 
        }

        private void minus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(textBox2.Text);
            textBox2.Text = "0";
            operators = 1;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(textBox2.Text);
            textBox2.Text = "0";
            operators = 2;
        }

        private void divide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToSingle(textBox2.Text);
            textBox2.Text = "0";
            operators = 3;
        }

        private void equal_Click(object sender, EventArgs e)
        {
            float finalResults = 0f; 
            secondNumber = Convert.ToSingle(textBox2.Text); 

            switch (operators)
            {
                case 0:
                    finalResults = firstNumber + secondNumber;
                    break;
                case 1:
                    finalResults = firstNumber - secondNumber;
                    break;
                case 2:
                    finalResults = firstNumber * secondNumber;
                    break;
                case 3:
                    finalResults = firstNumber / secondNumber;
                    break;
            }

            textBox2.Text = string.Format("{0:0.##########}", finalResults); 

            firstNumber = 0f;
            secondNumber = 0f;
            operators = -1;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "0")
                textBox2.Text += "0";
        }
    }
}
