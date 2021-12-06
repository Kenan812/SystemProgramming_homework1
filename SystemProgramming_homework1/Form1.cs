using System;
using System.Threading;
using System.Windows.Forms;

namespace SystemProgramming_homework1
{
    public partial class Form1 : Form
    {
        private bool primeHasStarted = false;
        private bool fibonacciHasStarted = false;

        private bool stopPrime = false;
        private bool stopFibonacci = false;

        private bool continuePrime = true;
        private bool continueFibonacci = true;

        public Form1()
        {
            InitializeComponent();
        }



        private void startPrimeNumbersButton_Click(object sender, EventArgs e)
        {
            if (!primeHasStarted)
                ThreadPool.QueueUserWorkItem(PrintPrimeNumbers);

            primeHasStarted = true;
        }

        private void stopPrimeButton_Click(object sender, EventArgs e)
        {
            stopPrime = true;
        }

        private void pausePrimeNumbersButton_Click(object sender, EventArgs e)
        {
            continuePrime = false;
        }

        private void resumePrimeNumbersButton_Click(object sender, EventArgs e)
        {
            continuePrime = true;
        }

        private void restartPrimeButton_Click(object sender, EventArgs e)
        {
            primeNumbersTextBox.Text = String.Empty;
            ThreadPool.QueueUserWorkItem(PrintPrimeNumbers);
            stopPrime = false;
        }




        private void startFibonacciButton_Click(object sender, EventArgs e)
        {
            if (!fibonacciHasStarted)
                ThreadPool.QueueUserWorkItem(PrintFibonacci);

            fibonacciHasStarted = true;
        }

        private void stopFibonacciButton_Click(object sender, EventArgs e)
        {
            stopFibonacci = true;
        }

        private void restartFibonacciButton_Click(object sender, EventArgs e)
        {
            fibonacciNumbersTextBox.Text = String.Empty;
            ThreadPool.QueueUserWorkItem(PrintFibonacci);
            stopFibonacci = false;
        }




        private void PrintFibonacci(object obj)
        {
            if (!stopFibonacci)
            {
                fibonacciNumbersTextBox.Text += "0 ";
                fibonacciNumbersTextBox.Text += "1 ";
            }

            long prevprev = 0;
            long prev = 1;
            while (!stopFibonacci)
            {
                long next = GetNextFibonacci(prevprev, prev);
                fibonacciNumbersTextBox.Text += $"{ next } ";

                prevprev = prev;
                prev = next;
                Thread.Sleep(750);
            }
        }


        private void PrintPrimeNumbers(object obj)
        {
            long lb = 2;
            long ub = -1;

            if (lowerBoundTextBox.Text != String.Empty)
            {
                try
                {
                    lb = long.Parse(lowerBoundTextBox.Text);
                }
                catch (Exception)
                {
                    lb = 2;
                }
            }

            if (upperBoundTextBox.Text != String.Empty)

            {
                try
                {
                    ub = long.Parse(upperBoundTextBox.Text);
                }
                catch (Exception)
                {
                    ub = -1;
                }
            }

            if (!stopPrime)
            {
                if (ub != -1)  // there is upper bound
                {
                    for (long i = lb; i <= ub; i++)
                    {
                        if (stopPrime) break;

                        if (IsPrime(i))
                        {
                            primeNumbersTextBox.Text += $"{i} ";
                            Thread.Sleep(650);
                        }
                    }
                }

                else  // no upper bound
                {
                    for (long i = lb; ; i++)
                    {
                        if (stopPrime) break;

                        if (IsPrime(i))
                        {
                            primeNumbersTextBox.Text += $"{i} ";
                            Thread.Sleep(650);
                        }
                    }
                }
            }
        }


        private bool IsPrime(long n)
        {
            if (n <= 1) return false;
            if (n == 2) return true;
            if (n % 2 == 0) return false;

            for (int i = 3; i <= (int)Math.Floor(Math.Sqrt(n)); i += 2)
                if (n % i == 0)
                    return false;

            return true;
        }


        private long GetNextFibonacci(long prevprev = 0, long prev = 1)
        {
            return prevprev + prev;
        }

        
 
    }
}
