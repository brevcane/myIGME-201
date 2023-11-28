using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PE17_GuessingGame
{
    public partial class GameForm : Form
    {
        Timer timer = new Timer();
        Random random = new Random();
        int nGuesses = 0;
        int highNum;
        int lowNum;
        int rand;

        public GameForm(int lowNumber, int highNumber)
        {
            InitializeComponent();

            timer.Interval = 500;
            timer.Tick += new EventHandler(Timer__Tick);
            timer.Start();

            guessButton.Click += new EventHandler(GuessButton__Click);

            textBox1.KeyPress += new KeyPressEventHandler(TextBox1__KeyPress);

            highNum = highNumber;
            lowNum = lowNumber;
            rand = random.Next(lowNum, highNum + 1);
        }

        private void TextBox1__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void GuessButton__Click(object sender, EventArgs e)
        {
            string guess = textBox1.Text;
            int guessInt = int.Parse(guess);
            
            if (guessInt > highNum || guessInt < lowNum)
            {
                MessageBox.Show("Invalid Guess");
            }
            else
            {
                nGuesses++;

                if (guessInt == rand)
                {
                    MessageBox.Show("Woohoo! You got it in " + nGuesses + "!");
                    this.Close();
                }
                if (guessInt > rand)
                {
                    outputLabel.Text = "Your guess of " + guess + " was too HIGH.";
                }
                else
                {
                    outputLabel.Text = "Your guess of " + guess + " was too LOW.";
                }
            }
        }

        private void Timer__Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value > 0)
            {
                progressBar1.Value -= 1;
            }
            else
            {
                
                timer.Stop();
                MessageBox.Show("Out of guesses! The number was " + rand);
                this.Close();
            }
        }
    }
}
