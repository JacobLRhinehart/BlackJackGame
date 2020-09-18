using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackProject
{
    class ProgramUI
    {

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
                  "2. Continue to play!\n" +
                  "3. Exit the game!");

                //Get users input

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        GameMenu();
                        break;
                    case "2":
                        break;
                    case "3":
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
                    "1. Hit\n" +
                    "2. Stay\n" +
                    "3. Exit");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Hit();
                        break;
                    case "2":
                        Stay();
                        break;
                    case "3":
                        Console.WriteLine("Thank you for playing Blackjack!");
                        Console.ReadKey();
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please choose an option, 1-3.");
                        break;
                }
            }


        }

        public void Hit()
        {
            CardValueGenerator cardValueGenerator = new CardValueGenerator();
            int cardValueGenerator.Deal


        }

        public void Stay()
        {

        }



    }
}


