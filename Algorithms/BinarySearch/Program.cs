using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Enumerable.Range(1, 100).Select(i => i).ToArray();
            Console.WriteLine("Total numbers: " + numbers.Length);
            int targetNumber = 87;
            Console.WriteLine("Target number: " + targetNumber);
            Console.WriteLine(new string('-', 75));
            BinarySearchAlgorithm(numbers, targetNumber);
        }

        private static void BinarySearchAlgorithm(int[] numbers, int targetNumber)
        {
            int lowNumber = numbers[0];
            int highNumber = numbers[^1];
            int steps = 0;

            while (lowNumber <= highNumber)
            {
                steps++;
                int guess = (lowNumber + highNumber) / 2;

                Console.Write($"Step {steps} - ");
                if (guess == targetNumber)
                {
                    Console.WriteLine($"Found [{targetNumber}]");
                    break;
                }

                if (guess > targetNumber)
                {
                    Console.Write($"Guess number: [{guess}] is too high! ");
                    highNumber = guess - 1;
                    Console.WriteLine($"High number changed to: [{ highNumber}].");
                    Console.WriteLine(new string('-', 75));
                }
                else
                {
                    Console.Write($"Guess number: [{guess}] is too low! ");
                    lowNumber = guess + 1;
                    Console.WriteLine($"Low number changed to: [{lowNumber}].");
                    Console.WriteLine(new string('-', 75));
                }
            }
        }
    }
}
