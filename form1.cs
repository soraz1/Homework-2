using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuessingGame_1
{
    public partial class Form1 : Form
    {
        private int numberToGuess;
        private bool isGameActive = false;

        public Form1()
        {
            InitializeComponent();
            numberToGuess = new Random().Next(1, 1001);
            isGameActive = true;
            label1.Text = "I have a number between 1 and 1000. Can you guess my number? Please enter your first guess.";
            textBox1.Enabled = true;
            button1.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isGameActive)
            {
                int guess = int.Parse(textBox1.Text);
                if (guess < numberToGuess)
                {
                    label1.Text = "Too Low";
                 Color backgroundColor = Color.Blue;
                    base.BackColor = backgroundColor;

                }
                else if (guess > numberToGuess)
                {
                    label1.Text = "Too High";
                 Color backgroundColor = Color.Red;
                    base.BackColor = backgroundColor;

                }
                else
                {
                    MessageBox.Show("Correct!");
                 Color backgroundColor = Color.Green;
                    isGameActive = false;
                    button1.Visible = true;
                    base.BackColor = backgroundColor;

                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            isGameActive = true;
            numberToGuess = new Random().Next(1, 1001);
            label1.Text = "I have a number between 1 and 1000. Can you guess my number? Please enter your first guess.";
            Color backgroundColor = Color.LightPink;
            base.BackColor = backgroundColor;
            textBox1.Enabled = true;
        }
    }

}
  
