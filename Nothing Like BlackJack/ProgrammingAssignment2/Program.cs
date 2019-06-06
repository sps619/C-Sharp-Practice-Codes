using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingAssignment2
{
    /// <summary>
    /// Programming Assignment 2 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Deals 2 cards to 3 players and displays cards for players
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // TODO: Move this function to Player.cs
            // Generate Players and add them to a list
            List<Player> players = new List<Player>();

            Player player1 = new Player();
            players.Add(player1);
            Player player2 = new Player();
            players.Add(player2);
            Player player3 = new Player();
            players.Add(player3);


            // print welcome message
            Console.WriteLine("Welcome to Nothing Like Blackjack");
            Console.WriteLine();
            // create and shuffle a deck
            Deck deck = new Deck();
            deck.Shuffle();

            // deal 2 cards each to 3 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)
            int numberOfCards = 2;
            for (int i = 0; i < numberOfCards; i++)
            {
                foreach (Player player in players)
                {
                    player.AddCardToHand(deck.TakeTopCard());
                }
            }


            // flip all the cards over
            foreach (Player player in players)
            {
                foreach (Card card in player.Cards)
                {
                    card.FlipOver();
                }
            }

            // print the cards for player 1
            // print the cards for player 2
            // print the cards for player 3
            // TODO: create print function for card that includes rank and suit
            for (int i = 0; i < players.Count; i++)
            {
                Console.WriteLine("Player " + (i + 1).ToString() + " has:");
                foreach (Card card in players[i].Cards)
                {
                    Console.WriteLine(card.Rank + " of " + card.Suit);
                }
                Console.WriteLine();
            }

            Console.WriteLine("Thanks for playing!");

            Console.WriteLine();
        }
    }
}
