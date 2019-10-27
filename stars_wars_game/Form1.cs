using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace stars_wars_game
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer gamemedia;
        WindowsMediaPlayer shotsmedia;
        WindowsMediaPlayer explo;

        PictureBox[] stars;
        int playerspeed ;

        int backgroundspeed;

        PictureBox[] munition;
        private int munitionspeed;

        Random rand;

        PictureBox[] enimes;
        int enimesspeed;

        PictureBox[] enimeshot;
        int enimeshotsspeed;

        int score;
        int level;
        int deficulty;
        bool paused;
        bool gameisover;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            paused = false;
            gameisover = false;
            score = 0;
            level = 1;
            deficulty = 9;

            backgroundspeed = 4;
            playerspeed = 7;
            munition = new PictureBox[10];
            munitionspeed =50;
            enimesspeed = 5;
            enimeshotsspeed = 10;

            Image munitions = Image.FromFile(@"asserts\munition.png");
            Image E1 = Image.FromFile(@"asserts\E1.png");
            Image E2 = Image.FromFile(@"asserts\E2.png");
            Image E3 = Image.FromFile(@"asserts\E3.png");
            Image Boss1 = Image.FromFile(@"asserts\Boss1.png");
            Image Boss2 = Image.FromFile(@"asserts\Boss2.png");

            enimes = new PictureBox[10];
            enimeshot = new PictureBox[10];

            for (int i = 0; i < enimes.Length; i++)
            {
                enimes[i] = new PictureBox();
                enimes[i].Size = new Size(40,40);
                enimes[i].SizeMode = PictureBoxSizeMode.Zoom;
                enimes[i].BorderStyle = BorderStyle.None;
                enimes[i].Visible = false;
                this.Controls.Add(enimes[i]);
                enimes[i].Location = new Point((i+1)*50,-50);

            }
            enimes[0].Image = Boss1;
            enimes[1].Image = E1;
            enimes[2].Image = E2;
            enimes[3].Image = E2;
            enimes[4].Image = E3;
            enimes[5].Image = E3;
            enimes[6].Image = E1;
            enimes[7].Image = E2;
            enimes[8].Image = E1;
            enimes[9].Image = Boss2;



            for (int i = 0; i < munition.Length; i++)
            {
                munition[i] = new PictureBox();
                munition[i].Size = new Size(10,10);
                munition[i].Image = munitions;
                munition[i].SizeMode = PictureBoxSizeMode.Zoom;
                munition[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(munition[i]);

            }


            gamemedia = new WindowsMediaPlayer();
            shotsmedia = new WindowsMediaPlayer();
            explo = new WindowsMediaPlayer();

            gamemedia.URL = "songs\\GameSong.mp3";
            shotsmedia.URL = "songs\\shoot.mp3";
            explo.URL = "songs\\boom.mp3";

            gamemedia.settings.setMode("loop", true);
            gamemedia.settings.volume = 5;
            shotsmedia.settings.setMode("loop",true);
            shotsmedia.settings.volume = 5;
            explo.settings.volume = 5;


            stars = new PictureBox[15];
            rand = new Random();
            for (int i = 0; i < stars.Length; i++)
            {
                stars[i] = new PictureBox();
                stars[i].BorderStyle = BorderStyle.None;
                stars[i].Location = new Point(rand.Next(20,500), rand.Next(-10,400));

                if (i%2 ==1)
                {
                    stars[i].Size = new Size(3,3);
                    stars[i].BackColor = Color.White;
                }
                else
                {
                    stars[i].Size = new Size(4, 4);
                    stars[i].BackColor = Color.White;
                }

                this.Controls.Add(stars[i]);

            }


            for (int i = 0; i < enimeshot.Length; i++)
            {
                enimeshot[i] = new PictureBox();
                enimeshot[i].Size = new Size(2,25);
                enimeshot[i].Visible = false;
                enimeshot[i].BackColor = Color.Red;
               int x = rand.Next(0,10);
                enimeshot[i].Location = new Point(enimes[x].Location.X,enimes[x].Location.Y-20);
                this.Controls.Add(enimeshot[i]);


            }

            gamemedia.controls.play();
            shotsmedia.controls.play();

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < stars.Length/2; i++)
            {
                stars[i].Top += backgroundspeed;
                if (stars[i].Top>=this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
            for (int i = stars.Length / 2; i < stars.Length; i++)
            {
                stars[i].Top += backgroundspeed-2;
                if (stars[i].Top >= this.Height)
                {
                    stars[i].Top = -stars[i].Height;
                }
            }
        }
        private void Rmovetimer_Tick(object sender, EventArgs e)
        {
            if (player.Right< 520)
            {
                player.Left += playerspeed;
            }
        }
        private void Lmovetimer_Tick(object sender, EventArgs e)
        {
            if (player.Left > 10)
            {
                player.Left -= playerspeed;
            }
        }
        private void Umovetimer_Tick(object sender, EventArgs e)
        {
            if (player.Top < 450)
            {
                player.Top += playerspeed;
            }
        }
        private void Dmovetimer_Tick(object sender, EventArgs e)
        {
            if (player.Top >5)
            {
                player.Top -= playerspeed;
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!paused)
            {
                if (e.KeyCode == Keys.Right)
                {
                    Rmovetimer.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    Lmovetimer.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    Umovetimer.Start();

                }
                if (e.KeyCode == Keys.Up)
                {
                    Dmovetimer.Start();

                }
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Rmovetimer.Stop();
            Lmovetimer.Stop();
            Umovetimer.Stop();
            Dmovetimer.Stop();

            if (e.KeyCode == Keys.Space)
            {
                if (!gameisover)
                {
                    if (paused)
                    {
                        Starttimers();
                        label1.Visible = false;
                        paused = false;
                    }
                    else
                    {
                        label1.Location = new Point(this.Width/2 -120, 150);
                        label1.Text = "paused";
                        label1.Visible = true;
                        gamemedia.controls.pause();
                        Stoptimers();
                        paused = true;

                    }
                }
            }
        }
        private void Munitiontimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < munition.Length; i++)
            {
                if (munition[i].Top>0)
                {
                    munition[i].Visible = true;
                    munition[i].Top -= munitionspeed;

                    collision();
                    Collisionbetweenplayerandenimeshots();
                }
                else
                {
                    munition[i].Visible = false;
                    munition[i].Location = new Point(player.Location.X + 20, player.Location.Y-1 * 30);
                }
            }
        }
        private void Moveenimestimer_Tick(object sender, EventArgs e)
        {
            moveenimes(enimes,enimesspeed);
        }
        private void moveenimes(PictureBox[] array, int speed)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += speed;

                if (array[i].Top>this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }
        private void collision()
        {
            for (int i = 0; i < enimes.Length; i++)
            {
                if (munition[i].Bounds.IntersectsWith(enimes[i].Bounds) )
                {
                    // explo.controls.play();
                    score += 1;
                    Slabel.Text = (score < 10) ? "0" + score.ToString() : level.ToString();
                    if (score%30==0)
                    {
                        level += 1;
                        levelabel.Text = (level < 11) ? "0"+ level.ToString() :level.ToString() ;
                        if (enimesspeed<=10&& enimeshotsspeed<=10 && deficulty>=0)
                        {
                            deficulty--;
                            enimeshotsspeed++;
                            enimeshotsspeed++;

                        }

                        if (level ==10)
                        {
                            Gameover("nice game");
                        }
                    }
                    enimes[i].Location = new Point((i + 1) * 50, -100);
                }
                if (player.Bounds.IntersectsWith(enimes[i].Bounds))
                {
                    explo.settings.volume = 30;
                    explo.controls.play();
                    player.Visible = false;
                    Gameover("");
                }
            }

        }
        private void Gameover(String str)
        {
            label1.Text = str;
            label1.Location = new Point(120, 120);
            label1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;

            //gamemedia.controls.stop();
            Stoptimers();
        }
        private void Stoptimers()
        {
            timer1.Stop();        
            moveenimestimer.Stop();
            munitiontimer.Stop();
           // shotsmedia.controls.stop();
            enimeshots.Stop();
        }
        private void Starttimers()
        {
            timer1.Start();
            moveenimestimer.Start();
            munitiontimer.Start();
            enimeshots.Start();
        }
        private void Enimeshots_Tick(object sender, EventArgs e)
        { 

            for  (int i = 0; i <( enimeshot.Length -deficulty); i++)
            {
                if (enimeshot[i].Top< this.Height)
                {
                    enimeshot[i].Visible = true;
                    enimeshot[i].Top += enimeshotsspeed;
                }
                else
                {
                    enimeshot[i].Visible = false;
                    int y = rand.Next(0, 10);
                    enimeshot[i].Location = new Point(enimes[y].Location.X+20,enimes[y].Location.Y+30);

                }
            }
        }
        private void Collisionbetweenplayerandenimeshots()
        {
            for (int i = 0; i < enimeshot.Length; i++)
            {
                if (enimeshot[i].Bounds.IntersectsWith(player.Bounds))
                {
                    enimeshot[i].Visible = false;
                    //explo.settings.volume = 30;
                   //explo.controls.play();
                    player.Visible = false;
                    Gameover("gameover");
                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e, e);

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
