using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject
{
    class ProgramUI
    {
        CardValueGenerator cardValueGenerator = new CardValueGenerator();

        public void Run()
        {
            Menu();
        }
        // Menu

        private void Menu()
        {
            bool keepRunning = true;


            while (keepRunning)
            {
                Console.WriteLine("Welcome to Blackjack!!!\n" +
                  "1. Play a new game of Blackjack!\n" +
                  "2. Exit the game!");

                //Get users input

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        GameMenu();
                        break;
                    case "2":
                        Console.WriteLine("Thank you for playing Blackjack!");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please choose an option, 1-3.");
                        break;
                }
            }
        }


        public void GameMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                Console.Clear();
                Console.WriteLine("Here We Go!\n" +
                    "1. Deal\n" +
                    "2. Hit\n" +
                    "3. Stay\n" +
                    "4. Main Menu");
                string input = Console.ReadLine();

                Players player = new Players();
                Players dealer = new Players();


                player.PlayerScore = 0;
                dealer.DealerScore = 0;
                switch (input)
                {
                    case "1":
                        // dealerHand = cardGen...Hit(dealerHand)
                        dealer.DealerScore = Cards();
                        Console.WriteLine("Dealer score: " + dealer.DealerScore);
                        Console.ReadKey();
                        // Dealer is showing: dealerHand
                        player.PlayerScore = Cards();
                        Console.WriteLine("Player score: " + player.PlayerScore);
                        Console.ReadKey();
                        // Display player hand
                        break;
                    case "2":
                        player.PlayerScore = Hit(player.PlayerScore);
                        // Display player hand
                        if (player.PlayerScore > 21)
                        {
                            Console.WriteLine("You busted");
                        }
                        keepRunning = false;
                        break;
                    case "3":
                        dealer.DealerScore = Stay();
                        if (player.PlayerScore == 21 && dealer.DealerScore == 21)
                        {
                            Console.WriteLine("Push");
                        }
                        else
                        {
                            if (dealer.DealerScore < 22)
                            {
                                if (dealer.DealerScore > player.PlayerScore)
                                { 
                                    Console.WriteLine("You lose."); 
                                }
                                // compare dealer to player to determine winner
                            }
                            else
                            { //dealer busted, player wins

                                Console.WriteLine("You WIN!!!");
                            }
                        }
                        break;
                    case "4":
                        Console.WriteLine("Thank you for playing Blackjack!");
                        Console.ReadKey();
                        keepRunning = false;
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("Please choose an option, 1-4.");
                        break;
                }
            }


        }

        public int Stay()
        {
            int dealerHand = cardValueGenerator.Deal();
            while (dealerHand < 16)
            {
                dealerHand = cardValueGenerator.Hit(dealerHand);
            }
            return dealerHand;
        }

        public int Cards()
        {
            int playerCards = cardValueGenerator.Deal();
            return playerCards;
        }

        public int Hit(int playerHand)
        {
            int playerCards = cardValueGenerator.Hit(playerHand);
            return playerHand;
        }
    }
}



