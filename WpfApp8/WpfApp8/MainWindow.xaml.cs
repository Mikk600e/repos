using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            const string mutexNavn = "AM";
            InitializeComponent();
            using (Mutex mtx = new Mutex(false, mutexNavn))
            {
                if (mtx.WaitOne(15000, false))
                {
                    Thread t1 = new Thread(Watch);
                    t1.Start();
                    mtx.ReleaseMutex();
                }
                else
                {
                       MessageBox.Show
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void Watch()
        {
            FileSystemWatcher FileWatch = new FileSystemWatcher();
            FileWatch.Path = ("C:\\test");
            FileWatch.Changed += new FileSystemEventHandler(onChanged);
            FileWatch.Renamed += new RenamedEventHandler(onRenamed);

            FileWatch.EnableRaisingEvents = true;
        }
        public void onChanged(object source, FileSystemEventArgs args)
        {
            MessageBox.Show("Mappe ændret");
        }
        public void onRenamed(object source, RenamedEventArgs args)
        {
            MessageBox.Show("Fil navn ændret");
        }
    }
}
