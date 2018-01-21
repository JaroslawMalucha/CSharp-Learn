using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyImageUploads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void image_UploadsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.image_UploadsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myImages);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'myImages.Image_Uploads' table. You can move, or remove it, as needed.
            this.image_UploadsTableAdapter.Fill(this.myImages.Image_Uploads);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFD = new OpenFileDialog();
            openFD.Filter = "Images|*.jpg; *.jpeg; *.png; *.gif;";

            DialogResult dr = openFD.ShowDialog();

            this.imgPictureBox.Image = Image.FromFile(openFD.FileName);

            this.imgPathLabel1.Text = openFD.FileName;

        }
    }
}
