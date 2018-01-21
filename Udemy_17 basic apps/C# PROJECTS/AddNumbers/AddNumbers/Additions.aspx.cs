using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace AddNumbers
{
    public partial class Additions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sum_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int answer;

           firstNumber = 22;
           secondNumber = 34;
           answer = firstNumber + secondNumber;

            // MessageBox.Show(answer.ToString());

        }

    }
}