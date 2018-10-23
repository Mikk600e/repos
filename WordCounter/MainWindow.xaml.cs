using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
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

namespace WordCounter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Test test = new Test();
        public MainWindow()
        {
            //Thread wordCount = new Thread(countWords);
            InitializeComponent();
            
            DataContext = test;
            //wordCount.Start();
        }
        private void Word_Box_TextChanged(object sender, TextChangedEventArgs e)
        {
            string txt = Word_Box.Text;
            //txt.Split(new char[] { ' ' });
        
            //test.Jens = txt.Length;
            test.Jens = 99;
        }


    }
    class Test : INotifyPropertyChanged
    {
        private int jens = 9999;

        public int Jens
        {
            get { return jens; }
            set
            {
                    Jens = value;
                    OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
