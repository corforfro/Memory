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

namespace speler_selectie_scherm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string Name1 { get; set; }
        public string Name2 { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }


        private void numberButton_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(buttonNumber.Content) == 1)
            {
                buttonNumber.Content = Convert.ToInt32(buttonNumber.Content) + 1;
            }
            else if(Convert.ToInt32(buttonNumber.Content) == 2)
            {
                buttonNumber.Content = Convert.ToInt32(buttonNumber.Content) - 1;
            
            }

            if (Convert.ToInt32(buttonNumber.Content) == 1)
            {
                name2.Visibility = Visibility.Hidden;
                name2.Clear();
            }
            if (Convert.ToInt32(buttonNumber.Content) == 2)
            {
               name2.Visibility = Visibility.Visible;
            }
        }

        private void startGame_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(name1.Text + name2.Text);
        }

        private void nameInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

       
    }
}
