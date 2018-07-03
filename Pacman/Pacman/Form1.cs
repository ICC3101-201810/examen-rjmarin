using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace Pacman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random random = new Random();
            int x = random.Next(600);
            int y = random.Next(400);
            pictureghost_pink.Location= new Point(x, y);
            int xq = random.Next(600);
            int yq = random.Next(400);
            pictureghost_red.Location = new Point(xq, yq);
            x = random.Next(600);
            y = random.Next(400);
            picturegrape.Location = new Point(x, y);
            x = random.Next(600);
            y = random.Next(400);
            picturecherry.Location = new Point(x, y);
            picturegrape.Visible = false;
            picturecherry.Visible = false;



        }
        bool goleft = false;
        bool goright = true;
        bool goup = false;
        bool godown = false;
        int move = 10;
        int movee = 1;
        Rectangle rectangle = new Rectangle(100, 100, 100, 100);
        private static System.Timers.Timer aTimer;
        private static System.Timers.Timer timer;
        private static System.Timers.Timer time;
        int score = 0;





        private void timer1_Tick(object sender, EventArgs e)
        {
            Random random = new Random();

            int pacmanX = picture_pacman.Location.X;
            int pacmanY = picture_pacman.Location.Y;
           

            aTimer = new System.Timers.Timer(3000);
            aTimer.Elapsed += OnTimedEvent;
            aTimer.AutoReset = true;
            aTimer.Enabled = true;

            timer = new System.Timers.Timer(30000); 
            timer.Elapsed += OnTimedEventfruit;
            timer.AutoReset = true;
            timer.Enabled = true;
            

            random.Next(3);
            

            if (goup)
            {
                pacmanY -= move;
            }
            if (godown)
            {
                pacmanY += move;
            }
            if (goright)
            {
                pacmanX += move;
            }
            if (goleft)
            {
                pacmanX -= move;

            }
            picture_pacman.Location = new Point(pacmanX, pacmanY);
            // pictureghost_pink.Location = new Point(pinkX, pinkY);
            //pictureghost_red.Location = new Point(redX, redY);
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox && item.Tag == "wall")
                {
                    if (((PictureBox)item).Bounds.IntersectsWith(picture_pacman.Bounds))
                    {
                        godown = false;
                        goleft = false;
                        goright = false;
                        goup = false;
                    }
                    if (((PictureBox)item).Bounds.IntersectsWith(pictureghost_pink.Bounds))
                    {
                        pictureghost_pink.Location = new Point(Location.X, Location.Y);
                        

                    }
                    if (((PictureBox)item).Bounds.IntersectsWith(pictureghost_pink.Bounds))
                    {
                        pictureghost_red.Location = new Point(Location.X, Location.Y);
                    }
                    if (item is PictureBox && item.Tag == "ghost")
                    {
                        if (((PictureBox)item).Bounds.IntersectsWith(picture_pacman.Bounds))
                        {
                            godown = false;
                            goleft = false;
                            goright = false;
                            goup = false;
                            labelGame.Text = "GAMEOVER";
                        }
                    }

                }

            }
        }

        private void OnTimedEventesconder(object sender, ElapsedEventArgs e)
        {
            picturegrape.Visible = false;
            picturecherry.Visible = false;
        }

        private void OnTimedEventfruit(object sender, ElapsedEventArgs e)
        {
            Random r = new Random();
            int rr = r.Next(2);
            if( rr < 2)
            {
                picturecherry.Visible = true;

            }
            else
            {
                picturegrape.Visible = true;
            }
            time = new System.Timers.Timer(10000);
            time.Elapsed += OnTimedEventesconder;
            time.AutoReset = true;
            time.Enabled = true;
        }

        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            //me aparece un error por no saber manejar bien thread  no pude arreglarlo
            //parte el movimento del os fantasmas despues de 2 segundos
            int pacmanX = picture_pacman.Location.X;
            int pacmanY = picture_pacman.Location.Y;
            int redX = picture_pacman.Location.X;
            int redY = picture_pacman.Location.Y;
            int pinkX = picture_pacman.Location.X;
            int pinkY = picture_pacman.Location.Y;
            bool bolito = true;
            if (bolito)
            {
                if (pacmanX < redX && pacmanX < pinkX)
                {
                    redX -= movee;
                    pinkX -= movee;

                }
                if (pacmanX > redX && pacmanX < pinkX)
                {
                    redX += movee;
                    pinkX -= movee;

                }
                if (pacmanX < redX && pacmanX > pinkX)
                {
                    redX -= movee;
                    pinkX += movee;

                }
                if (pacmanX > redX && pacmanX > pinkX)
                {
                    redX += movee;
                    pinkX += movee;

                }
                bolito = false;
            }
            else
            {
                if (pacmanY < redY && pacmanY < pinkY)
                {
                    redY -= movee;
                    pinkY -= movee;

                }
                if (pacmanY > redY && pacmanY < pinkY)
                {
                    redY += movee;
                    pinkY -= movee;

                }
                if (pacmanY < redY && pacmanY > pinkY)
                {
                    redY -= movee;
                    pinkY += movee;
                }
                if (pacmanY > redY && pacmanY > pinkY)
                {
                    redY += movee;
                    pinkY += movee;

                }
            }
            /*
            pictureghost_pink.Location = new Point(pinkX, pinkY);
            pictureghost_red.Location = new Point(redX, redY);
            */
            
            



        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //me funcionaba antes de poner el panel despues de inicio de juego pero despues me paro de funcionar
            //trate de hacer de todo pero como me quedaba poco tiempo no lo pude corregir

            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                picture_pacman.Image = Properties.Resources.pacman_up;
                goleft = false;
                goright = false;
                godown = false;


            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                picture_pacman.Image = Properties.Resources.pacman_down;
                goleft = false;
                goright = false;
                goup = false;

            }
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                picture_pacman.Image = Properties.Resources.pacman_left;
                goup = false;
                goright = false;
                godown = false;

            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                picture_pacman.Image = Properties.Resources.pacman_right;
                goleft = false;
                goup = false;
                godown = false;

            }
        }

        private void buttonjugar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text =="")
            {
                MessageBox.Show("Name is required");
            }
            else
            {
                panel1.Visible = false;
                timer1.Enabled = true;
                labelScore.Text += score;
                labelNAm.Text += textBoxNombre.Text;
                
                
                
                
            }
        }

        private void Btn_scores_Click(object sender, EventArgs e)
        {
            Scores s = new Scores();
            s.Show();
        }
    }
}
