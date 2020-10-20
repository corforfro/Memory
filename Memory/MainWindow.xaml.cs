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
using Memory.Properties;
using System.IO;
using System.Media;
using System.Threading;
using Memory.Classes;

namespace Memory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        /// <summary>
        /// Loads highscores
        /// Makes sure theme works
        /// Toggles the background music on or off depending on the settings
        /// Loads WelkomPage.xaml
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();

            // initialize the beginner frame with the "WelkomPage" view//
            var welcomeUri = new Uri("WelkomPage.xaml", UriKind.Relative);
            frmMainContent.Source = welcomeUri;
        }
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainWindow_Closed(object sender, EventArgs e)
        {
            sp.Stop();
            Application.Current.Shutdown();
        }
    }
}
