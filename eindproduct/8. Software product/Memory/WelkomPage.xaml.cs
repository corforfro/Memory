using Memory.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for WelkomPage.xaml
    /// </summary>
    public partial class WelkomPage : Page
    {
        /// <summary>
        /// InitializeComponents
        /// </summary>


        /// <summary>
        /// constructs the highscore
        /// </summary>
        // public List<highscore> Highscores;
        public HighscoreList HighscoreList = HighscoreList.Instance();

        public WelkomPage()
        {
            InitializeComponent();

            //sorts the table with highest score first then time
            HighScoreTable.Items.SortDescriptions.Add(new SortDescription("Score", ListSortDirection.Descending));
            HighScoreTable.Items.SortDescriptions.Add(new SortDescription("Time", ListSortDirection.Ascending));

            //Binds the data to the table on the page
            HighScoreTable.ItemsSource = HighscoreList.GetList();
        }

        /// <summary>
        /// Navigates to InstellingPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Instellingenbtn_Click(object sender, RoutedEventArgs e)
        {
            // through the course of clicking the button the navigation system switches the current frame uri to the new one//
            NavigationService.Navigate(new InstellingenPage());
        }

        /// <summary>
        /// Navigates to SpelPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Startbtn_Click(object sender, RoutedEventArgs e)
        {
            // through the course of clicking the button the navigation system switches the current frame uri to the new one.//
            NavigationService.Navigate(new SpelSelectiePage());
        }

        /// <summary>
        /// uses the button click to load to your memory game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Loadbtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GamePage(true));
        }
    }
}
