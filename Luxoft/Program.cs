using System;
using System.Collections.Generic;
using System.Linq;

namespace Luxoft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input min:");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input max:");
            int max = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input sum:");
            int targetlSum = Convert.ToInt32(Console.ReadLine());

            List<int> result = CheckSequence(min, max, targetlSum);

            Console.WriteLine("Result: {0}", string.Join(" ", result));
        }

        private static List<int> CheckSequence(int min, int max, int targetlSum)
        {
            List<int> result = new List<int>();

            ParametrsCheck(ref min, ref max, ref targetlSum);

            for (int i = min; i < max + 1; i++)
            {
                var numbers = SplitNumber(i);
                int intermediateSum = numbers.Sum();
                if (intermediateSum == targetlSum)
                    result.Add(i);
            }

            return result;
        }

        public static List<int> SplitNumber(int number)
        {
            List<int> digitsList = new List<int>();

            while (number > 0)
            {
                digitsList.Add(number % 10);
                number /= 10;
            }

            return digitsList;
        }

        private static void ParametrsCheck(ref int min, ref int max, ref int targetlSum)
        {
            if (min < 0)
            {
                min *= -1;
            }

            if (max < 0)
            {
                max *= -1;
            }

            if (targetlSum < 0)
            {
                targetlSum *= -1;
            }
        }
    }
}
