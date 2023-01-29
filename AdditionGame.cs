using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class AdditionGame
    {
        public static int answersCorrect = 0;

        public static void ShowGame(List<string> games)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Welcome to the Addition Game");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            GenerateQuestion();

            games.Add($"{DateTime.Now} - Addition - Score = {answersCorrect}");
            Console.WriteLine($"You got {answersCorrect} out of the 5 available questions.");
            answersCorrect = 0;
            Console.ReadLine();
        }

        private static void GenerateQuestion()
        {
            int[] generatedAddition;
            int question = 1;

            while (question <= 5)
            {
                generatedAddition = GenerateNumbers.RandomNumbers();
                Console.WriteLine($"Question #{question} : {generatedAddition[0]} + {generatedAddition[1]}");
                bool isValid = int.TryParse(Console.ReadLine(), out int answer);
                CheckAnswer(generatedAddition[0], generatedAddition[1], answer);
                question++;
            }
        }

        private static void CheckAnswer(int numberOne, int numberTwo, int userAnswer)
        {

            int answer = numberOne + numberTwo;

            if (answer == userAnswer)
            {
                Console.WriteLine("You are correct!");
                answersCorrect++;
            }
            else
            {
                Console.WriteLine("You were not correct.");
            }
        }
    }
}
