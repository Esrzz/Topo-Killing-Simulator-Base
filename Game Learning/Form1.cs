using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;




namespace Game_Learning
{
    public partial class Form1 : Form
    {
        int Countdown = 3;
        int Score = 0;
        int Time = 120;
        public Form1()
        {
            InitializeComponent();
        }

        private void LPlay_Click(object sender, EventArgs e)
        {
            Countdown = 3;
            Time= 120;
            Score = 0;
            LPlay.Visible = false;
            LTitulo.Visible = false;
            LCountdown.Visible = true;
            LCountdown.Text = Countdown.ToString();
            timer1.Start();
            LTime.Text = "Tiempo: " + Time.ToString();
            LScore.Text = "Score: 0";
            PBTopo1.Image = Properties.Resources.agujero;
            PBTopo2.Image = Properties.Resources.agujero;
            PBTopo3.Image = Properties.Resources.agujero;
            PBTopo4.Image = Properties.Resources.agujero;
            PBTopo5.Image = Properties.Resources.agujero;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Countdown >= 0) { 
                LCountdown.Text = Countdown.ToString();
                Countdown--;
            }
            if (Countdown < 0)
            {
             LCountdown.Visible = false;
             timer1 .Stop();
                PBTopo1.Visible = true;
                PBTopo2.Visible = true;
                PBTopo3.Visible = true;
                PBTopo4.Visible = true;
                PBTopo5.Visible = true;
                BaseTick.Start();
                TimeForKillingTopos.Start();
                LTime.Visible = true;
                LScore.Visible = true;
            }
            
        }

        private void BaseTick_Tick(object sender, EventArgs e)
        {
            PBTopo1.Image = Properties.Resources.agujero;
            PBTopo2.Image = Properties.Resources.agujero;
            PBTopo3.Image = Properties.Resources.agujero;
            PBTopo4.Image = Properties.Resources.agujero;
            PBTopo5.Image = Properties.Resources.agujero;
            Random rd = new Random();
            int rand_num = rd.Next(1,6) ;
            if (Time > 100)
            {
                BaseTick.Interval = 1000;
            }
            if (Time < 100)
            {
                BaseTick.Interval = 750;
            }
            if (Time < 60)
            {
                BaseTick.Interval = 500;
            }
            if (Time < 30)
            {
                BaseTick.Interval = 275;
            }
            if (Time < 10)
            {
                BaseTick.Interval = 185;
            }

            if (rand_num==1)
            {
                PBTopo1.Image = Properties.Resources.aparece_topo;
                PBTopo1.Enabled= true;
            }
            if (rand_num == 2)
            {
                PBTopo2.Image = Properties.Resources.aparece_topo;
                PBTopo2.Enabled = true;
            }
            if (rand_num == 3)
            {
                PBTopo3.Image = Properties.Resources.aparece_topo;
                PBTopo3.Enabled = true;
            }
            if (rand_num == 4)
            {
                PBTopo4.Image = Properties.Resources.aparece_topo;
                PBTopo4.Enabled = true;
            }
            if (rand_num == 5)
            {
                PBTopo5.Image = Properties.Resources.aparece_topo;
                PBTopo5.Enabled = true;
            }
        }

        private void PBTopo1_Click(object sender, EventArgs e)
        {
            Score++;
            LScore.Text = "Score: " + Score.ToString();
            PBTopo1.Image = Properties.Resources.mareado;
            PBTopo1.Enabled = false;
        }

        private void PBTopo2_Click(object sender, EventArgs e)
        {
            Score++;
            LScore.Text = "Score: " + Score.ToString();
            PBTopo2.Image = Properties.Resources.mareado;
            PBTopo2.Enabled = false;
        }

        private void PBTopo3_Click(object sender, EventArgs e)
        {
            Score++;
            LScore.Text = "Score: " + Score.ToString();
            PBTopo3.Image = Properties.Resources.mareado;
            PBTopo3.Enabled = false;
        }

        private void PBTopo5_Click(object sender, EventArgs e)
        {
            Score++;
            LScore.Text = "Score: " + Score.ToString();
            PBTopo5.Image = Properties.Resources.mareado;
            PBTopo5.Enabled = false;
        }

        private void PBTopo4_Click(object sender, EventArgs e)
        {
            Score++;
            LScore.Text = "Score: " + Score.ToString();
            PBTopo4.Image = Properties.Resources.mareado;
            PBTopo4.Enabled = false;
        }

        private void TimeForKillingTopos_Tick(object sender, EventArgs e)
        {
            Time--;
            LTime.Text= "Tiempo: "+ Time.ToString();
            if(Time < 0)
            {
                BaseTick.Stop();
                PBTopo1.Visible = false;
                PBTopo2.Visible = false;
                PBTopo3.Visible = false;
                PBTopo4.Visible = false;
                PBTopo5.Visible = false;
                PBTopo1.Enabled = false;
                PBTopo2.Enabled = false;
                PBTopo3.Enabled = false;
                PBTopo4.Enabled = false;
                PBTopo5.Enabled = false;
                LTitulo.Visible = true;
                LTime.Visible = false;
                LScore.Visible = false;
                LTitulo.Text = "Your Score is :" + Score.ToString();
                LPlay.Visible = true;
                LPlay.Text = "Retry?";
                TimeForKillingTopos.Stop();

            }
        }

        private void LScore_Click(object sender, EventArgs e)
        {

        }
    }
}
