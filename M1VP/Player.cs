using System;
using System.Collections.Generic;
using System.Text;

namespace M1VP
{
    public class Player
    {
        public string username { get; set; }
        public string password { get; set; }
        public string captainName { get; set; }
        public string gender { get; set; }
        public int score { get; set; }
        public int doubleScore { get; set; }
        public int win { get; set; }
        public int lose { get; set; }

        public Player(string username, string password, string captainName, string gender, int score, int doubleScore)
        {
            this.username = username;
            this.password = password;
            this.captainName= captainName;
            this.gender = gender;
            this.score = score;
            this.doubleScore = doubleScore;
            this.win = 0;
            this.lose = 0;
        }
    }
}
