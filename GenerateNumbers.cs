using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class GenerateNumbers
    {
        public static int[] generatedNumbers = new int[2];

        public static int[] RandomNumbers()
        {
            Random random = new Random();
            int numberOne = random.Next(0, 100);
            int numberTwo = random.Next(0, 100);

            generatedNumbers[0] = numberOne;
            generatedNumbers[1] = numberTwo;

            return generatedNumbers;
        }
    }
}
