using System;
using System.Collections.Generic;
using System.IO;
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
            else if (Convert.ToInt32(buttonNumber.Content) == 2)
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
            MessageBox.Show(name1.Text + name2.Text + gameTheme.Header);
        }
        private void cancel_click(object sender, RoutedEventArgs e)
        { 
        
        
        
        }
        



        private void nameInput_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void themeChoice_click(object sender, RoutedEventArgs e)
        {
            string buttonSource = e.Source.ToString();
            string[] splitString = buttonSource.Split(':');
            int themeNumber =  Convert.ToInt32(splitString[1].Split(' ')[1]);


            if (themeNumber == 1)
            {
                gameTheme.Header = "Game theme: art";
            }
            else if (themeNumber == 2)
            {
                gameTheme.Header = "Game theme: definetly porn";
            }
            else if (themeNumber == 3)
            {
                gameTheme.Header = "Game theme: funny pictures";
            }
            else if (themeNumber == 4)
            {
                gameTheme.Header = "Game theme: custom";
            }
            Image styleImage = new Image();
            Uri path = new Uri("C:/Users/matti/source/repos/new game/new game/Images/1.png", UriKind.Relative);
            /* deze path werkt niet voor iedereen sinds Arnold niet zijn User matti genoemd heeft */
            
            styleImage.Source = new BitmapImage(path);

            Grid.SetColumn(styleImage, 1);
            Grid.SetRow(styleImage, 1);


            previewGrid.Children.Add(styleImage);


        }

       





    }
}
