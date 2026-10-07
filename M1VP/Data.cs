using System;
using System.Collections.Generic;
using System.Text;

namespace M1VP
{
    public class Data
    {
        public List<Player> ListPlayer { get; set; }
        public Player CurrentPlayer { get; set; }
        public Player EnemyPlayer { get; set; }

        public Data()
        {
            ListPlayer = new List<Player>();
            CurrentPlayer = null;
            EnemyPlayer = null;
        }
    }
}
