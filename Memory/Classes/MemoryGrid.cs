using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
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
using System.Xaml;
using System.Xml;
using Memory.Properties;

namespace Memory
{
    class MemoryGrid
    {
        private Grid grid;

        private int rows;
        private int cols;

        private List<ImageSource> images = new List<ImageSource>();
        private List<Image> bgImages = new List<Image>();

        private MemoryPage memoryPage;

        private Image firstCard;
        private Image secondCard;

        /// <summary>
        /// initializes the given values of grid, rows, cols, gamepage, firstcard and secondcard.
        /// calls initializeGameGrid(cols, rows);
        /// Puts new images or loads images in depending if loadGame is true.
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="cols"></param>
        /// <param name="rows"></param>
        /// <param name="backImages"></param>
        /// <param name="memoryPage"></param>
        /// <param name="loadGame"></param>
        /// <param name="firstCard"></param>
        /// <param name="secondCard"></param>
        public MemoryGrid(Grid grid, int cols, int rows, List<Image> backImages, MemoryPage memoryPage, bool loadGame, Image firstCard, Image secondCard)
        {
            this.rows = rows;
            this.cols = cols;
            this.grid = grid;
            this.memoryPage = memoryPage;
            this.firstCard = firstCard;
            this.secondCard = secondCard;
            InitializeMemoryGrid(cols, rows);
            if (loadGame)
            {
                LoadImages(backImages);
            }
            else
            {
                AddImages();
            }
        }
        ///<summary>
        /// return grid.
        /// </summary>
        /// <returns>grid</returns>
        public Grid GetGrid()
        {
            return grid;
        }

        ///<summary>
        /// Create a list of all images of the current theme, furthermore it randomizes it and returns the list.
        /// </summary>
        /// <returns>images</returns>
        private List<ImageSource> GetImageList()
        {
            for (int i = 0; i < (cols * rows); i++)
            {
                int imagenr = i % 8 + 1;
                ImageSource source = new BitmapImage(new Uri("Resource/Pictures/" + (string)Settings.Default["ThemeName"] + "/" + imagenr + ".png", UriKind.Relative));
                images.Add(source);

            }

            images = randomize(images);

            return images;

        }
        ///<summary>
        /// randomizes the given list <imageSource>
        /// </summary>
        /// <param name="imageSources"></param>
        /// <returns></returns>
        private List<ImageSource> randomize(List<ImageSource> imageSources)
        {
            Random random = new Random();
            for (int i = 0; i < (cols * rows); i++)
            {
                int r = random.Next(0, (rows + cols));
                ImageSource temp = imageSources[r];
                imageSources[r] = imageSources[r];
                imageSources[i] = temp;
            }

            return imageSources;
        }

        ///<summary>
        /// loads in images from GetImagesList and initializes all the images.
        /// </summary>
        private void AddImages()
        {
            images = GetImageList();
            int imageNumber = 0;
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < cols; column++)
                {
                    Image backgroundimage = new Image();
                    backgroundimage.Source = new BitmapImage(new Uri("Resource/Pictures/" + (string)Settings.Default["ThemeName"] + "/backimag.pgn", UriKind.Relative));
                    backgroundimage.Tag = images[imageNumber];
                    imageNumber++;
                    backgroundimage.DataContext = backgroundimage.Source;
                    backgroundimage.MouseDown += new MouseButtonEventHandler(memoryPage.cardclick);

                    /// hier eventueel animatie voor omdraaien kaart.
                    /// 
                    ///
                    ///
                    /// . kind of must have
                }
            }
        }
        /// <summary>
        ///  Randomize the given list <Image
        /// </summary>
        /// <param name="savedImages"></param>
        private void LoadImages(List<Image> savedImages)
        {
            int imageNumber = 0;
            // loop through all the rows and columns
            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < cols; column++)
                {
                    Image backgroundimage = savedImages[imageNumber];

                    // check up for any opened cards & show correct sources
                    if (backgroundimage.Tag.ToString() == firstCard.Source.ToString())
                    {
                        backgroundimage.Source = firstCard.Source;
                    }
                    else if (backgroundimage.Tag.ToString() == secondCard.Source.ToString())
                    {
                        backgroundimage.Source = secondCard.Source;
                    }
                    else
                    {
                        backgroundimage.Source = new BitmapImage(new Uri("Resource/Pictures/" + (string)Settings.Default["ThemeName"] + "/Backimag.png", UriKind.Relative));
                    }
                    backgroundimage.MouseDown += new MouseButtonEventHandler(memoryPage.cardclick);

                    backgroundimage.DataContext = new BitmapImage(new Uri("Resource/Pictures/" + (string)Settings.Default["ThemeName"] + "/Backimag.pgn", UriKind.Relative));

                    imageNumber++;

                    /// hier eventueel animatie voor omdraaien kaart.
                    /// 
                    ///
                    ///
                    /// . kind of must have
                }
            }

        }

        /// <summary>
        /// Add RowDefinition and ColumnDefinitions to the grid. The amount depends on the given cols and rows.
        /// </summary>
        /// <param name="cols"></param>
        /// <param name="rows"></param>
        private void InitializeMemoryGrid(int cols, int rows)
        {
            for (int i = 0; i < rows; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < cols; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
        }

        ///<summary>
        /// return background images
        /// </summary>
        /// < returns> bgImages </returns>
        public List<Image> getBgImages()
        {
            return bgImages;
        }
    }
}

