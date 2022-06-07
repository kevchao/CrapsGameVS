using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrapsGameVS
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        int balance = 100;
        int round = 1;
        int point;
        int betAmount = 0;
        int dice1, dice2, total;
        public Form1()
        {
            InitializeComponent();
            Restart();
        }
        public void Restart()
        {
            richTextBox1.Text = "Round 1 - Good Luck";
            lblBalance.Text = balance.ToString();
            round = 1;
            lblRound.Text = round.ToString();
            point = 0;
            lblPoint.Text = "0";
            bet.Text = "";
        }

        public void Round1()
        {
            richTextBox1.AppendText($"\nDice 1: {dice1 = random.Next(1, 7)}\nDice 2: {dice2 = random.Next(1, 7)}\nTotal: {total = dice1 + dice2}");
            if (total == 7 || total == 11)
            {
                MessageBox.Show("You lose! :(\nBetter luck next time.");
                balance -= betAmount;
                Restart();
            }
            else if (total == 2 || total == 3 || total == 12)
            {
                MessageBox.Show("You WIN!");
                balance += betAmount;
                Restart();
            }
            else
            {
                point = total;
                lblPoint.Text = point.ToString();
                round++;
                lblRound.Text = round.ToString();
                richTextBox1.AppendText($"\n \nRound 2 - Good Luck");
            }
        }
        public void Round2()
        {
            richTextBox1.AppendText($"\nDice 1: {dice1 = random.Next(1, 7)}\nDice 2: {dice2 = random.Next(1, 7)}\nTotal: {total = dice1 + dice2}");
            if (total == 7)
            {
                MessageBox.Show("You lose! :(\nBetter luck next time.");
                balance -= betAmount;
                Restart();
            }
            if (total == point)
            {
                MessageBox.Show("You WIN!");
                balance += betAmount;
                Restart();
            }
        }


        private void placeBet_Click(object sender, EventArgs e)
        {
            if(round == 1)
            {
                try
                {
                    bet.Text = textBox1.Text;
                    betAmount = int.Parse(bet.Text);
                    if (betAmount < 0 || betAmount == 0)
                    {
                        bet.Text = "";
                        MessageBox.Show("Bet amount must be greater than 0");
                    }
                    else if (betAmount > balance)
                    {
                        bet.Text = "";
                        MessageBox.Show("Bet amount may not be greater than your current balance");
                    }
                }
                catch
                {
                    if (bet.Text == "")
                    {
                        MessageBox.Show("Please enter a bet amount");
                    }
                }
                textBox1.Clear();
            }
            else
            {

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(betAmount == 0)
            {
                MessageBox.Show("Please enter a bet amount");
            }
            else
            {
                if (round == 1)
                {
                    Round1();
                }
                else
                {
                    Round2();
                }
            }
        }
        private void reset_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Round 1 - Good Luck";
            balance = 100;
            lblBalance.Text = balance.ToString();
            round = 1;
            lblRound.Text = round.ToString();
            point = 0;
            lblPoint.Text = "0";
            bet.Text = "";
            textBox1.Clear();
            betAmount = 0;
        }
    }
}
