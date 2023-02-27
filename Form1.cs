using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public static string x;
        public static int num1;
        public static int num2;
        public int result;
        public static bool input;
        public static bool input2;
        public static bool input3;
        public static bool input4;
        public static bool input5;

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (input || input2 || input3 || input4 == true)
            {
                num2 = int.Parse(num2.ToString() + "0");
                label2.Text = num2.ToString();
                input5 = true;
            } else
            {
                num1 = int.Parse(num1.ToString() + "0");
                label1.Text = num1.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (input || input2 || input3 || input4 == true)
            {
                num2 = int.Parse(num2.ToString() + "1");
                label2.Text = num2.ToString();
                input5 = true;
            }
            else
            {
                num1 = int.Parse(num1.ToString() + "1");
                label1.Text = num1.ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (input || input2 || input3 || input4 == true)
            {
                num2 = int.Parse(num2.ToString() + "2");
                label2.Text = num2.ToString();
                input5 = true;
            }
            else
            {
                num1 = int.Parse(num1.ToString() + "2");
                label1.Text = num1.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (input || input2 || input3 || input4 == true)
            {
                num2 = int.Parse(num2.ToString() + "3");
                label2.Text = num2.ToString();
                input5 = true;
            }
            else
            {
                num1 = int.Parse(num1.ToString() + "3");
                label1.Text = num1.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (input || input2 || input3 || input4 == true)
            {
                num2 = int.Parse(num2.ToString() + "4");
                label2.Text = num2.ToString();
                input5 = true;
            }
            else
            {
                num1 = int.Parse(num1.ToString() + "4");
                label1.Text = num1.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (input || input2 || input3 || input4 == true)
            {
                num2 = int.Parse(num2.ToString() + "5");
                label2.Text = num2.ToString();
                input5 = true;
            }
            else
            {
                num1 = int.Parse(num1.ToString() + "5");
                label1.Text = num1.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (input || input2 || input3 || input4 == true)
            {
                num2 = int.Parse(num2.ToString() + "6");
                label2.Text = num2.ToString();
                input5 = true;
            }
            else
            {
                num1 = int.Parse(num1.ToString() + "6");
                label1.Text = num1.ToString();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (input || input2 || input3 || input4 == true)
            {
                num2 = int.Parse(num2.ToString() + "7");
                label2.Text = num2.ToString();
                input5 = true;
            }
            else
            {
                num1 = int.Parse(num1.ToString() + "7");
                label1.Text = num1.ToString();
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            if (input || input2 || input3 || input4 == true)
            {
                num2 = int.Parse(num2.ToString() + "8");
                label2.Text = num2.ToString();
                input5 = true;
            }
            else
            {
                num1 = int.Parse(num1.ToString() + "8");
                label1.Text = num1.ToString();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (input || input2 || input3 || input4 == true)
            {
                num2 = int.Parse(num2.ToString() + "9");
                label2.Text = num2.ToString();
                input5 = true;
            }
            else
            {
                num1 = int.Parse(num1.ToString() + "9");
                label1.Text = num1.ToString();
            }
        }

        public void button11_Click(object sender, EventArgs e)
        {
            input = true;
            label1.ResetText();
            label2.ResetText();

            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            input2 = true;
            label1.ResetText();
            label2.ResetText();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            input3 = true;
            label1.ResetText();
            label2.ResetText();
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            input4 = true;
            label1.ResetText();
            label2.ResetText();
        }
        public void calculate_Click(object sender, EventArgs e)
        {
            label2.ResetText();
            label1.ResetText();
            if (input5 == true && input == true)
            {
                result = num1 * num2;
                label1.Text = result.ToString();
            } else if (input5 == true && input2 == true)
            {
                result = num1 / num2;
                label1.Text = result.ToString();
            } else if (input5 == true && input3 == true)
            {
                result = num1 + num2;
                label1.Text = result.ToString();
            } else if (input5 == true && input4 == true)
            {
                result = num1 - num2;
                label1.Text = result.ToString();
            }

        }
        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

