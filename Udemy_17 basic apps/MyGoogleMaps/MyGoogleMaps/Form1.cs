using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGoogleMaps
{
    public partial class frm : Form
    {
        public frm()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string street = txtbStreet.Text;
            string city = txtbCity.Text;
            string state = txtbState.Text;
            string zipCode = txtbZipCode.Text;


            try
            {
                StringBuilder query = new StringBuilder();
                query.Append("http://maps.google.com/maps?q=");

                if (!string.IsNullOrWhiteSpace(street))
                    query.Append(street + "," + "+");
                if (!string.IsNullOrWhiteSpace(city))
                    query.Append(city + "," + "+");
                if (!string.IsNullOrWhiteSpace(state))
                    query.Append(state + "," + "+");
                if (!string.IsNullOrWhiteSpace(zipCode))
                    query.Append(zipCode + "," + "+");
                webBrowser1.Navigate(query.ToString());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Error");
            }
        }
    }
}
