using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100,0,0,0);
            btn_calculate.BackColor = Color.FromArgb(100, 0, 0, 0);
            btn_exit.BackColor = Color.FromArgb(100, 0, 0, 0);
            btn_clear.BackColor = Color.FromArgb(100, 0, 0, 0);
            txt_result.ForeColor = Color.Cyan;
        }
        private bool IsPresent(string input)
        {
            // Check if the input string is not null or empty
            return !string.IsNullOrWhiteSpace(input);
        }

        private bool IsDecimal(string input)
        {
            // Try to parse the input string to a decimal
            return decimal.TryParse(input, out _);
        }

        private bool IsWithinRange(decimal value, decimal minValue, decimal maxValue)
        {
            // Check if the value is within the specified range
            return value >= minValue && value <= maxValue;
        }
        private bool IsOperator(string input)
        {
            // Check if the input matches any of the valid operators
            return input == "+" || input == "-" || input == "*" || input == "/";
        }
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate the first operand
                if (!IsPresent(txt_operand1.Text))
                {
                    MessageBox.Show("Error: Operand 1 cannot be empty.", "Input Error");
                    return;
                }

                if (!IsDecimal(txt_operand1.Text))
                {
                    MessageBox.Show("Error: Operand 1 must be a valid decimal number.", "Input Error");
                    return;
                }

                // Validate the second operand
                if (!IsPresent(txt_operand2.Text))
                {
                    MessageBox.Show("Error: Operand 2 cannot be empty.", "Input Error");
                    return;
                }

                if (!IsDecimal(txt_operand2.Text))
                {
                    MessageBox.Show("Error: Operand 2 must be a valid decimal number.", "Input Error");
                    return;
                }
                // Validate the Operator
                if (!IsOperator(txt_operator.Text))
                {
                    MessageBox.Show("Error: Operand 2 must be a valid decimal number.", "Input Error");
                    return;
                }
                if (!IsPresent(txt_operator.Text))
                {
                    MessageBox.Show("Error: Operator cannot be empty.", "Input Error");
                    return;
                }

                decimal firstOperand = Convert.ToDecimal(txt_operand1.Text);
                decimal secondOperand = Convert.ToDecimal(txt_operand2.Text);
                string operators = txt_operator.Text;

                decimal result = 0;

                decimal minValue = -1000000; // Set your minimum value
                decimal maxValue = 1000000;  // Set your maximum value
                if (!IsWithinRange(firstOperand, minValue, maxValue) ||
                    !IsWithinRange(secondOperand, minValue, maxValue))
                {
                    MessageBox.Show($"Error: Operands must be between {minValue} and {maxValue}.", "Range Error");
                    return;
                }

                switch (operators)
                {
                    case "+":
                        result = firstOperand + secondOperand;
                        break;
                    case "-":
                        result = firstOperand - secondOperand;
                        break;
                    case "*":
                        result = firstOperand * secondOperand;
                        break;
                    case "/":
                        if (firstOperand == 0)
                        {
                            result = 0;
                            break;
                        }
                        else if (secondOperand == 0)
                        {
                            throw new DivideByZeroException();
                        }
                        else 
                        {
                            result = firstOperand / secondOperand;
                            return;
                        }
                        break;
                }
                txt_result.Text = $"{result}";
            }
            catch (FormatException)
            {
                MessageBox.Show("A format exception has occured. Please input right entries", "Entry Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show("An overflow Exception has occured. Please Enter smaller values.", "Entry Error");
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Error: Division by zero is not allowed.", "Division Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception");
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            // Clear the text boxes
            txt_operand1.Text = string.Empty;
            txt_operand2.Text = string.Empty;
            txt_operator.Text = string.Empty;
            txt_result.Text = string.Empty; // Clear the result display
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // Optionally, you can show a confirmation dialog before exiting
            var result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // Closes the application
                                    // or use this.Close(); if you're inside a Form and want to close that specific form
            }
        }
    }
}
