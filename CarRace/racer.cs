using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    class racer
    {
        public int cash;
        public RadioButton myrb;
        public Label Mylb;
        public string name;
        public Bet Bet;
        

      


        public void ClearBet()//it is to clear bet
        {
            Bet.cash = 0;
        }
        public racer(string name1, int cash1, RadioButton btn, Label lb)//it is to get the varables
        {
            name = name1;
            cash = cash1;
            myrb = btn;
            Mylb = lb;
            Bet = new Bet(this);
        }
        public bool Bets(int betCash, int Winracer)
        {
            Bet.cash = betCash;
            Bet.car = Winracer;
            if (cash >= betCash) return true;
            return false;
        }

        public void UpdateLb()//update for the lables
        {
            Mylb.Text = Bet.Getboard();
            myrb.Text = name + " has " + cash + " bucks";
        }
        public void win(int winner)// for the winner
        {
            cash += Bet.PayOut(winner);
            ClearBet();
            UpdateLb();
        }
    }
}
