using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTest
{
    public class PokerDealer
    {
        string[] hands =
            {
                "High Card", "One Pair", "Two Pair", "Three of a Kind", "Straight", "Flush",
                "Full House", "Four of a Kind", "Straight Flush", "Royal Flush"
            };

        public void DealCards(int hand1, int hand2, string name1, string name2)
        {
            Random randomHand = new Random();

            hand1 = randomHand.Next(hands.Length);
            hand2 = randomHand.Next(hands.Length);

            Console.WriteLine("Player 1, " + name1 + "'s hand: " + hands[hand1]);
            Console.WriteLine("Player 2, " + name2 + "'s hand: " + hands[hand2]);

            CheckWinner(hand1, hand2, name1, name2);
        }

        public int CheckWinner(int win1, int win2, string name1, string name2)
        {
            int winner;

            if (win1 > win2)
            {
                winner = win1;
                Console.WriteLine("Winner: " + name1 + " (" + hands[winner] + ")");
            }
            else if (win1 < win2)
            {
                winner = win2;
                Console.WriteLine("Winner: " + name2 + " (" + hands[winner] + ")");
            }
            else
            {
                winner = win1 = win2;
                Console.WriteLine("It's a tie!");
            }

            return winner;
        }
    }
}
