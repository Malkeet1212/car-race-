using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrace
{
    class Bet
    {
        public int cash;
        public int car;
        public racer bettor;

      
        public string Getboard()//it is for the lables to display the bet to user
        {
            if(cash > 0) return bettor.name + " bets " + cash + " dollars on car #" + car;
            return bettor.name + " hasn't placed a bet";
        }
        public Bet(racer bet2)
        {
            bettor = bet2;
        }
        public int PayOut(int winner)//it is for money to update after winning
        {
            if (car == winner) return cash;
            return -cash;
        }
    }
}
