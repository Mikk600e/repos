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

namespace WpfApp10
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
            string test3 = GetRandomPassword();
            InitializeComponent();
        }
        Random rnd = new Random();
        public string GetRandomUsername(string name)
        {
            rnd.Next();
            if (name.Length < 3)
            {
                name = name + GetRandomChar();
            }
            return name = name.Substring(0, 3) + GetRandomNumber(); 
        }
        public char GetRandomChar()
        {
            string chars = "abcdefghijklmnopqrstuvwxyz";
            int num = rnd.Next(0, chars.Length - 1);
            char rndChar = chars[num];
            return rndChar;
        }
        public string GetRandomNumber()
        {

            int rndNumb = rnd.Next(100, 999);
            string rndNumbString = rndNumb.ToString();
            return rndNumbString;
        }
        public string GetRandomPassword()
        {
            string password = System.IO.Path.GetRandomFileName();
            password = password.Substring(0, 8) + password.Replace(".", "");

            return password;
        }
    }
}
