using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Сalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _previousNumber;
        private string _operation;
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonNumber_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text += ((Button)sender).Content;
        }
        private void Operator_Click(object sender, RoutedEventArgs e)
        {
            _operation = ((Button)sender).Content.ToString(); // присваиваю значение операции из нажатой кнопки
            _previousNumber = double.Parse(TextBox.Text); // сохраняю предыдущее значение ввода
            TextBox.Text = ""; // Сбрасываю значение TextBox для следующего ввода
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            double currentInput = double.Parse(TextBox.Text); // получаю текущий элемент 
            double result = 0;

            switch (_operation)
            {
                case "+":
                    result = _previousNumber + currentInput;
                    break;
                case "-":
                    result = _previousNumber - currentInput;
                    break;
                case "*":
                    result = _previousNumber * currentInput;
                    break;
                case "/":
                    result = _previousNumber / currentInput;
                    break;
            }

            TextBox.Text = result.ToString();
        }
        private void ButtonRemoval_Click(object sender, RoutedEventArgs e)// кнопка с
        {
            TextBox.Text = "";
        }
       
        private void ButtonDecimalDivision_Click(object sender, RoutedEventArgs e)// добавление запятой
        {
            if (!TextBox.Text.Contains(","))
            {
                TextBox.Text += ",";
            }

        }

    }    

}
