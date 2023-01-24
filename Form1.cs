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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private string currentInput = "";
        private string currentOutput = "";
        private string result;
        private char currentOperator;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentInput += button1.Text;
            textBox1.Text = currentInput;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentInput += button2.Text;
            textBox1.Text = currentInput;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentInput += button3.Text;
            textBox1.Text = currentInput;    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            currentInput += button4.Text;
            textBox1.Text = currentInput;  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            currentInput += button5.Text;
            textBox1.Text = currentInput;  
        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentInput += button6.Text;
            textBox1.Text = currentInput; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            currentInput += button7.Text;
            textBox1.Text = currentInput;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            currentInput += button8.Text;
            textBox1.Text = currentInput;
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            currentInput += button9.Text;
            textBox1.Text = currentInput; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            currentInput += button10.Text;
            textBox1.Text = currentInput;       
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            currentInput = "";
            currentOutput = "";
            result = null;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (currentOutput != "")
            {
                if (result != null) textBox1.Text = result;
                PerformOperation(currentInput, currentOutput, currentOperator);
                textBox1.Text = result;
                currentInput = "";
                currentOutput = "";
                currentOperator = '+';
            }
            else
            {
                if (result != null || currentOutput == null)
                {
                    textBox1.Text = result;
                    currentOutput = result;
                    PerformOperation(currentInput, currentOutput, currentOperator);
                    currentOperator = '+';
                    currentInput = "";
                    textBox1.Text = result;
                }
                else
                {
                    currentOutput = currentInput;
                    currentInput = "";
                    currentOperator = '+';
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (currentOutput != "")
            {
                if (result != null) textBox1.Text = result;
                PerformOperation(currentInput, currentOutput, currentOperator);
                textBox1.Text = result;
                currentInput = "";
                currentOutput = "";
                currentOperator = '-';
            }
            else
            {
                if (result != null || currentOutput == null)
                {
                    textBox1.Text = result;
                    currentOutput = result;
                    PerformOperation(currentInput, currentOutput, currentOperator);
                    currentOperator = '-';
                    currentInput = "";
                    textBox1.Text = result;
                }
                else
                {
                    currentOutput = currentInput;
                    currentInput = "";
                    currentOperator = '-';
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (currentOutput != "")
            {
                if (result != null) textBox1.Text = result;
                PerformOperation(currentInput, currentOutput, currentOperator);
                textBox1.Text = result;
                currentInput = "";
                currentOutput = "";
                currentOperator = '/';
            }
            else
            {
                if (result != null || currentOutput == null)
                {
                    textBox1.Text = result;
                    currentOutput = result;
                    PerformOperation(currentInput, currentOutput, currentOperator);
                    currentOperator = '/';
                    currentInput = "";
                    textBox1.Text = result;
                }
                else
                {
                    currentOutput = currentInput;
                    currentInput = "";
                    currentOperator = '/';
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (currentOutput != "")
            {
                if (result != null) textBox1.Text = result;
                PerformOperation(currentInput, currentOutput, currentOperator);
                textBox1.Text = result;
                currentInput = "";
                currentOutput = "";
                currentOperator = '*';
            }
            else
            {
                if (result != null || currentOutput == null)
                {
                    textBox1.Text = result;
                    currentOutput = result;
                    PerformOperation(currentInput, currentOutput, currentOperator);
                    currentOperator = '*';
                    currentInput = "";
                    textBox1.Text = result;
                }
                else
                {
                    currentOutput = currentInput;
                    currentInput = "";
                    currentOperator = '*';
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (result != null) currentOutput = result;
            PerformOperation(currentInput, currentOutput, currentOperator);
            textBox1.Text = result;
        }

        private void PerformOperation(string currentInput, string currentOutput, char currentOperator)
        {
            switch (currentOperator)
            {
                case '+':
                    result = (double.Parse(currentOutput) + double.Parse(currentInput)).ToString();
                    break;
                case '-':
                    result = (double.Parse(currentOutput) - double.Parse(currentInput)).ToString();
                    break;
                case '/':
                    result = (double.Parse(currentOutput) / double.Parse(currentInput)).ToString();
                    break;
                case '*':
                    result = (double.Parse(currentOutput) * double.Parse(currentInput)).ToString();
                    break;
            }
        }
    }
}
