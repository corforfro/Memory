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
using System.Windows.Threading;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer Timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private int increment = 0;
        private void Dt_Tick(object sender, EventArgs e)
        {
            increment++;

            TimerLabel.Content = increment.ToString();
        }

        private void Startbtn_click(object sender, EventArgs e)
        {
            Timerstatus(1);
        }
        
        private void Pausebtn_click(object sender, EventArgs e)
        {
            Timerstatus(2);
        }

        private void Stopbtn_click(object sender, EventArgs e)
        {
            Timerstatus(3);
        }

        private void Timerstatus(int timer1)
        {
            
            Timer.Interval = TimeSpan.FromSeconds(1);
            Timer.Tick -= Dt_Tick;
            Timer.Tick += Dt_Tick;

            if (timer1 == 1)
            {
                Timer.Start();
            }

            if (timer1 == 2)
            {
                Timer.Stop();
            }

            if (timer1 == 3)
            {
                Timer.Stop();
                increment = 0;
                TimerLabel.Content = increment.ToString();
            }





        }


    }
}
