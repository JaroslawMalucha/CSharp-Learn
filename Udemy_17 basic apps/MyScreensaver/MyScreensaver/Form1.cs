using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyScreensaver
{
    public partial class frmScreensaver : Form
    {
        List<Image> BGImages = new List<Image>();
        List<BritPic> BritPics = new List<BritPic>();
        Random rand = new Random();

        int ticks = 0;

        class BritPic
        {
            public int PicNum;
            public float X;
            public float Y;
            public float Speed;
        }


        public frmScreensaver()
        {
            InitializeComponent();
        }

        private void frmScreensaver_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                this.Refresh();
            else
                this.Close();
        }

        private void frmScreensaver_Load(object sender, EventArgs e)
        {
            string[] images = System.IO.Directory.GetFiles("pics");

            foreach (string image in images)
            {
                Bitmap original = new Bitmap(image);
                float scale = Math.Min( (float)Width / original.Width, (float)Height / original.Height);
                var scaleWidth = (int)(original.Width * scale * 0.5);
                var scaleHeight = (int)(original.Height * scale * 0.5);
                Bitmap resized = new Bitmap(original, new Size( scaleWidth, scaleHeight));
                 
                BGImages.Add(resized);
            }

            for (int i = 0; i < 50; ++i)
            {
                BritPic mp = new BritPic
                {
                    PicNum = i % BGImages.Count,
                    X = rand.Next(0, this.Width),
                    Y = rand.Next(0, this.Height)
                };

                BritPics.Add(mp);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks > 5)
                this.Close();
            Refresh();
            //Console.Beep();
        }

        private void frmScreensaver_Paint(object sender, PaintEventArgs e)
        {
            foreach (BritPic bp in BritPics)
            {
                e.Graphics.DrawImage(BGImages[bp.PicNum], bp.X, bp.Y);
                bp.X -= 20;

                if (bp.X < -250)
                {
                    bp.X = this.Width + rand.Next(20, 100);
                }
            }
        }
    }
}
