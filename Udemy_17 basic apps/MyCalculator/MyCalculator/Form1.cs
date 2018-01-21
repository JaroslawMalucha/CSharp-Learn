using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operatorClicked = "";
        bool isOperatorClicked = false;

        public Form1()
        {
            InitializeComponent();

            Control[] nums = new Control[] { btn0, btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9, btnDecimal };
            foreach(Control ctrl in nums)
            {
                Button numBtn = ctrl as Button;
                numBtn.Click += click_numButton;
            }

            Control[] ops = new Control[] { btnAdd, btnSub, btnMulti, btnDiv};
            foreach (Control ctrl in ops)
            {
                Button opBtn = ctrl as Button;
                opBtn.Click += operator_click;
            }
        }

        private void click_numButton(object sender, EventArgs e)
        {
            if (txtbResult.Text == "0" || isOperatorClicked)
                txtbResult.Clear();

            isOperatorClicked = false;
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if (!txtbResult.Text.Contains("."))
                    txtbResult.Text = txtbResult.Text + btn.Text;
            }
            else
            {
                txtbResult.Text = txtbResult.Text + btn.Text;
            }

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                btnEquals.PerformClick();
                operatorClicked = button.Text;
                isOperatorClicked = true;
            }
            else
            {

                operatorClicked = button.Text;
                resultValue = Double.Parse(txtbResult.Text);
                isOperatorClicked = true;


            }
            operatorClicked = button.Text;
            resultValue = Double.Parse(txtbResult.Text);
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            double curRes = Double.Parse(txtbResult.Text);
            double newRes = 0;
            switch (operatorClicked)
            {
                case "+":
                    newRes = (resultValue + curRes);
                    break;
                case "-":
                    newRes = (resultValue - curRes);
                    break;
                case "×":
                    newRes = (resultValue * curRes);
                    break;
                case "÷":
                    newRes = (resultValue / curRes);
                    break;
                default:
                    break;
            }

            txtbResult.Text = newRes.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbResult.Text = "0";
            resultValue = 0;
        }
    }
}
