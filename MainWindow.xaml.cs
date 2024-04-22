using System;
using System.Windows;

namespace April_18_24
{
    public partial class MainWindow : Window
    {
        bool first = true;
        bool second = false;
        bool hasResult = false;
        double firstNumber = 0;
        double secondNumber = 0;
        string operation = string.Empty;
        bool fract = false;
        int digitsCount = 0;
        bool error = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEquils_Click(object sender, RoutedEventArgs e)
        {
            if (!second)
            {
                return;
            }

            switch(operation)
            {
                case "+":
                    tb2.Text = (firstNumber + secondNumber).ToString();
                    break;
                case "-":
                    tb2.Text = (firstNumber - secondNumber).ToString();
                    break;
                case "*":
                    tb2.Text = (firstNumber * secondNumber).ToString();
                    break;
                case "/":
                    if (secondNumber != 0)
                    {
                        tb2.Text = (firstNumber / secondNumber).ToString();
                    }
                    else
                    {
                        tb2.Text = "Error!";
                        error = true;
                    }
                    break;
            }
            tb1.Text += secondNumber + "=";
            hasResult = true;
            first = true;
            second = false;

            fract = false;
            digitsCount = 0;
        }

        private void btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (hasResult)
            {
                tb2.Text = string.Empty;
                hasResult = false;
                first = true;
                second = false;
                firstNumber = 0;
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
                tb2.Text = string.Empty;
            }

            if (first)
            {
                if (!fract)
                {
                    firstNumber *= 10;
                    firstNumber += 9;
                }
                else
                {
                    digitsCount++;
                    firstNumber += 9 * Math.Pow(10, -digitsCount);
                }
                tb2.Text = firstNumber.ToString();
            }
            else
            {
                tb2.Text = string.Empty;

                if (!fract)
                {
                    secondNumber *= 10;
                    secondNumber += 9;
                }
                else
                {
                    digitsCount++;
                    secondNumber += 9 * Math.Pow(10, -digitsCount);
                }
                tb2.Text += secondNumber.ToString();
                second = true;
            }
        }
        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (hasResult)
            {
                tb2.Text = string.Empty;
                hasResult = false;
                first = true;
                second = false;
                firstNumber = 0;
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
                tb2.Text = string.Empty;
            }

            if (first)
            {
                if (!fract)
                {
                    firstNumber *= 10;
                    firstNumber += 8;
                }
                else
                {
                    digitsCount++;
                    firstNumber += 8 * Math.Pow(10, -digitsCount);
                }
                tb2.Text = firstNumber.ToString();
            }
            else
            {
                tb2.Text = string.Empty;

                if (!fract)
                {
                    secondNumber *= 10;
                    secondNumber += 8;
                }
                else
                {
                    digitsCount++;
                    secondNumber += 8 * Math.Pow(10, -digitsCount);
                }
                tb2.Text += secondNumber.ToString();
                second = true;
            }
        }
        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (hasResult)
            {
                tb2.Text = string.Empty;
                hasResult = false;
                first = true;
                second = false;
                firstNumber = 0;
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
                tb2.Text = string.Empty;
            }

            if (first)
            {
                if (!fract)
                {
                    firstNumber *= 10;
                    firstNumber += 7;
                }
                else
                {
                    digitsCount++;
                    firstNumber += 7 * Math.Pow(10, -digitsCount);
                }
                tb2.Text = firstNumber.ToString();
            }
            else
            {
                tb2.Text = string.Empty;

                if (!fract)
                {
                    secondNumber *= 10;
                    secondNumber += 7;
                }
                else
                {
                    digitsCount++;
                    secondNumber += 7 * Math.Pow(10, -digitsCount);
                }
                tb2.Text += secondNumber.ToString();
                second = true;
            }
        }
        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (hasResult)
            {
                tb2.Text = string.Empty;
                hasResult = false;
                first = true;
                second = false;
                firstNumber = 0;
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
                tb2.Text = string.Empty;
            }

            if (first)
            {
                if (!fract)
                {
                    firstNumber *= 10;
                    firstNumber += 6;
                }
                else
                {
                    digitsCount++;
                    firstNumber += 6 * Math.Pow(10, -digitsCount);
                }
                tb2.Text = firstNumber.ToString();
            }
            else
            {
                tb2.Text = string.Empty;

                if (!fract)
                {
                    secondNumber *= 10;
                    secondNumber += 6;
                }
                else
                {
                    digitsCount++;
                    secondNumber += 6 * Math.Pow(10, -digitsCount);
                }
                tb2.Text += secondNumber.ToString();
                second = true;
            }
        }
        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (hasResult)
            {
                tb2.Text = string.Empty;
                hasResult = false;
                first = true;
                second = false;
                firstNumber = 0;
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
                tb2.Text = string.Empty;
            }

            if (first)
            {
                if (!fract)
                {
                    firstNumber *= 10;
                    firstNumber += 5;
                }
                else
                {
                    digitsCount++;
                    firstNumber += 5 * Math.Pow(10, -digitsCount);
                }
                tb2.Text = firstNumber.ToString();
            }
            else
            {
                tb2.Text = string.Empty;

                if (!fract)
                {
                    secondNumber *= 10;
                    secondNumber += 5;
                }
                else
                {
                    digitsCount++;
                    secondNumber += 5 * Math.Pow(10, -digitsCount);
                }
                tb2.Text += secondNumber.ToString();
                second = true;
            }
        }
        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (hasResult)
            {
                tb2.Text = string.Empty;
                hasResult = false;
                first = true;
                second = false;
                firstNumber = 0;
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
                tb2.Text = string.Empty;
            }

            if (first)
            {
                if (!fract)
                {
                    firstNumber *= 10;
                    firstNumber += 4;
                }
                else
                {
                    digitsCount++;
                    firstNumber += 4 * Math.Pow(10, -digitsCount);
                }
                tb2.Text = firstNumber.ToString();
            }
            else
            {
                tb2.Text = string.Empty;

                if (!fract)
                {
                    secondNumber *= 10;
                    secondNumber += 4;
                }
                else
                {
                    digitsCount++;
                    secondNumber += 4 * Math.Pow(10, -digitsCount);
                }
                tb2.Text += secondNumber.ToString();
                second = true;
            }
        }
        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (hasResult)
            {
                tb2.Text = string.Empty;
                hasResult = false;
                first = true;
                second = false;
                firstNumber = 0;
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
                tb2.Text = string.Empty;
            }

            if (first)
            {
                if (!fract)
                {
                    firstNumber *= 10;
                    firstNumber += 3;
                }
                else
                {
                    digitsCount++;
                    firstNumber += 3 * Math.Pow(10, -digitsCount);
                }
                tb2.Text = firstNumber.ToString();
            }
            else
            {
                tb2.Text = string.Empty;

                if (!fract)
                {
                    secondNumber *= 10;
                    secondNumber += 3;
                }
                else
                {
                    digitsCount++;
                    secondNumber += 3 * Math.Pow(10, -digitsCount);
                }
                tb2.Text += secondNumber.ToString();
                second = true;
            }
        }
        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (hasResult)
            {
                tb2.Text = string.Empty;
                hasResult = false;
                first = true;
                second = false;
                firstNumber = 0;
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
                tb2.Text = string.Empty;
            }

            if (first)
            {
                if (!fract)
                {
                    firstNumber *= 10;
                    firstNumber += 2;
                }
                else
                {
                    digitsCount++;
                    firstNumber += 2 * Math.Pow(10, -digitsCount);
                }
                tb2.Text = firstNumber.ToString();
            }
            else
            {
                tb2.Text = string.Empty;

                if (!fract)
                {
                    secondNumber *= 10;
                    secondNumber += 2;
                }
                else
                {
                    digitsCount++;
                    secondNumber += 2 * Math.Pow(10, -digitsCount);
                }
                tb2.Text += secondNumber.ToString();
                second = true;
            }
        }
        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (hasResult)
            {
                tb2.Text = string.Empty;
                hasResult = false;
                first = true;
                second = false;
                firstNumber = 0;
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
                tb2.Text = string.Empty;
            }

            if (first)
            {
                if (!fract)
                {
                    firstNumber *= 10;
                    firstNumber += 1;
                }
                else
                {
                    digitsCount++;
                    firstNumber += Math.Pow(10, -digitsCount);
                }
                tb2.Text = firstNumber.ToString();
            }
            else
            {
                tb2.Text = string.Empty;

                if (!fract)
                {
                    secondNumber *= 10;
                    secondNumber += 1;
                }
                else
                {
                    digitsCount++;
                    secondNumber += Math.Pow(10, -digitsCount);
                }
                tb2.Text = secondNumber.ToString();
                second = true;
            }
        }
        private void btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (hasResult)
            {
                tb2.Text = string.Empty;
                hasResult = false;
                first = true;
                second = false;
                firstNumber = 0;
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
                tb2.Text = string.Empty;
            }

            if (first)
            {
                if (!fract)
                {
                    firstNumber *= 10;
                    tb2.Text = firstNumber.ToString();
                }
                else
                {
                    digitsCount++;
                    tb2.Text += "0";
                }
            }
            else
            {
                if (!fract)
                {
                    tb2.Text = string.Empty;
                    secondNumber *= 10;
                    tb2.Text += secondNumber.ToString();
                }
                else
                {
                    digitsCount++;
                    tb2.Text += "0";
                }
                second = true;
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (tb2.Text.Length == 0 && tb1.Text.Length == 0 || second || error)
            {
                return;
            }

            if (hasResult)
            {
                hasResult = false;
                first = true;
                second = false;
                firstNumber = double.Parse(tb2.Text);
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
            }

            if (fract)
            {
                digitsCount = 0;
                fract = false;
            }

            bool flag = operation == string.Empty;
            first = false;
            operation = "/";

            if (flag)
            {
                tb1.Text = tb2.Text + operation;
            }
            else
            {
                tb1.Text = tb1.Text.Remove(tb1.Text.Length - 1);
                tb1.Text += operation;
            }
        }
        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            if (tb2.Text.Length == 0 && tb1.Text.Length == 0 || second || error)
            {
                return;
            }

            if (hasResult)
            {
                hasResult = false;
                first = true;
                second = false;
                firstNumber = double.Parse(tb2.Text);
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
            }

            if (fract)
            {
                digitsCount = 0;
                fract = false;
            }

            bool flag = operation == string.Empty;
            first = false;
            operation = "*";

            if (flag)
            {
                tb1.Text = tb2.Text + operation;
            }
            else
            {
                tb1.Text = tb1.Text.Remove(tb1.Text.Length - 1);
                tb1.Text += operation;
            }
        }
        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            if (tb2.Text.Length == 0 && tb1.Text.Length == 0 || second || error)
            {
                return;
            }

            if (hasResult)
            {
                hasResult = false;
                first = true;
                second = false;
                firstNumber = double.Parse(tb2.Text);
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
            }

            if (fract)
            {
                digitsCount = 0;
                fract = false;
            }

            bool flag = operation == string.Empty;
            first = false;
            operation = "-";

            if (flag)
            {
                tb1.Text = tb2.Text + operation;
            }
            else
            {
                tb1.Text = tb1.Text.Remove(tb1.Text.Length - 1);
                tb1.Text += operation;
            }
        }
        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            if (tb2.Text.Length == 0 && tb1.Text.Length == 0 || second || error)
            {
                return;
            }

            if (hasResult)
            {
                hasResult = false;
                first = true;
                second = false;
                firstNumber = double.Parse(tb2.Text);
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
            }

            if (fract)
            {
                digitsCount = 0;
                fract = false;
            }

            bool flag = operation == string.Empty;
            first = false;
            operation = "+";

            if (flag)
            {
                tb1.Text = tb2.Text + operation;
            }
            else
            {
                tb1.Text = tb1.Text.Remove(tb1.Text.Length - 1);
                tb1.Text += operation;
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (error)
            {
                return;
            }

            if (hasResult)
            {
                hasResult = false;
                first = true;
                second = false;
                firstNumber = double.Parse(tb2.Text);
                secondNumber = 0;
                operation = string.Empty;
                tb1.Text = string.Empty;
                return;
            }

            if (first)
            {
                if (tb2.Text.Length != 0)
                {
                    tb2.Text = tb2.Text.Remove(tb2.Text.Length - 1);
                    
                    if (!fract)
                    {
                        firstNumber -= firstNumber % 10;
                        firstNumber /= 10;
                    }
                    else
                    {
                        if (digitsCount != 0)
                        {
                            string str = firstNumber.ToString();
                            str = str.Substring(0, str.Length - 1);
                            firstNumber = double.Parse(str);
                            digitsCount--;
                        }
                        else
                        {
                            fract = false;
                        }
                    }
                }
            }
            else if (second)
            {
                tb2.Text = tb2.Text.Remove(tb2.Text.Length - 1);

                if (!fract)
                {
                    secondNumber -= secondNumber % 10;
                    secondNumber /= 10;
                }
                else
                {
                    if (digitsCount != 0)
                    {
                        string str = secondNumber.ToString();
                        str = str.Substring(0, str.Length - 1);
                        secondNumber = double.Parse(str);
                        digitsCount--;
                    }
                    else
                    {
                        fract = false;
                    }
                }

                if (secondNumber == 0)
                {
                    second = false;
                }
            }
        }

        private void btnCE_Click(object sender, RoutedEventArgs e)
        {
            if (tb1.Text.Length != 0)
            {
                if (tb1.Text[tb1.Text.Length - 1].ToString().Equals("="))
                {
                    first = true;
                    second = false;
                    firstNumber = 0;
                    secondNumber = 0;
                    operation = string.Empty;
                    tb1.Text = string.Empty;
                    tb2.Text = string.Empty;
                }
                else
                {
                    if (first)
                    {
                        tb2.Text = tb2.Text.Remove(tb2.Text.Length - 1 - firstNumber.ToString().Length);
                    }
                    else if (second)
                    {
                        tb2.Text = tb2.Text.Remove(tb2.Text.Length - secondNumber.ToString().Length);
                        secondNumber = 0;
                    }
                }
            }
            else
            {
                firstNumber = 0;
                tb2.Text = string.Empty;
            }

            fract = false;
            digitsCount = 0;
            error = false;
        }
        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            first = true;
            second = false;
            firstNumber = 0;
            secondNumber = 0;
            operation = string.Empty;
            tb1.Text = string.Empty;
            tb2.Text = string.Empty;

            fract = false;
            digitsCount = 0;
            error = false;
        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (!fract && !(operation != string.Empty && !second))
            {
                fract = true;
                tb2.Text += ",";
            }
        }
    }
}
