using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitTest3_Presidents
{
    public partial class Form1 : Form
    {
        Timer progressBarTimer = new Timer();

        public Form1()
        {
            InitializeComponent();

            
            progressBarTimer.Interval = 1000;
            progressBarTimer.Tick += new EventHandler(ProgressBarTimer__Tick);

            filterGroupBox.SendToBack();


            RadioButton[] presidentRadioButtons = new RadioButton[]
            {
                radioButton1,
                radioButton2,
                radioButton3,
                radioButton4,
                radioButton5,
                radioButton6,
                radioButton7,
                radioButton8,
                radioButton9,
                radioButton10,
                radioButton11,
                radioButton12,
                radioButton13,
                radioButton14,
                radioButton15,
                radioButton16
            };

            foreach (RadioButton radioButton in presidentRadioButtons )
            {
                radioButton.Click += new EventHandler(PresidentRadioButton__Click);
            }

            RadioButton[] filterRadioButtons = new RadioButton[]
            {
                radioButton17,
                radioButton18,
                radioButton19,
                radioButton20,
                radioButton21
                
            };

            foreach (RadioButton radioButton in filterRadioButtons)
            {
                radioButton.Click += new EventHandler(FilterRadioButton__Click);
            }

            TextBox[] presidentTextBoxes = new TextBox[]
            {
                textBox1,
                textBox2,
                textBox3,
                textBox4,
                textBox5,
                textBox6,
                textBox7,
                textBox8,
                textBox9,
                textBox10,
                textBox11,
                textBox12,
                textBox13,
                textBox14,
                textBox15,
                textBox16

            };

            foreach (TextBox textBox in presidentTextBoxes)
            {
                textBox.KeyPress += new KeyPressEventHandler(PresidentTextBox__KeyPress);
            }

            this.pictureBox1.MouseEnter += new EventHandler(PictureBox1__MouseEnter);
            this.pictureBox1.MouseLeave += new EventHandler(PictureBox1__MouseLeave);

            this.exitButton.Click += new EventHandler(ExitButton__Click);

            exitButton.Enabled = false;
        }

        private void ProgressBarTimer__Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value > progressBar1.Minimum)
            {
                progressBar1.Value--;
            }
        }

        int correct = 0;
        private void GameOver()
        {
            if (correct == 16)
            {
                exitButton.Enabled = true;
                this.webBrowser1.Navigate("https://media.giphy.com/media/TmT51OyQLFD7a/giphy.gif");
                progressBarTimer.Stop();
            }
        }

        private void PresidentTextBox__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox selectedTextBox = sender as TextBox;

            if (progressBar1.Value == 120)
            {
                progressBarTimer.Start();
            }


            GameOver();

            if (selectedTextBox.ReadOnly == false)
            {
                if (selectedTextBox == textBox1)
                {
                    if (textBox1.Text == "23")
                    {
                        textBox1.ReadOnly = true;
                        correct++;
                    }
                }
                if (selectedTextBox == textBox2)
                {
                    if (textBox2.Text == "25")
                    {
                        textBox2.ReadOnly = true;
                        correct++;
                    }
                }
                if (selectedTextBox == textBox3)
                {
                    if (textBox3.Text == "32")
                    {
                        textBox3.ReadOnly = true;
                        correct++;
                    }
                }
                if (selectedTextBox == textBox4)
                {
                    if (textBox4.Text == "40")
                    {
                        textBox4.ReadOnly = true;
                        correct++;
                    }
                }
                if (selectedTextBox == textBox5)
                {
                    if (textBox5.Text == "42")
                    {
                        textBox5.ReadOnly = true;
                        correct++;
                    }
                }
            {
                    if (textBox6.Text == "34")
                    {
                        textBox6.ReadOnly = true;
                        correct++;
                    }
                }
                if (selectedTextBox == textBox7)
                {
                    if (textBox7.Text == "15")
                    {
                        textBox7.ReadOnly = true;
                        correct++;
                    }
                }
                if (selectedTextBox == textBox8)
                {
                    if (textBox8.Text == "8")
                    {
                        textBox8.ReadOnly = true;
                        correct++;
                    }
                }
                if (selectedTextBox == textBox9)
                {
                    if (textBox9.Text == "14")
                    {
                        textBox9.ReadOnly = true;
                        correct++;
                    }
                }
                if (selectedTextBox == textBox10)
                {
                    if (textBox10.Text == "1")
                    {
                        textBox10.ReadOnly = true;
                        correct++;
                    }
                }
                if (selectedTextBox == textBox11)
                {
                    if (textBox11.Text == "43")
                    {
                        textBox11.ReadOnly = true;
                        correct++;
                    }
                }
                if (selectedTextBox == textBox12)
                {
                    if (textBox12.Text == "2")
                    {
                        textBox12.ReadOnly = true;
                        correct++;
                    }
                }
                if (selectedTextBox == textBox13)
                {
                    if (textBox13.Text == "44")
                    {
                        textBox13.ReadOnly = true;
                        correct++;
                    }
                }
                if (selectedTextBox == textBox14)
                {
                    if (textBox14.Text == "26")
                    {
                        textBox14.ReadOnly = true;
                        correct++;
                    }
                }
                if (selectedTextBox == textBox15)
                {
                    if (textBox15.Text == "35")
                    {
                        textBox15.ReadOnly = true;
                        correct++;
                    }
                }
                if (selectedTextBox == textBox16)
                {
                    if (textBox16.Text == "3")
                    {
                        textBox16.ReadOnly = true;
                        correct++;
                    }
                }
            }
            
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox1__MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Width * 2, pictureBox1.Height * 2);
        }

        private void PictureBox1__MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Size = new Size(pictureBox1.Width / 2, pictureBox1.Height / 2);
        }

        private void FilterRadioButton__Click(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton == radioButton17)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;
                radioButton4.Visible = true;
                radioButton5.Visible = true;
                radioButton6.Visible = true;
                radioButton7.Visible = true;
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = true;
                radioButton11.Visible = true;
                radioButton12.Visible = true;
                radioButton13.Visible = true;
                radioButton14.Visible = true;
                radioButton15.Visible = true;
                radioButton16.Visible = true;

                radioButton1.Checked = true;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
            }
            if (selectedRadioButton == radioButton18)
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = true;
                radioButton4.Visible = false;
                radioButton5.Visible = true;
                radioButton6.Visible = false;
                radioButton7.Visible = true;
                radioButton8.Visible = true;
                radioButton9.Visible = true;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;
                radioButton13.Visible = true;
                radioButton14.Visible = false;
                radioButton15.Visible = true;
                radioButton16.Visible = false;

                radioButton3.Checked = true;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");
            }
            if (selectedRadioButton == radioButton19)
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = false;
                radioButton4.Visible = true;
                radioButton5.Visible = false;
                radioButton6.Visible = true;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = true;
                radioButton12.Visible = false;
                radioButton13.Visible = false;
                radioButton14.Visible = true;
                radioButton15.Visible = false;
                radioButton16.Visible = false;

                radioButton1.Checked = true;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
            }
            if (selectedRadioButton == radioButton20)
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = false;
                radioButton11.Visible = false;
                radioButton12.Visible = false;
                radioButton13.Visible = false;
                radioButton14.Visible = false;
                radioButton15.Visible = false;
                radioButton16.Visible = true;

                radioButton16.Checked = true;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
            }
            if (selectedRadioButton == radioButton21)
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                radioButton5.Visible = false;
                radioButton6.Visible = false;
                radioButton7.Visible = false;
                radioButton8.Visible = false;
                radioButton9.Visible = false;
                radioButton10.Visible = true;
                radioButton11.Visible = false;
                radioButton12.Visible = true;
                radioButton13.Visible = false;
                radioButton14.Visible = false;
                radioButton15.Visible = false;
                radioButton16.Visible = false;

                radioButton10.Checked = true;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/George_Washington");
            }
        }

        private void PresidentRadioButton__Click(object sender, EventArgs e)
        {
            RadioButton selectedRadioButton = sender as RadioButton;

            if (selectedRadioButton == radioButton1)
            {
                pictureBox1.Image = Properties.Resources.BenjaminHarrison;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Benjamin_Harrison");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Benjamin_Harrison";
            }
            if (selectedRadioButton == radioButton2)
            {
                pictureBox1.Image = Properties.Resources.WilliamMcKinley;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/William_McKinley");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/William_McKinley";
            }
            if (selectedRadioButton == radioButton3)
            {
                pictureBox1.Image = Properties.Resources.FranklinDRoosevelt;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_D_Roosevelt";
            }
            if (selectedRadioButton == radioButton4)
            {
                pictureBox1.Image = Properties.Resources.RonaldReagan;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Ronald_Reagan");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Ronald_Reagan";
            }
            if (selectedRadioButton == radioButton5)
            {
                pictureBox1.Image = Properties.Resources.WilliamJClinton;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/William_J_Clinton");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/William_J_Clinton";
            }
            if (selectedRadioButton == radioButton6)
            {
                pictureBox1.Image = Properties.Resources.DwightDEisenhower;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Dwight_D_Eisenhower");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Dwight_D_Eisenhower";
            }
            if (selectedRadioButton == radioButton7)
            {
                pictureBox1.Image = Properties.Resources.JamesBuchanan;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/James_Buchanan");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/James_Buchanan";
            }
            if (selectedRadioButton == radioButton8)
            {
                pictureBox1.Image = Properties.Resources.MartinVanBuren;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Martin_VanBuren");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Martin_VanBuren";
            }
            if (selectedRadioButton == radioButton9)
            {
                pictureBox1.Image = Properties.Resources.FranklinPierce;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Franklin_Pierce");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Franklin_Pierce";
            }
            if (selectedRadioButton == radioButton10)
            {
                pictureBox1.Image = Properties.Resources.GeorgeWashington;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/George_Washington");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/George_Washington";
            }
            if (selectedRadioButton == radioButton11)
            {
                pictureBox1.Image = Properties.Resources.GeorgeWBush;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/George_W_Bush");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/George_W_Bush";
            }
            if (selectedRadioButton == radioButton12)
            {
                pictureBox1.Image = Properties.Resources.JohnAdams;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/John_Adams");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/John_Adams";
            }
            if (selectedRadioButton == radioButton13)
            {
                pictureBox1.Image = Properties.Resources.BarackObama;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Barack_Obama");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Barack_Obama";
            }
            if (selectedRadioButton == radioButton14)
            {
                pictureBox1.Image = Properties.Resources.TheodoreRoosevelt;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Theodore_Roosevelt");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Theodore_Roosevelt";
            }
            if (selectedRadioButton == radioButton15)
            {
                pictureBox1.Image = Properties.Resources.JohnFKennedy;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/John_F_Kennedy");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/John_F_Kennedy";
            }
            if (selectedRadioButton == radioButton16)
            {
                pictureBox1.Image = Properties.Resources.ThomasJefferson;
                this.webBrowser1.Navigate("https://en.m.wikipedia.org/wiki/Thomas_Jefferson");
                this.browserGroupBox.Text = "https://en.m.wikipedia.org/wiki/Thomas_Jefferson";
            }
        }
    }
}
