using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackChallenge_Repo
{
    //PLAYER CLASS
    public class Player
    {
        public int HandValue { get; set; }
        public bool Stand { get; set; }
        public int Turn { get; set; }

        public Player(int handvalue, bool stand)
        {
            HandValue = handvalue;
            Stand = stand;
            Turn = 0;
        }
    }

    //DEALER CLASS
    public class Dealer
    {
        public int OpenValue { get; set; }
        public int HidValue { get; set; }
        public bool Stand { get; set; }

        public Dealer(int openvalue, int hidvalue, bool stand)
        {
            OpenValue = openvalue;
            HidValue = hidvalue;
            Stand = stand;
        }
    }

    public class GameInfo
    {
        public bool Active { get; set; }

        public GameInfo(bool active)
        {
            Active = active;
        }
    }
}

    
