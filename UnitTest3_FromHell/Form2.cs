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
    public partial class DevilsForm : Form
    {
        Random random = new Random();
        Timer textBoxChangeTimer = new Timer();
        public DevilsForm()
        {
            InitializeComponent();
            Button[] digitButtons = new Button[]
            {
                button0, button1, button2, button3, button4, button5, button6, button7, button8, button9
            };

            foreach (Button button in digitButtons)
            {
                button.Click += new EventHandler(DevilDigitButton__Click);
                button.MouseEnter += new EventHandler(DevilDigitButton__MouseEnter);
                button.MouseLeave += new EventHandler(DevilDigitButton__MouseLeave);
            }

            Button[] operandButtons = new Button[]
            {
                addButton, subtractButton, multiplyButton, divideButton
            };

            foreach (Button button in operandButtons)
            {
                button.Click += new EventHandler(DevilOperandButton__Click);
                button.MouseEnter += new EventHandler(DevilDigitButton__MouseEnter);
                button.MouseLeave += new EventHandler(DevilDigitButton__MouseLeave);
            }

            this.equalsButton.Click += new EventHandler(DevilEqualsButton__Click);

            this.clearButton.Click += new EventHandler(DevilClearButton__Click);

            this.equalsButton.MouseEnter += new EventHandler(DevilDigitButton__MouseEnter);
            this.equalsButton.MouseLeave += new EventHandler(DevilDigitButton__MouseLeave);

            this.clearButton.MouseEnter += new EventHandler(DevilDigitButton__MouseEnter);
            this.clearButton.MouseLeave += new EventHandler(DevilDigitButton__MouseLeave);

            this.textBox1.TextChanged += new EventHandler(TextBox1__TextChanged);

            textBoxChangeTimer.Interval = 1000;
            textBoxChangeTimer.Tick += textBoxChangeTimer_Tick;
            textBoxChangeTimer.Start();

            this.FormClosing += new FormClosingEventHandler(NormalForm_FormClosing);
        }

        private void NormalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void textBoxChangeTimer_Tick(object sender, EventArgs e)
        {
            ChangeTextBox();
        }

        private void ChangeTextBox()
        {
            List<string> fontNames = new List<string> {"Times New Roman", "Courier New", "Verdana", "Futura", "Comic Sans" };
            string randomFont = fontNames[random.Next(fontNames.Count)];
            textBox1.Font = new Font(randomFont, textBox1.Font.Size);

            textBox1.ForeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void RandomButtonChanges(Button button)
        {
            button.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            int newSize = random.Next(25, 120);
            button.Size = new Size(newSize, newSize);

            int randInt = random.Next(1, 4);
            if (randInt != 3)
            {
                int newX = random.Next(ClientSize.Width - button.Width);
                int newY = random.Next(ClientSize.Height - button.Height);
                button.Location = new Point(newX, newY);
            }
        }

        private void DevilDigitButton__MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button) sender;
            RandomButtonChanges(button);
        }

        private void DevilClearButton__Click(object sender, EventArgs e)
        {
            int randInt = random.Next(1,11);
            if (randInt == 1)
            {
                textBox1.Text += "Cleansed!";
                Application.Restart();

            }
            else
            {
                textBox1.Clear();
                RandomButtonChanges((Button)sender);
            }
        }

        private void DevilDigitButton__MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            RandomButtonChanges(button);
        }

        private void TextBox1__TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "1134")
            {
                OpenExitForm();
            }
        }

        private void OpenExitForm()
        {
            ExitForm form = new ExitForm();
            form.Show();
        }

        private void DevilEqualsButton__Click(object sender, EventArgs e)
        {
            try
            {
                object result = new DataTable().Compute(textBox1.Text, null);
                textBox1.Text = result.ToString();
                RandomButtonChanges((Button)sender);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void DevilOperandButton__Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
            RandomButtonChanges(button);

        }

        private void DevilDigitButton__Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
            RandomButtonChanges(button);
        }
    
    }
}
