using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamGames;

//add this comment

namespace TeamGames
{
    public class Game
    {
        public string teamOne { get; set; }

        public string teamTwo { get; set; }

        public int teamOneScore { get; set; }

        public int teamTwoScore { get; set; }

        public Game() { }

        public Game(string teamOne, string teamTwo, int teamOneScore, int teamTwoScore)
        {
            this.teamOne = teamOne;
            this.teamTwo = teamTwo;
            this.teamOneScore = teamOneScore;
            this.teamTwoScore = teamTwoScore;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) - {2} ({3})", teamOne, teamOneScore, teamTwo, teamTwoScore);
        }
    }
}
