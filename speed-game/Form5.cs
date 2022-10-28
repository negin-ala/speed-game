using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;


namespace WindowsFormsApplication26
{
    public partial class Form5 : Form
    {
        int cntdn=0;
        int pcnt = 0;
        int scnt = 0;
       
        public int score;
        public Form5()
        {
            InitializeComponent();
            
        }

        public Form5(bool sound, string level,string name)
        {
            
            InitializeComponent();
            if(sound==true)
            lblf5sound.Text ="sound ON";
            else
                lblf5sound.Text = "sound OFF";
            lblf5level.Text = level;
            if (sound == true)
                axWindowsMediaPlayer3.URL = "Media\\30_Second-2020-05-27_-_Circus_Calliope_-_www.FesliyanStudios.com_Steve_Oxen.mp3";
            lblf5username.Text=name;
            switch (level)
            {
                case "Beginner":
                    {
                        timer2.Enabled = true;
                        timer1.Enabled = false;
                        timer5.Enabled = false;
                    }
                    break;

                case "Master":
                    {
                        timer2.Enabled = false;
                        timer1.Enabled = true;
                        timer5.Enabled = false;
                    }
                    break;

                case "Ultimate":
                    {
                        timer2.Enabled = false;
                        timer1.Enabled = false;
                        timer5.Enabled = true;
                    }
                    break;
            }

        }
        private void Form5_Load(object sender, EventArgs e)
        {
            countdown.Enabled = true;
            timer30.Enabled = true;
            txtusscore.Text = "0";

        }


        private void timer30_Tick(object sender, EventArgs e)
        {

          
            timer30.Enabled = false;
            timer2.Enabled = false;
            timer5.Enabled = false;
            timer1.Enabled = false;
            countdown.Enabled = false;

            pbface.Visible = false;
            pbface2.Visible = false;
            pbface3.Visible = false;
            //score = Convert.ToInt32(txtusscore.Text);
            pbgameover.Visible = true;
            axWindowsMediaPlayergameover.URL = "Media\\gameover.mp3";
            DialogResult dr = new DialogResult();
            dr = MessageBox.Show(txtusscore.Text + "  is your score");
            if (dr == DialogResult.OK)
            {
               
                this.Close();
            }

        }

        
        private void timer2_Tick(object sender, EventArgs e)
        {
            pbface.Visible = true;
            pbface2.Visible = false;
            pbface3.Visible = false;
            Random randloc = new Random();

            Point pt = new Point(int.Parse(randloc.Next(this.Width).ToString()), int.Parse(randloc.Next(this.Height).ToString()));
            pbface.Location = pt;
        }
        private void pbface_MouseClick_1(object sender, MouseEventArgs e)
        {
            pcnt++;
            axWindowsMediaPlayer2.URL = "Media\\PUNCH.mp3";
            if (pcnt == 1)
                pbface.Image = Image.FromFile("Media\\exhastedfaceresized.jpg");
            else if (pcnt == 2)
                pbface.Image = Image.FromFile("Media\\redeyefaceresized.jpg");
            else if (pcnt == 3)
            {
                pcnt = 0;
                pbface.Image = Image.FromFile("Media\\fatsneakyresized.jpg");
                scnt++;
                txtusscore.Text = scnt.ToString();
                axWindowsMediaPlayerboom.URL = "Media\\Enfejar-12.mp3";
            }
        }
      private void timer1_Tick(object sender, EventArgs e)
        {
            pbface2.Visible = true;
            pbface3.Visible = false;
            pbface.Visible = false;
            Random randloc = new Random();

            Point pt = new Point(int.Parse(randloc.Next(this.Width).ToString()), int.Parse(randloc.Next(this.Height).ToString()));
            pbface2.Location = pt;
        }

        private void pbface2_Click(object sender, EventArgs e)
        {
            pcnt++;
            axWindowsMediaPlayer2.URL = "Media\\PUNCH.mp3";
            if (pcnt == 1)
                pbface2.Image = Image.FromFile("Media\\stressed_outresized.png");
            else if (pcnt == 2)
                pbface2.Image = Image.FromFile("Media\\sadfaceresize.jpg");
            else if (pcnt == 3)
            {
                pcnt = 0;
                pbface2.Image = Image.FromFile("Media\\happysneakyfaceresized.jpg");
                scnt++;
                txtusscore.Text = scnt.ToString();
                axWindowsMediaPlayerboom.URL = "Media\\Enfejar-12.mp3";
            }
        }
      private void timer5_Tick(object sender, EventArgs e)
        {
            pbface3.Visible = true;
            pbface2.Visible = false; 
            pbface.Visible = false;
            Random randloc = new Random();

            Point pt = new Point(int.Parse(randloc.Next(this.Width).ToString()), int.Parse(randloc.Next(this.Height).ToString()));
            pbface3.Location = pt;

        }
        private void pbface3_Click(object sender, EventArgs e)
        {
            pcnt++;
            axWindowsMediaPlayer2.URL = "Media\\PUNCH.mp3";
            if (pcnt == 1)
                pbface3.Image = Image.FromFile("Media\\angryfaceresized.jpg");
            else if (pcnt == 2)
                pbface3.Image = Image.FromFile("Media\\cryingresized.png");
            else if (pcnt == 3)
            {
                pcnt = 0;
                pbface3.Image = Image.FromFile("Media\\eyebrowfaceresized.jpg");
                scnt++;
                txtusscore.Text = scnt.ToString();
                axWindowsMediaPlayerboom.URL = "Media\\Enfejar-12.mp3";
            }
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            score = Convert.ToInt32(txtusscore.Text);
            timer30.Stop();
        }

        private void countdown_Tick(object sender, EventArgs e)
        {
            cntdn++;
            lbltime.Text = (30 - cntdn).ToString();
        }
    }
}