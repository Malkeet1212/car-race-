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
        int miniBet = 5;//it is the minimum bet
        racer[] racers = new racer[3];
        Bettor[] bett = new Bettor[4];
        Random myRandomizer = new Random();
        
    public maingame()
        {
            InitializeComponent();
            SetupRaceTrack();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < bett.Length; i++)//it is a for loop for the timer
            {
                if (bett[i].Race())
                {
                    EndRace(i);
                    break;
                }
            }

        }
        void StartRace()
        {
            timer1.Interval = 50;//it sets the time interval
            timer1.Start();
        }

        private void Racebtn_Click(object sender, EventArgs e)
        {
            StartRace();//it is calling the starrace function
            racebtn.Enabled = false;
        }

        private void betbtn_Click(object sender, EventArgs e)//its the fuction used for beeting
        {
            if (playerrb1.Checked)
            {
                racers[0].Bets((int)betupdown.Value, (int)carupdown.Value);
                racers[0].UpdateLb();
            }
            if (playerrb2.Checked)
            {
                racers[1].Bets((int)betupdown.Value, (int)carupdown.Value);
                racers[1].UpdateLb();
            }
            if (playerrb3.Checked)
            {
                racers[2].Bets((int)betupdown.Value, (int)carupdown.Value);
                racers[2].UpdateLb();
            }
        }

       


        public void EndRace(int winnercar)//fuction which stop the race
        {
            timer1.Stop();
            timer1.Dispose();
            MessageBox.Show("The First Position is car no " + winnercar);//its is for the message pop up
            foreach (var guy in racers)
            {
                guy.win(winnercar);
            }
            foreach (var bike in bett)
            {
                bike.start();
            }
            racebtn.Enabled = true;
        }
        public void SetupRaceTrack()
        {
            bett[0] = new Bettor()
            {
                myPictureBox = carPB1,
                starting = raceTrackPictureBox.Left,
                raceLength = raceTrackPictureBox.Width - carPB1.Width,
                rando = myRandomizer
            };
            bett[1] = new Bettor()
            {
                myPictureBox = carPB2,
                starting = raceTrackPictureBox.Left,
                raceLength = raceTrackPictureBox.Width - carPB2.Width,
                rando = myRandomizer
            };
            bett[2] = new Bettor()
            {
                myPictureBox = carPb3,
                starting = raceTrackPictureBox.Left,
                raceLength = raceTrackPictureBox.Width - carPb3.Width,
                rando = myRandomizer
            };
            bett[3] = new Bettor()
            {
                myPictureBox = carpb4,
                starting = raceTrackPictureBox.Left,
                raceLength = raceTrackPictureBox.Width - carpb4.Width,
                rando = myRandomizer
            };


            racers[0] = new racer("gill", 50, playerrb1, player1Label);//it is setting the player name and their money
            racers[1] = new racer("askarn", 50, playerrb2, player2Label);
            racers[2] = new racer("simer", 50, playerrb3, player3Label);

            foreach (var guy in racers)
            {
                guy.Bets(0, 0);
                guy.UpdateLb();
            }
            minimumBetLabel.Text = "Minimum bet: " + miniBet + " bucks";
            betupdown.Minimum = miniBet;
        }
       

        private void carUpDown_ValueChanged(object sender, EventArgs e)
        {

        }

        private void playerrb3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void playerrb1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void player2Label_Click(object sender, EventArgs e)
        {

        }

        private void playerrb2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
