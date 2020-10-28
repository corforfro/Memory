using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory.Classes
{
    /// <summary>
    /// Highscore object used after the memory game is over to set up & store the players data.
    /// </summary>
    [Serializable]
    public class Highscore
    {
        ///<summary>
        /// Name of the player
        /// </summary>
        public string Name { get; set; }
        ///<summary>
        /// Score of the player
        /// </summary>
        public int Score { get; set; }
        ///<summary>
        /// Time of the duration within the game
        /// </summary>
        public string Time { get; set; }

        ///<summary>
        /// class used to store the data in
        /// </summary>
        /// <param name="Name"> String of the players name. </param>
        /// <param name="Score"> int of the score achieved. </param>
        /// <param name="Name"> String of the time the game took. </param>
        public Highscore(string Name, int Score, string Time)
        {
            this.Name = Name;
            this.Score = Score;
            this.Time = Time;
        }
    }
}
