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
        private int _previousNumber;
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
            if (TextBox.Text == "C")
            {
                TextBox.Text = " ";
                return;
            }
            _operation = ((Button)sender).Content.ToString(); // присваиваю значение операции из нажатой кнопки
            _previousNumber = int.Parse(TextBox.Text); // сохраняю предыдущее значение ввода
            TextBox.Text = ""; // Сбрасываю значение TextBox для следующего ввода
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            int currentInput = int.Parse(TextBox.Text); // получаю текущий элемент 
            int result = 0;

            switch (_operation)
            {
                case "+":
                    result = _previousNumber + Convert.ToInt32(TextBox.Text);
                    break;
                case "-":
                    result = _previousNumber - Convert.ToInt32(TextBox.Text);
                    break;
                case "*":
                    result = _previousNumber * Convert.ToInt32(TextBox.Text);
                    break;
                case "/":
                    result = _previousNumber / Convert.ToInt32(TextBox.Text);
                    break;
            }
             TextBox.Text = result.ToString();
             
        }

    }
         
}
