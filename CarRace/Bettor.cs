using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    public class Bettor
    {
        public PictureBox myPictureBox;
        public int pos;
        public Random rando;
        public int starting;
        public int raceLength;
      

        public bool Race()//its is for the moving piturebox
        {
            pos = rando.Next(5);
            myPictureBox.Left += starting + pos;

            if (myPictureBox.Left >= raceLength)
                return true;

            return false;
        }
        public void start()//its is for the start
        {
            this.myPictureBox.Left = 0;
            this.pos = 0;
        }

       
    }
}
