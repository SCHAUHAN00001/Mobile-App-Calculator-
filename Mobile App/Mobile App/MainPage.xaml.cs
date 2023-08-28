using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mobile_App
{
    public partial class MainPage : ContentPage
    {
        Label label;
        int number1;
        int number2;
        string symbol;
        bool isFirstClick = true;
        public MainPage()
        {
            InitializeComponent();
            label = this.FindByName<Label>("text");
        }
        void HandleClickOnNumber(object sender, EventArgs e)
        {
            string num = (sender as Button).Text;
            label.Text += " " + num;
            if (isFirstClick)
            {
                isFirstClick = false;
                number1 = int.Parse(num);
            }
            else
            {
                number2 = int.Parse(num);
            }

        }
        void HandleClickOnSymbol(object sender, EventArgs e)
        {
            string sign = (sender as Button).Text;
            symbol = sign;
            label.Text += " " + sign;

        }
        void HandleClickOnClear(object sender, EventArgs e)
        {
            isFirstClick=true;
            label.Text = "";
        }
        void HandleClickOnEquals(object sender, EventArgs e)
        {
            int result = 0;
            switch (symbol)
            {
                case "+":
                    result = number1+ number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "%":
                    result = number1 % number2;
                    break;
            }
            label.Text += " = " + result.ToString();
        }

    }
}
