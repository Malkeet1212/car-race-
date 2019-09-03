using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrace
{
    public partial class maingame : Form
    {
        RACERS[] OBJCARS = new RACERS[3];
        person[] OBJPERSONS = new person[4];
        Random Rand = new Random();
        
    public maingame()
        {
            InitializeComponent();
            Track();
        }
        public void RACEEND(int FIRSTWINNER)
        {
            timer1.Stop();
            timer1.Dispose();
            MessageBox.Show("THE CAR NO THAT WON IS " + FIRSTWINNER);
            foreach (var guy in OBJCARS)
            {
                guy.CARWINNER(FIRSTWINNER);
            }
            foreach (var bike in OBJPERSONS)
            {
                bike.go();
            }
            Gobtn.Enabled = true;
        }
        public void Track()
        {
            OBJPERSONS[0] = new person()
            {
                CARPITURE = car1,
                CARSTART = racePB.Left,
                CARRACE = racePB.Width - car1.Width,
                RANDOM = Rand
            };
            OBJPERSONS[1] = new person()
            {
                CARPITURE = car2,
                CARSTART = racePB.Left,
                CARRACE = racePB.Width - car2.Width,
                RANDOM = Rand
            };
            OBJPERSONS[2] = new person()
            {
                CARPITURE = car3,
                CARSTART = racePB.Left,
                CARRACE = racePB.Width - car3.Width,
                RANDOM = Rand
            };
            OBJPERSONS[3] = new person()
            {
                CARPITURE = car4,
                CARSTART = racePB.Left,
                CARRACE = racePB.Width - car4.Width,
                RANDOM = Rand
            };


            OBJCARS[0] = new RACERS("JHON", 50, JHONRABS, JHONLBS);
            OBJCARS[1] = new RACERS("LIND", 50, LINDRBS, LINDLBS);
            OBJCARS[2] = new RACERS("ZACK", 50, ZACKRBS, ZACKLBS);

            foreach (var racer in OBJCARS)
            {
                racer.BETAMOUNT(0, 0);
                racer.LABELSUPDATESCAR();
            }
            minimumBetLabel.Text = "Minimum bet is " + 1 + " bucks";
            betplaceud.Minimum = 1;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < OBJPERSONS.Length; i++)
            {
                if (OBJPERSONS[i].Raceing())
                {
                    RACEEND(i);
                    break;
                }
            }

        }
        void Raceing()
        {
            timer1.Interval = 50;
            timer1.Start();
        }

        private void Racerbtn_Click(object sender, EventArgs e)
        {
            Raceing();
            Gobtn.Enabled = false;
        }

        private void beterbtn_Click(object sender, EventArgs e)
        {
            if (JHONRABS.Checked)
            {
                OBJCARS[0].BETAMOUNT((int)betplaceud.Value, (int)Racerud.Value);
                OBJCARS[0].LABELSUPDATESCAR();
            }
            if (LINDRBS.Checked)
            {
                OBJCARS[1].BETAMOUNT((int)betplaceud.Value, (int)Racerud.Value);
                OBJCARS[1].LABELSUPDATESCAR();
            }
            if (ZACKRBS.Checked)
            {
                OBJCARS[2].BETAMOUNT((int)betplaceud.Value, (int)Racerud.Value);
                OBJCARS[2].LABELSUPDATESCAR();
            }
        }

        private void rbSam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Betplaceud_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Racerud_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
