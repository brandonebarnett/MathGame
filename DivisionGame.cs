using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class DivisionGame
    {
        public static int answersCorrect = 0;

        public static void ShowGame(List<string> games)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Welcome to the Division Game");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            GenerateQuestion();

            games.Add($"{DateTime.Now} - Division - Score = {answersCorrect}");
            Console.WriteLine($"You got {answersCorrect} out of the 5 available questions.");
            answersCorrect = 0;
            Console.ReadLine();
        }

        private static void GenerateQuestion()
        {
            int[] generatedDivision;
            int question = 1;

            while (question <= 5)
            {
                generatedDivision = GenerateNumbers.RandomNumbers();
                while (generatedDivision[1] == 0 || generatedDivision[0] % generatedDivision[1] != 0)
                {
                    generatedDivision = GenerateNumbers.RandomNumbers();
                }
                Console.WriteLine($"Question #{question} : {generatedDivision[0]} / {generatedDivision[1]}");
                bool isValid = int.TryParse(Console.ReadLine(), out int answer);
                CheckAnswer(generatedDivision[0], generatedDivision[1], answer);
                question++;
            }
        }

        private static void CheckAnswer(int numberOne, int numberTwo, int userAnswer)
        {

            int correctAnswer = numberOne / numberTwo;

            if (correctAnswer == userAnswer)
            {
                Console.WriteLine("You are correct!");
                answersCorrect++;
            }
            else
            {
                Console.WriteLine("You are not correct.");
            }
        }
    }
}
