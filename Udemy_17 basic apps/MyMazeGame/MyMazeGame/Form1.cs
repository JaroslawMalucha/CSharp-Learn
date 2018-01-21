using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyMazeGame
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer startSoundplayer = new System.Media.SoundPlayer(@"C:\Windows\media\chord.wav");
        System.Media.SoundPlayer finishSoundplayer = new System.Media.SoundPlayer(@"C:\Windows\media\tada.wav");

        public Form1()
        {
            InitializeComponent();
            MoveToStart();

            foreach(Control ctrl in panel1.Controls)
            {
                Label lbl = ctrl as Label;
                {
                    lbl.MouseEnter += wall_MouseEnter;
                }
            }

            panel1.MouseLeave += wall_MouseEnter;
        }

        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            finishSoundplayer.Play();
            MessageBox.Show("Congratulations!");
            Close();
        }

        private void MoveToStart()
        {
            startSoundplayer.Play();
            Point startingPoint = panel1.Location;
            startingPoint.Offset(10, 10);
            //if (this != null)
            //{
            try
            {
                Cursor.Position = PointToScreen(startingPoint);
            }
            catch
            {

            }
            //}

        }

        private void wall_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }
    }
}
