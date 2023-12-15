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
        public MainWindow()
        {
            InitializeComponent();
        }
        private int _previosNumber;// предыдущий номер
       

        private void ButtonNumber_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Text +=((Button)sender).Content ;
        }

        private void ButtonOperator_Click(object sender, RoutedEventArgs e)
        {

            _previosNumber = Convert.ToInt32(TextBox.Text);
            TextBox.Text = " ";
            try
            {
                if (TextBox.Text == "С")
                {
                    TextBox.Text = " ";
                    return;
                }
                if(TextBox.Text == "=")
                {
                    
                }
                

            }
            catch { }
        }
    }
}
