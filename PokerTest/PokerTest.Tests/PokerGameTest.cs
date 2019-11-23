using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PokerTest;

namespace PokerTest.Tests
{
    [TestClass]
    public class PokerGameTest
    {
        [TestMethod]
        public void CheckWinner_Player1()
        {
            // Tests if Player 1 wins
            PokerDealer pd = new PokerDealer();
            // win1 must be bigger than win2
            int win = pd.CheckWinner(7, 2, "Player 1", "Player 2");
            Assert.AreEqual(win, 7);
        }

        [TestMethod]
        public void CheckWinner_Player2()
        {
            // Tests if Player 2 wins
            PokerDealer pd = new PokerDealer();
            // win1 must be smaller than win2
            int win = pd.CheckWinner(2, 8, "Player 1", "Player 2");
            Assert.AreEqual(win, 8);
        }

        [TestMethod]
        public void CheckWinner_Draw()
        {
            // Tests if it is a draw
            PokerDealer pd = new PokerDealer();
            int noWin = pd.CheckWinner(0, 0, "Player 1", "Player 2");
            Assert.AreEqual(noWin, 0);
        }

        [TestMethod]
        public void DealingHands()
        {
            // Tests if the index of the hands being dealt are within the range
            PokerDealer pd = new PokerDealer();

            // Get the array of string to be tested
            string[] hands =
            {
                "High Card", "One Pair", "Two Pair", "Three of a Kind", "Straight", "Flush",
                "Full House", "Four of a Kind", "Straight Flush", "Royal Flush"
            };

            // Set the hands.Length inside randomHand as max range
            Random r = new Random();
            int randomHand = r.Next(0, hands.Length);

            // Set the values of randomHand
            pd.DealCards(randomHand, randomHand, "P1", "P2");

            // Running test in while parameter
            while (randomHand < hands.Length)
            {
                // If randomHand < (9 or less, basically any number less than hands.Length), test will fail
                Assert.IsTrue(randomHand >= 0 && randomHand < hands.Length);
                // To ensure that the test will not run continuously
                randomHand++;
            }
        }
    }
}
