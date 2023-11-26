using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTest3_FromHell
{
    public partial class ExitForm : Form
    {
        Random random = new Random();
        public ExitForm()
        {
            InitializeComponent();

            exitButton.MouseHover += new EventHandler(ExitButton__MouseHover);
            exitButton.Click += new EventHandler(ExitButton__Click);

            this.FormClosing += new FormClosingEventHandler(NormalForm_FormClosing);
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton__MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int randInt = random.Next(1, 20);
            if (randInt != 10)
            {
                int newX = random.Next(ClientSize.Width - button.Width);
                int newY = random.Next(ClientSize.Height - button.Height);
                button.Location = new Point(newX, newY);
            }
        }

        private void NormalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }
    }
}
