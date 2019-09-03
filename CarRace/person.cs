using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    //coding for picture class
    public class person
    {
        public PictureBox CARPITURE;
        public int CARSTART;
        public int CARRACE;
        public int POSTION;
        public Random RANDOM;


        //coding for go class
        public void go()
        {
            this.CARPITURE.Left = 0;
            this.POSTION = 0;
        }
        //coding for raceing class
        public bool Raceing()
        {
            POSTION = RANDOM.Next(5);
            CARPITURE.Left += CARSTART + POSTION;

            if (CARPITURE.Left >= CARRACE)
                return true;

            return false;
        }
        

       
    }
}
