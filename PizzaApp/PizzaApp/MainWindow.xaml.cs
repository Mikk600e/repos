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

namespace PizzaApp
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

        private void NewPizza_Click(object sender, RoutedEventArgs e)
        {
            int SizeInput = 2;
            int DoughInput = 1;
            int ToppingsInput = 5;
            int SauceInput = 2;
            int CheeseInput = 5;

            Pizza pizza = new Pizza(SizeInput, DoughInput, ToppingsInput, SauceInput, CheeseInput);
        }
    }
}
