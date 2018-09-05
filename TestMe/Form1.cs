using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace TestMe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {

            if (textBoxNumber.Text.Length > 0)
            {
                try
                {
                    int value = Convert.ToInt32(textBoxNumber.Text);

                    if (value % 2 == 0)
                        textBoxOddEven.Text = "" + value + " is Even";
                    else
                        textBoxOddEven.Text = "" + value + " is Odd";

                    if (isPrime(value))
                        textBoxPrime.Text = "" + value + " is a Prime";
                    else
                        textBoxPrime.Text = "" + value + " is not a Prime";

                    if (isSquare(value) != -1)
                        textBoxSquareOf.Text = "" + value + " is a square of " + isSquare(value);
                    else
                        textBoxSquareOf.Text = "" + value + " is not a sqaure of another number ";

                    ArrayList f = primeFactors(value);
                    textBoxFactors.Text = "" + value + " has the follwoing prime factors: " + String.Join(",", f.ToArray());

                }
                catch (Exception ex)
                {
                    textBoxOddEven.Text = "Bad Input";
                    textBoxPrime.Text = "";
                    textBoxSquareOf.Text = "";
                    textBoxFactors.Text = "";
                }
            }
            else
            {
                textBoxOddEven.Text = "";
                textBoxPrime.Text = "";
                textBoxSquareOf.Text = "";
                textBoxFactors.Text = "";
            }
                
        }

        private int isSquare(int number)
        {
            if (number < 0)
                return -1;
            double result = Math.Sqrt(number);
            bool isSquare = result % 1 == 0;
            return (isSquare ? (int)result : -1);
        }

        private Boolean isPrime(int n)
        {
            if (n == 2)
                return true;
            if (n % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i * i <= n; i += 2)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private ArrayList primeFactors(int number)
        {
           ArrayList f = new ArrayList();
                
           int start = 2;
           int inc = 1;
           if (number%2 == 1) {
              start = 3;
              inc = 2;
           }
      
           for (int l = start; l*l <= number; l+=inc) {
             if (number % l == 0 && isPrime(l)) {
                f.Add(l);             // Add both factors
                if (l != number / l && isPrime(number / l)) {
                   f.Add(number / l);
                }
             }
           }
           return f;
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
