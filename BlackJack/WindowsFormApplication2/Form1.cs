using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {        
        List<Card> DHand;
        List<Card> PHand;
        bool inProgress = false;
        DeckOfCards deck;

        private string printHand(List<Card> hand)
        {
            string DisplayHand = "";
            for (int i = 0; i < hand.Count; i++)
            {
                
                DisplayHand += hand[i].toSuite();
            }

            return DisplayHand;
        }

        private int handTotal(List<Card> hand)
        {
            int total = 0;
           
            for (int i = 0; i < hand.Count; i++)
            {
                total = total + hand[i].dealSum();
            }            

            if(total > 21)
            {
                bool foundAce = false;
                for (int i = 0; i < hand.Count; i++)
                {
                    if (hand[i].dealSum() == 11 && !foundAce)
                    {
                        total = total - 10;
                        foundAce = true;
                    }
                }
            }

            return total;
        }

        private void winner(int DTotal, int PTotal)
        {
            if(DealersHand.Text == " |♣ J| |♥ A|" || DealersHand.Text == " |♣ J| |♦ A|" || DealersHand.Text == " |♣ J| |♠ A|" || DealersHand.Text == " |♣ J| |♣ A|"||
               DealersHand.Text == " |♠ J| |♥ A|" || DealersHand.Text == " |♠ J| |♦ A|" || DealersHand.Text == " |♠ J| |♠ A|" || DealersHand.Text == " |♠ J| |♣ A|"||
               DealersHand.Text == " |♥ A| |♠ J|" || DealersHand.Text == " |♦ A| |♠ J|" || DealersHand.Text == " |♠ A| |♠ J|" || DealersHand.Text == " |♣ A| |♠ J|"||
               DealersHand.Text == " |♥ A| |♣ J|" || DealersHand.Text == " |♦ A| |♣ J|" || DealersHand.Text == " |♠ A| |♣ J|" || DealersHand.Text == " |♣ A| |♣ J|")
            {
                MessageBox.Show("Black Jack... Dealer won :(");
                betting(0);
            }
            else if (PlayersHand.Text == " |♣ J| |♥ A|" || PlayersHand.Text == " |♣ J| |♦ A|" || PlayersHand.Text == " |♣ J| |♠ A|" || PlayersHand.Text == " |♣ J| |♣ A|" ||
                     PlayersHand.Text == " |♠ J| |♥ A|" || PlayersHand.Text == " |♠ J| |♦ A|" || PlayersHand.Text == " |♠ J| |♠ A|" || PlayersHand.Text == " |♠ J| |♣ A|" ||
                     PlayersHand.Text == " |♥ A| |♠ J|" || PlayersHand.Text == " |♦ A| |♠ J|" || PlayersHand.Text == " |♠ A| |♠ J|" || PlayersHand.Text == " |♣ A| |♠ J|" ||
                     PlayersHand.Text == " |♥ A| |♣ J|" || PlayersHand.Text == " |♦ A| |♣ J|" || PlayersHand.Text == " |♠ A| |♣ J|" || PlayersHand.Text == " |♣ A| |♣ J|")
            {
                MessageBox.Show("Black Jack! You Won!");
                betting(2);
            }

            else if (PTotal > 21)
            {
                MessageBox.Show("Dealer won. :(");
                betting(0);
            }
            else if (DTotal > 21 && PTotal <= 21)
            {
                MessageBox.Show("You Won!");
                betting(1);
            }
            else if (PTotal <= 21 && PTotal > DTotal)
            {
                MessageBox.Show("You Won!");
                betting(1);                
            }
            else
            {
                MessageBox.Show("Dealer Won. :(");
                betting(0);
            }

            startOver();
        }

        private void betting(int whoWon)
        {
            int Total = 0;

            if (whoWon == 1)
            {
                Total = Int32.Parse(TotalMoney.Text) + Int32.Parse(Bet.Text);
                TotalMoney.Text = Total.ToString();
            }
            else if(whoWon == 0)
            {
                Total = Int32.Parse(TotalMoney.Text) - Int32.Parse(Bet.Text);
                TotalMoney.Text = Total.ToString();
            }
            else if(whoWon == 2)
            {
                Total = Int32.Parse(TotalMoney.Text) + (Int32.Parse(Bet.Text) * 2);
                TotalMoney.Text = Total.ToString();
            }

            if(Int32.Parse(TotalMoney.Text) == 0)
            {
                MessageBox.Show("Your out of money! Click OK to restart.");
                TotalMoney.Text = "100";
                startOver();
            }

        }

        public void startOver()
        {
            inProgress = false;
            deck.shuffle();

            PlayersHand.Text = "";
            DealersHand.Text = "";

            DealersTotal.Text = "";
            PlayersTotal.Text = "";

            PHand = new List<Card>();
            DHand = new List<Card>();

            DealerTotal.Text = "";
            PlayerTotal.Text = "";
        }
        
        public Form1()
        {
            DHand = new List<Card>();
            PHand = new List<Card>();
            deck = new DeckOfCards();
            InitializeComponent();

            deck.shuffle();
            TotalMoney.Text = "100";
        }

        private void BetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Stay_Click(object sender, EventArgs e)
        {
            while (handTotal(DHand)<17)
            {
                DHand.Add(deck.dealCard());
                DealersHand.Text = printHand(DHand);
                DealerTotal.Text = handTotal(DHand).ToString();
            }
            winner(handTotal(DHand),handTotal(PHand));                       
        }

        private void Deal_Click(object sender, EventArgs e)
        {
            if (inProgress)
            {
                MessageBox.Show("You have to finish the current game first.");
            }
            else if (Bet.Text == "")
            {
                MessageBox.Show("Enter how much you want to bet first.");
            }
            else if (Int32.Parse(Bet.Text) > Int32.Parse(TotalMoney.Text))
            {
                MessageBox.Show("You don't have enouph chips to bet that much!");
            }
            else
            {                
                DHand.Add(deck.dealCard());
                //DHand.Add(deck.dealCard());

                PHand.Add(deck.dealCard());
                PHand.Add(deck.dealCard());

                DealerTotal.Text = handTotal(DHand).ToString();
                PlayerTotal.Text = handTotal(PHand).ToString();

                DealersHand.Text = printHand(DHand);
                PlayersHand.Text = printHand(PHand);
                inProgress = true;
            }
            

        }

        private void DealersHand_TextChanged(object sender, EventArgs e)
        {

        }

        private void DealerTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void PlayerTotal_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void Hit_Click(object sender, EventArgs e)
        {
            if (inProgress != false)
            {
                PHand.Add(deck.dealCard());
                PlayersHand.Text = printHand(PHand);

                if (handTotal(PHand) > 21)
                {
                    PlayerTotal.Text = handTotal(PHand).ToString();
                    Stay_Click(sender,e);
                }
                else
                {
                    PlayerTotal.Text = handTotal(PHand).ToString();
                }
            }
        }

        private void TotalMoney_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CashOut_Click(object sender, EventArgs e)
        {
            int score = Int32.Parse(TotalMoney.Text);

            string path = Environment.CurrentDirectory;

            path = path + "\\score.txt";

            String[] text = File.ReadAllLines("score.txt");

            if (Int32.Parse(text[0]) < score)
            {
                text[2] = text[1];
                text[1] = text[0];
                text[0] = score.ToString();
                MessageBox.Show("You have the new high score of " + score + "!");
                startOver();
                TotalMoney.Text = "100";
            }
            else if(Int32.Parse(text[1]) < score)
            {
                text[2] = text[1];
                text[1] = score.ToString();
                MessageBox.Show("You have the 2nd highest score of " + score + "!");
                startOver();
                TotalMoney.Text = "100";
            }
            else if (Int32.Parse(text[2]) < score)
            {
                text[2] = score.ToString();
                MessageBox.Show("You have the 3rd highest score of " + score + "!");
                startOver();
                TotalMoney.Text = "100";
            }
            else
            {
                MessageBox.Show("High score: " + text[0] + Environment.NewLine + "Second highest score: " + text [1] + Environment.NewLine + "Third highest score: " + text[2] +Environment.NewLine + "You do not have a high score.");
            }
            File.WriteAllLines("score.txt", text);
        }
    }
}
