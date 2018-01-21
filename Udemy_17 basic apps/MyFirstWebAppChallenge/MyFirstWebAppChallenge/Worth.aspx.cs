using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyFirstWebAppChallenge
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void JudgeButton_Click(object sender, EventArgs e)
        {
            string res = "";
            int age = 0;
            double worth = 0;
            try
            {
                age = Convert.ToInt16(AgeBox.Text);
                worth = Convert.ToDouble(WorthBox.Text);
            }
            catch 
            {
                res = "Please supply a valid age andworth values";
                VerdictLabel.Text = res;
                return;
            }

            if (age == 0)
                res = "Well... not knowing your age is kinda retarded, no matter how much money you got.";
            else if (age < 20 && worth > 1000)
                res = "Looks like your are a spoiled little brat";
            else if (age >= 20 && worth <= 1000)
                res = $"At age {age} you should be worth more then mere {worth}...";
            else if (worth > 2000000)
                res = $"Consider yourself rich";
            else if (age >= 20 && worth >= 200000)
                res = $"Woaha now thats nice... {worth} is a pretty big sum for a {age} guy :)";
            else
                res = "You seem pretty average.";
            VerdictLabel.Text = res;
        }
    }
}