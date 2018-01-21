using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPingPong
{
    public partial class frmPingPong : Form
    {
        public int speed_left = 6;
        public int speed_top = 6;
        public int points = 0;



        public frmPingPong()
        {
            InitializeComponent();

            timer1.Interval = 1;
            timer1.Enabled = true;
            Cursor.Hide();

            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;

            Racket.Top = PlayGround.Bottom - (PlayGround.Bottom / 10);

            lblGameOver.Left = (PlayGround.Width / 2) - (lblGameOver.Width / 2);
            lblGameOver.Top = (PlayGround.Height / 2) - (lblGameOver.Height / 2);
            lblGameOver.Visible = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Racket.Left = Cursor.Position.X - (Racket.Width / 2);

            Ball.Left += speed_left;
            Ball.Top += speed_top;

            if (Ball.Bottom >= Racket.Top && Ball.Bottom <= Racket.Bottom && Ball.Left >= Racket.Left && Ball.Right <= Racket.Right)
            {
                speed_top += 2;
                speed_left += 2;
                speed_top = -speed_top;
                points += 1;
                lblScoreValue.Text = points.ToString();

                Random rand = new Random();
                PlayGround.BackColor = Color.FromArgb(rand.Next(150, 255), rand.Next(150, 255), rand.Next(150, 255));
            
            }

            if (Ball.Left <= PlayGround.Left)
                speed_left = -speed_left;
            if (Ball.Right >= PlayGround.Right)
                speed_left = -speed_left;
            if (Ball.Top <= PlayGround.Top)
                speed_top = -speed_top;

            if (Ball.Bottom >= PlayGround.Bottom)
            {
                timer1.Enabled = false;
                lblGameOver.Visible = true;
            }

        }

        private void frmPingPong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
            if (e.KeyCode == Keys.F1)
            {
                Ball.Top = 50;
                Ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                lblScoreValue.Text = "0";
                timer1.Enabled = true;
                lblGameOver.Visible = false;
                PlayGround.BackColor = Color.White;
            }
        }
    }
}
