using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyLoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-QPF8E9N;Initial Catalog=userLogin;Integrated Security=True");
            string query = $"SELECT * FROM logins WHERE username = '{textBox1.Text.Trim()}' and password='{textBox2.Text}'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                Form2 form2 = new Form2();
                //this.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Please check your username and password.");
            }
        }
    }
}
