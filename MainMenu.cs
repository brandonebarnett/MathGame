using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class MainMenu
    {
        List<string> gameHistory = new List<string>();
        public bool isGameRunning = true;

        public void DisplayMenu(string name)
        {
            do
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"Hello {name}.");
                Console.WriteLine(@"What math game would you like to play today?  Choose from the options below:
1. Addition
2. Subtraction
3. Multiplication
4. Division
5. Game History
6. Quit");
                Console.WriteLine("-------------------------------------");

                GameSelection();
            } while (isGameRunning);
        }

        private void GameSelection()
        {
            bool isValid = int.TryParse(Console.ReadLine(), out int userSelection);

            switch (userSelection)
            {
                case 1:
                    AdditionGame.ShowGame(gameHistory);
                    break;
                case 2:
                    // SubtractionGame
                    break;
                case 3:
                    // MultiplicationGame
                    break;
                case 4:
                    // DivisionGame
                    break;
                case 5:
                    GameHistory();
                    break;
                case 6:
                    Console.WriteLine("Thank you for playing!");
                    isGameRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid selection, please try again.");
                    break;
            }
            Console.Clear();
        }

        private void GameHistory()
        {
            Console.Clear();
            Console.WriteLine("Game History");
            Console.WriteLine("------------------------------------");
            foreach (string game in gameHistory)
            {
                Console.WriteLine(game);
            }
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadLine();
        }
    }
}
