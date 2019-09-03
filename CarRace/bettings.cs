using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrace
{
    //coding for betting class
    class BETTING
    {
        public int MONEY;
        public int CARS;
        public RACERS PLAYERBETS;

        //coding for race finish class
        public int RACEFINISH(int WINNER)
        {
            if (CARS == WINNER) return MONEY;
            return -MONEY;
        }
        //coding for players bet class
        public string PAcedbet()
        {
            if(MONEY > 0) return PLAYERBETS.RACERNAME + " BETS " + MONEY + " ON CAR " + CARS;
            return PLAYERBETS.RACERNAME + " has not placed a bet";
        }
        public BETTING(RACERS bets)
        {
            PLAYERBETS = bets;
        }
       
    }
}
