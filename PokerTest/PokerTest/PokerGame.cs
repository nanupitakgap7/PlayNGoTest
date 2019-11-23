using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTest
{
    /// <summary>
    /// Solution for the Poker Test
    /// </summary>
    
    public class PokerGame
    {
        static void Main(string[] args)
        {
            // Names of the players
            string player1Name = "";
            string player2Name = "";

            // Entering player's names
            Console.Write("Enter Player 1: ");
            player1Name = Console.ReadLine();
            Console.Write("Enter Player 2: ");
            player2Name = Console.ReadLine();

            // Index for the players' hands
            int playerHand1 = 0;
            int playerHand2 = 0;

            // Poker simulation
            PokerDealer pd = new PokerDealer();
            pd.DealCards(playerHand1, playerHand2, player1Name, player2Name);

            Console.ReadLine();
        }
    }
}
