using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Memory.Properties;
using Memory.Classes;

namespace Memory
{
    /// <summary>
    /// Interaction logic for MemoryPage.xaml
    /// </summary>
    public partial class MemoryPage : Page
    {
        private MemoryGrid grid;
        private const int nr_cols = 4;
        private const int nr_rows = 4;
        private int cardsOpen;
        private string player1;
        private string player2 = "";
        private string currentPlayer;


        private Image firstCard;
        private Image secondCard;
        private List<Image> bgImages = new List<Image>();
        private int player1Score;
        private int player2Score;
        private bool singleplayer;

        private HighscoreList highscoreList = HighscoreList.Instance();

        private DispatcherTimer clock = new DispatcherTimer();
        private bool clockInstance;
        public int TotalTime;

        private int singlePlayerScore;
        private int singlePlayerCombo;

        /// <summary>
        /// Blanc constructor
        /// </summary>
        public MemoryPage()
        {
            InitializeComponent();
        }

        ///<summary>
        /// Sets up the player1, singleplayer, txtBeurtNaam.Text, currentPlayer & creates a grid by calling MemoryGrid.
        /// </summary>
        /// <param name="player1"></param>
        public MemoryPage(string player1)
        {
            InitializeComponent();
            this.player1 = player1;

            singleplayer = true;

            txtBeurtNaam.Text = player1;
            lblScore2.Content = "";
            currentPlayer = player1;

            grid = new MemoryGrid(GameGrid, nr_cols, nr_rows, bgImages, this, false, firstCard, secondCard);

            bgImages = grid.getBgImages();
        }

        ///<summary>
        /// Sets up the player1, player2, singleplayer, txtBeurtNaam.Text, currentPlayer & creates a grid by calling MemoryGrid.
        /// </summary>
        /// <param name="Player1"></param>
        /// <param name="player2"></param>
        public MemoryPage(string player1, string player2)
        {
            InitializeComponent();
            this.player1 = player1;
            this.player2 = player2;

            singleplayer = false;

            txtBeurtNaam.Text = player1;
            lblScore1.Content = player1Score.ToString();
            lblScore2.Content = player2Score.ToString();
            txtScore_1.Text = player1;
            txtScore_2.Text = player2;

            currentPlayer = player1;
            grid = new MemoryGrid(GameGrid, nr_cols, nr_rows, bgImages, this, false, firstCard, secondCard);

            bgImages = grid.getBgImages();
        }

        ///<summary>
        /// Contructor to load in a saved game.
        /// </summary>
        /// <param name="loadGame"></param>
        public MemoryPage(bool loadGame)
        {
            InitializeComponent();
            if (loadGame)
            {
                // loads the Current Save file and sets the Variables.
                this.loadGame();
                txtBeurtNaam.Text = currentPlayer;
                grid = new MemoryGrid(GameGrid, nr_cols, nr_rows, bgImages, this, false, firstCard, secondCard);

                bgImages = grid.getBgImages();
                SetCards();
            }
        }

        /// <summary>
        /// The instance Page_load created and on page_loaded the if-else statement is created where it will ask if the timer is already created or not.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
          public void Page_loaded(object sender, RoutedEventArgs e)
        {
            // if starting value is false initialize the timer
            if (clockInstance == false)
            {
                clock.Interval = TimeSpan.FromSeconds(1);
                clock.Tick += TimeTicker;
                clock.Start();
                clockInstance = true;
            }    
            else // resume time
            {
                clock.Start();
            }
        }


        /// <summary>
        /// creates the indicator of how much the timer is on
        /// TimeTickers creates the development of how the value of Totaltime is increased
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void TimeTicker(object sender, EventArgs e)
        {
            TotalTime++;
            Timerlabel.Content = TotalTime.ToString();
        }

        /// <summary>
        /// Navigates to pausepage and stops the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Pauzebtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PausePage(this));
            // puts a stop on the timer.
            clock.Stop();
        }

        /// <summary>
        /// Updates the current player textbox with given string
        /// </summary>
        /// <param name="newPlayer"></param>
        public void UpdatePlayer(string newPlayer)
        {
            txtBeurtNaam.Text = newPlayer;
        }


        /// <summary>
        /// Creates BitmapImage from string
        /// </summary>
        /// <param name="StringPath"></param>
        /// <returns></returns>
        private BitmapImage stringToBitMap(string stringpath)
        {
            Uri imageUri = new Uri("about:blank");
            try
            {
                imageUri = new Uri(stringpath, UriKind.Relative);
            }
            catch
            {
                imageUri = new Uri(stringpath);
            }
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            return imageBitmap;
        }


        
        SoundPlayer FlipSound = new SoundPlayer(@"../../Resource/music/cardflip.wav");
        SoundPlayer WinSound = new SoundPlayer(@"../../Resource/music/win.wav");
        SoundPlayer FailSound = new SoundPlayer(@"../../Resource/music/fail.wav");
        
        ///<summary>
        /// handles the click event of cards.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cardclick(object sender, MouseButtonEventArgs e)
        {
            Image card = (Image)sender;

            card.Tag = stringToBitMap(card.Tag.ToString());

            ImageSource front = (ImageSource)card.Tag;
            ImageSource back = (ImageSource)card.DataContext;

            if (firstCard != card && secondCard != card)
            {
                runCardClickEvents(card, front, back);
            }
            else if (firstCard.Source != card.Source && secondCard.Source != card.Source)
            {
                runCardClickEvents(card, front, back);
            }
        }

        ///<summary>
        ///Plays the corresponding sound, flips the card and Checks for winner
        /// </summary>
        /// <param name="card"></param>
        /// <param name="front"></param>
        /// <param name="back"></param>
        private void runCardClickEvents(Image card, ImageSource front, ImageSource back)
        {
            if ((bool)Settings.Default["sound"])
            {
                
                WinSound.Stop();
                FailSound.Stop();
                FlipSound.Play();
                 
            }

            if (cardsOpen == 2)
            {
                FlipCards(card, front, back);
                cardsOpen = 0;
            }
            
            if (firstCard == null || firstCard == secondCard)
            {
                firstCard = card;
            }

            else if (firstCard.Tag.ToString() == "")
            {
                firstCard = card;
            }

            else
            {
                secondCard = card;
            }

            card.Source = front;
            cardsOpen++;
            if (cardsOpen == 2 && !singleplayer && firstCard.Tag.ToString() != secondCard.Tag.ToString())
            {
                if ((bool)Settings.Default["Sound"])
                {
                    
                    FlipSound.Stop();
                    FailSound.Play();
                    
                }
                currentPlayer = (currentPlayer == player1) ? player2 : player1;
                UpdatePlayer(currentPlayer);
            }

            //soundeffect if you have an equal set of cards
            else if (cardsOpen == 2 && firstCard.Source.ToString() == secondCard.Tag.ToString())
            {
                if ((bool)Settings.Default["Sound"])
                {
                    
                    FlipSound.Stop();
                    WinSound.Play();
                    
                }
                // adds a point to score and combo meter
                UpdateScore();
                singlePlayerCombo++;


            }


            //soundeffect if you have an unequal set of cards
            else if (cardsOpen == 2 && firstCard.Source.ToString() != secondCard.Tag.ToString())
            {
                if ((bool) Settings.Default["sound"])
                {
                    
                    FlipSound.Stop();
                    FailSound.Play();
                    
                }
                // resets combometer
                singlePlayerCombo = 0;
            }

            //UpdateScore();

            if (cardsOpen == 2 && CheckWinner())
            {
                FlipCards(card, front, back);
                MessageBox.Show(GameWinner());
                NavigationService.Navigate(new WelkomPage());

            }   
        }

        ///<summary>
        /// Flips the card(s) depending on which card is clicked, What cards are open & sets the card source and tage
        /// </summary>
        /// <param name="card"></param>
        /// <param name="front"></param>
        /// <param name="back"></param>
        private void FlipCards(Image card, ImageSource front, ImageSource back)
        {
            if (firstCard.Tag.ToString() != secondCard.Tag.ToString())
            {
                foreach (var img in bgImages)
                {
                    if (img.Tag != null && img.Tag != "" && img.Source != null && img.Source != back)
                    {
                        img.Source = back;
                    }
                }
                firstCard.Source = back;
                secondCard.Source = back;
            }
            else
            {
                foreach (Image img in bgImages)
                {
                    if(img.Tag != null && img.Tag != "" && img.Source != null && img.Source != back)
                    {
                        if (firstCard.Source.ToString() == img.Tag.ToString())
                        {
                            img.Tag = null;
                            img.Source = null;
                        }
                        else if (secondCard.Source.ToString() == img.Tag.ToString())
                        {
                            img.Tag = null;
                            img.Source = null;
                        }
                    }
                }
                firstCard.Source = null;
                secondCard.Source = null;
                firstCard.Source = null;
                secondCard.Source = null;
            }

            firstCard = null;
            secondCard = null;
        }

        ///<summary>
        ///removes MouseButtonEventHandler from images where tag is empty
        ///</summary>
        private void SetCards()
        {
            foreach (Image img in bgImages)
            {
                if (img.Tag == "")
                {
                    img.Source = null;
                    img.MouseDown -= new MouseButtonEventHandler(this.cardclick);
                }
            }    
        }

        ///<summary>
        /// Use when there is a winner.
        /// If singleplayer check highest score and returns winner.
        /// If not add user score into the highscores and return the user's score.
        /// </summary>
        /// <returns>string</returns>
        private string GameWinner()
        {
            if (!singleplayer)
            {
                string winner;
                if (player1Score > player2Score)
                {
                    winner = player1;
                }
                else if (player1Score < player2Score)
                {
                    winner = player2;
                }
                else
                {
                    return "Gelijkspel!";
                }
                return winner + "heeft gewonnen!";
            }
            else
            {
                SubmitScore(this.player1, this.player1Score, this.singlePlayerCombo, this.TotalTime);

                return "u heeft het spel voltooid met een score van: " + singlePlayerScore;
            }
        }

        /// <summary>
        /// used to submit highscore of the player
        /// </summary>
        /// <param name="playername"> string name of  the playername</param>
        /// <param name="score"> string name of the score</param>
        /// <param name="clock"> string of the timer</param>
        private void SubmitScore(string playername, int score, int combo, int clock)
        {
            int minutes = clock / 60;
            string seconds = (clock % 60).ToString();

            if (Int32.Parse(seconds) < 10)
            {
                seconds = "0" + seconds;
            }

            string time = minutes + " : " + seconds;

            singlePlayerScore += score * combo / (1 + minutes);


            highscoreList.AddHighscore(new Highscore(playername, singlePlayerScore, time));
            highscoreList.Save();
        }

        /// <summary>
        /// updates the score of the current player if a card is flipped
        /// </summary>
        private void UpdateScore()
        {
            if (!singleplayer && cardsOpen == 2 && firstCard.Tag.ToString() == secondCard.Tag.ToString())
            {
                if (currentPlayer == player1)
                {
                    player1Score++;
                }
                else
                {
                    player2Score++;
                }
                lblScore1.Content = player1Score.ToString();
                lblScore2.Content = player2Score.ToString();
            }
            else if(singleplayer)
            {
                this.player1Score++;
                txtScore_1.Text = player1Score.ToString();
            }
        }

        /// <summary>
        /// Checks if there is a winner by reading in all the flipped cards. If they are all flipped return true
        /// </summary>
        /// <returns>true/false</returns>
        private bool CheckWinner()
        {
            int imagesFlipped = 0;
            int imagesFlipped2 = 0;
            bgImages.ForEach(delegate (Image img)
            {
                imagesFlipped2++;
                if (img.Tag == null || img.Tag == "")
                {
                    imagesFlipped++;
                }
            });

            if (imagesFlipped == (nr_cols * nr_rows) - 2)
            {
                return true;
            }

            return false;
        }

        ///<summary>
        /// checks if there is a winner by reading in all the flipped cards. If they are all flipped return true.
        /// </summary>
        /// <returns>true/false</returns>
        public void SaveGamePage()
        {
            //saves the MemoryPage
            TextWriter tw = new StreamWriter("memory.sav");
            tw.WriteLine(cardsOpen);
            tw.WriteLine(player1);
            tw.WriteLine(player2);
            tw.WriteLine(currentPlayer);
            if (firstCard == null)
            {
                firstCard = new Image();
                tw.WriteLine();
            }   
            else
            {
                tw.WriteLine(secondCard.Tag.ToString());
            }
            tw.WriteLine(player1Score);
            tw.WriteLine(player2Score);
            tw.WriteLine(singleplayer);
            tw.WriteLine(TotalTime);
            tw.WriteLine(singlePlayerScore);

            // Loops trough all the bgImages and writes them as individual lines in memory.sav
            foreach (var bg in bgImages)
            {
                tw.WriteLine(bg.Tag);
            }
            tw.Close();
        }

        ///<summary>
        /// Reads all the lines from memory.sav and loads them into all the variables
        /// </summary>
        public void loadGame()
        {
            firstCard = new Image();
            secondCard = new Image();

            TextReader tr = new StreamReader("memory.sav");

            cardsOpen = Convert.ToInt32(tr.ReadLine());
            player1 = tr.ReadLine();
            player2 = tr.ReadLine();
            currentPlayer = tr.ReadLine();

            var card1 = (string)tr.ReadLine();
            var card2 = (string)tr.ReadLine();
            firstCard.Tag = stringToBitMap(card1);
            secondCard.Tag = stringToBitMap(card2);
            firstCard.Source = stringToBitMap(card1);
            secondCard.Source = stringToBitMap(card2);
            firstCard.DataContext = new BitmapImage(new Uri("Resource/Themes/" + (string)Settings.Default["ThemeName"] + "/backimag", UriKind.Relative));
            secondCard.DataContext = new BitmapImage(new Uri("Resource/Themes/" + (string)Settings.Default["ThemeName"] + "/backimag", UriKind.Relative));

            player1Score = Convert.ToInt32(tr.ReadLine());
            player1Score = Convert.ToInt32(tr.ReadLine());
            singleplayer = Convert.ToBoolean(tr.ReadLine());
            TotalTime = Convert.ToInt32(tr.ReadLine());
            singlePlayerScore = Convert.ToInt32(tr.ReadLine());

            // loops through all the bgImages, reads the lines and adds them to bgImages.
            using (tr)
            {
                for (int i = 0; i < (nr_cols * nr_rows); i++)
                {
                    Image readImage = new Image();
                    readImage.Tag = tr.ReadLine();
                    // all the images need to be unique and you can't name it to just a number so we added a letter.
                    readImage.Name = "x" + i;
                    bgImages.Add(readImage);
                }
            }

            tr.Close();
        }

    }

}
