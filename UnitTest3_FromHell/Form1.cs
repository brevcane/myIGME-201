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
    public partial class NormalForm : Form
    {
        DevilsForm devilsform;
        public NormalForm()
        {
            InitializeComponent();
            Button[] digitButtons = new Button[]
            {
                button0, button1, button2, button3, button4, button5, button6, button7, button8, button9
            };

            foreach (Button button in digitButtons)
            {
                button.Click += new EventHandler(DigitButton__Click);
            }

            Button[] operandButtons = new Button[]
            {
                addButton, subtractButton, multiplyButton, divideButton
            };

            foreach (Button button in operandButtons)
            {
                button.Click += new EventHandler(OperandButton__Click);
            }

            this.equalsButton.Click += new EventHandler(EqualsButton__Click);

            this.clearButton.Click += new EventHandler(ClearButton__Click);

            this.textBox1.TextChanged += new EventHandler(TextBox1__TextChanged);

            this.FormClosing += new FormClosingEventHandler(NormalForm_FormClosing);

        }

        private void NormalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
            }
        }

        private void ClearButton__Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void TextBox1__TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "666")
            {
                OpenDevilsForm();
            }
        }

        private void OpenDevilsForm()
        {
            DevilsForm form = new DevilsForm();
            form.Show();
            
        }

        private void EqualsButton__Click(object sender, EventArgs e)
        {
            try
            {
                object result = new DataTable().Compute(textBox1.Text, null);
                textBox1.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void OperandButton__Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        private void DigitButton__Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }
    }
}
