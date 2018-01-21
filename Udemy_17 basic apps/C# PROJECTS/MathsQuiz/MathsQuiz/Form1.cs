using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsQuiz
{
    public partial class mathsQuiz : Form
    {
        Random randomizer = new Random();

        int addNum1;
        int addNum2;

        int minusNum1;
        int minusNum2;

        int multiplyNum1;
        int multiplyNum2;

        int divideNum1;
        int divideNum2;

        int clock;


        public void StartQuiz()
        {

            addNum1 = randomizer.Next(51);
            addNum2 = randomizer.Next(51);
            plusLeftLabel.Text = addNum1.ToString();
            plusRightLabel.Text = addNum2.ToString();
            sum.Value = 0;

            minusNum1 = randomizer.Next(1, 101);
            minusNum2 = randomizer.Next(1, minusNum1);
            minusLeftLabel.Text = minusNum1.ToString();
            minusRight.Text = minusNum2.ToString();
            difference.Value = 0;

            multiplyNum1 = randomizer.Next(2, 11);
            multiplyNum2 = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplyNum1.ToString();
            timesRightLabel.Text = multiplyNum2.ToString();
            product.Value = 0;

            divideNum2 = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            divideNum1 = divideNum2 * temporaryQuotient;
            dividedLeftLabel.Text = divideNum1.ToString();
            dividedRightLabel.Text = divideNum2.ToString();
            quotent.Value = 0;


            clock = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
        }


        private bool CheckAnswer()
        {

            if ((((addNum1 + addNum2 == sum.Value)
                && (minusNum1 - minusNum2 == difference.Value))
                && (multiplyNum1 * multiplyNum2 == product.Value))
                && (divideNum1 / divideNum2 == quotent.Value))

                return true;
            else
                return false;


        }



        public mathsQuiz()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (clock > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                clock = clock - 1;
                timeLabel.Text = clock + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addNum1 + addNum2;
                difference.Value = minusNum1 - minusNum2;
                product.Value = multiplyNum1 * multiplyNum2;
                quotent.Value = divideNum1 / divideNum2;
                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)


        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

    }

}

