using System;
using System.Collections.Generic;
using System.Linq;
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

namespace BinærtUr
{
    public partial class MainWindow : Window
    {
        ClockViewModel clock = new ClockViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = clock;
            Thread threadClock = new Thread(clock.Demo);
            threadClock.Start();
        }
    }
}