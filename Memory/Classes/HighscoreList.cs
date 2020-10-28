using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Memory.Classes
{
    public class HighscoreList
    {
        private static HighscoreList highscoreList;


        private List<Highscore> Highscores;


        private BinaryFormatter formatter;


        private const string DATA_FILENAME = "highscorelist.dat";


        public static HighscoreList Instance()
        {
            if (highscoreList == null)
            {
                highscoreList = new HighscoreList();
            }
            return highscoreList;
        }


        private HighscoreList()
        {
            this.Highscores = new List<Highscore>();
            this.formatter = new BinaryFormatter();
        }


        public void Save()
        {
            try
            {
                FileStream writeFileStream = new FileStream(DATA_FILENAME, FileMode.Create, FileAccess.Write);

                this.formatter.Serialize(writeFileStream, this.Highscores);

                writeFileStream.Close();
            }

            catch (Exception)
            {
                //popup small popup stating that the execution failed.
                MessageBox.Show("Save Failed :(");
            }
        }


        public void Load()
        {
            if (File.Exists(DATA_FILENAME))
            {
                try
                {
                    FileStream readerFileStream = new FileStream(DATA_FILENAME, FileMode.Open, FileAccess.Read);

                    this.Highscores = (List<Highscore>)this.formatter.Deserialize(readerFileStream);

                    readerFileStream.Close();
                }

                catch (Exception)
                {
                    MessageBox.Show("There is no SaveFile :(");
                }
            }
        }


        public void Addhighscore(Highscore highscore)
        {
            this.Highscores.Add(highscore);
        }


        public List<Highscore> GetList()
        {
            return this.Highscores;
        }
    }
}
