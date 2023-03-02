﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace WindowsCalculator
{

    public partial class MainWindow : Window
    {
        string output = "";

        double temp = 0;

        string operation = "";


        public MainWindow()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {
                case "buttonOne":
                    output += "1";
                    Output.Text = output;
                    break;

                case "buttonTwo":
                    output += "2";
                    Output.Text = output;
                    break;

                case "buttonThree":
                    output += "3";
                    Output.Text = output;
                    break;

                case "buttonFour":
                    output += "4";
                    Output.Text = output;
                    break;

                case "buttonFive":
                    output += "5";
                    Output.Text = output;
                    break;

                case "buttonSix":
                    output += "6";
                    Output.Text = output;
                    break;

                case "buttonSeven":
                    output += "7";
                    Output.Text = output;
                    break;

                case "buttonEight":
                    output += "8";
                    Output.Text = output;
                    break;

                case "buttonNine":
                    output += "9";
                    Output.Text = output;
                    break;

                case "buttonZero":
                    output += "0";
                    Output.Text = output;
                    break;
            }
        }


        private void buttonSubtraction_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "-";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }

        private void buttonAddition_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "+";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }


        private void buttonMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "*";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }


        private void buttonDivision_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "/";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }


        private void buttonSqr_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "sqr";
            }

            switch (operation)
            {
                case "sqr":
                    double outputTempSqr = temp * temp;
                    output = outputTempSqr.ToString();
                    Output.Text = output;
                    break;
            }
            PreviewOutput.Text = operation + "( " + temp + " )";
        }


        private void buttonOneX_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "1/x";
            }

            switch (operation)
            {
                case "1/x":
                    double outputTempSqr = (1) / temp;
                    output = outputTempSqr.ToString();
                    Output.Text = output;
                    break;
            }
            PreviewOutput.Text = "1/" + "( " + temp + " )";
        }


        private void buttonEquals_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(output))
                output = temp.ToString();

            PreviewOutput.Text = (temp.ToString() + " " + operation + " " + double.Parse(output) + " " + "=");

            switch (operation)
            {
                case "-":
                    double outputTempSub = temp - double.Parse(output);
                    output = outputTempSub.ToString();
                    Output.Text = output;
                    break;

                case "+":
                    double outputTempAdd = temp + double.Parse(output);
                    output = outputTempAdd.ToString();
                    Output.Text = output;
                    break;

                case "*":
                    double outputTempMul = temp * double.Parse(output);
                    output = outputTempMul.ToString();
                    Output.Text = output;
                    break;

                case "/":
                    double outputTempDiv = temp / double.Parse(output);
                    output = outputTempDiv.ToString();
                    Output.Text = output;
                    break;

                case "%":
                    double outputTempPer = (temp * double.Parse(output)) / 100;
                    output = outputTempPer.ToString();
                    Output.Text = output;
                    break;
            }
        }



        private void buttonClearAll_Click(object sender, RoutedEventArgs e)
        {
            Output.Clear();
            Output.Text = "0";
            output = "";
            PreviewOutput.Clear();
            PreviewOutput.Text = "";
            temp = 0;
        }


        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {

        }


        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                Output.Clear();
                Output.Text = "0";
                output = "";
                PreviewOutput.Clear();
                PreviewOutput.Text = "";
                temp = 0;
            }
            else
            {
                Output.Clear();
                Output.Text = "0";
                output = "";
            }


            if (PreviewOutput.Text.EndsWith("="))
            {
                Output.Clear();
                Output.Text = "0";
                output = "";
                PreviewOutput.Clear();
                PreviewOutput.Text = "";
                temp = 0;
            }
        }


        private void buttonPercent_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "%";
            }
            PreviewOutput.Text = (temp.ToString() + " " + operation);
        }


        private void CopyButton_Click(object sender, RoutedEventArgs e)
        {
            Output.SelectAll();
            Output.Copy();
        }


        private void buttonSquareRoot_Click(object sender, RoutedEventArgs e)
        {
            if (output != "")
            {
                temp = double.Parse(output);

                output = "";

                operation = "√";
            }

            switch (operation)
            {
                case "√":
                    double outputTempSqrt = Math.Sqrt(temp);
                    output = outputTempSqrt.ToString();
                    Output.Text = output;
                    break;
            }
            PreviewOutput.Text = operation + "( " + temp + " )";
        }


        private void buttonPoNe_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {
                case "buttonPoNe":
                    output += "-";
                    Output.Text = output;
                    break;
            }
        }

        private void buttonDot_Click(object sender, RoutedEventArgs e)
        {
            string name = ((Button)sender).Name;

            switch (name)
            {
                case "buttonDot":
                    output += ".";
                    Output.Text = output;
                    break;
            }
        }
    }
}