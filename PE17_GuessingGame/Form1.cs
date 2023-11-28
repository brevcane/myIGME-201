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
    public partial class StartForm : Form
    {
        int lowNumber;
        int highNumber;
        public StartForm()
        {
            InitializeComponent();

            lowTextBox.Text = "1";
            highTextBox.Text = "100";

            startButton.Click += new EventHandler(StartButton__Click);

            lowTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
            highTextBox.KeyPress += new KeyPressEventHandler(TextBox__KeyPress);
        }

        private void TextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void StartButton__Click(object sender, EventArgs e)
        {
            if (int.TryParse(highTextBox.Text, out highNumber) && int.TryParse(lowTextBox.Text, out lowNumber) && highNumber > lowNumber && lowNumber >= 1 && highNumber <= 100)
            {
                GameForm form = new GameForm(lowNumber, highNumber);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("The numbers are invalid.");
            }
            
        }
    }
}
