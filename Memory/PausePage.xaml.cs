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

namespace Memory
{
    /// <summary>
    /// Interaction logic for PausePage.xaml
    /// </summary>
    public partial class PausePage : Page
    {
        public PausePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Navigates to WelkomPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Instellingenbtn_Click(object sender, RoutedEventArgs e)
        {
            // through the course of clicking the button the navigation system switches the current frame uri to the new one//
            NavigationService.Navigate(new InstellingenPage());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Startoverbtn_Click(object sender, RoutedEventArgs e)
        {
            // through the course of clicking the button the navigation system switches the current frame uri to the new one//
            NavigationService.Navigate(new MemoryPage());
        }
        /// <summary>
        /// Navigates to MemoryPage after resuming game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hervatbtn_Click(object sender, RoutedEventArgs e)
        {
            // through the course of clicking the button the navigation system switches the current frame uri to the new one//
            NavigationService.Navigate(new MemoryPage());
        }
        /// <summary>
        /// Saves game and navigates WelkomPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Opslaanbtn_Click(object sender, RoutedEventArgs e)
        {
            // through the course of clicking the button the navigation system switches the current frame uri to the new one//
            NavigationService.Navigate(new WelkomPage());
        }
        /// <summary>
        /// Deletes your current game and navigates to WelkomPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quitbtn_Click(object sender, RoutedEventArgs e)
        {
            // through the course of clicking the button the navigation system switches the current frame uri to the new one//
            NavigationService.Navigate(new WelkomPage());
        }
    }
}
