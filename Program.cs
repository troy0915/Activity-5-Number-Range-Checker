using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity_5_Number_Range_Checke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int evenCount = 0;
            int oddCount = 0;
            int divisibleByFiveCount = 0;
            Console.WriteLine("Please enter 10 integers:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Integer {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    Console.Write($"Integer {i + 1}: ");
                }
            }
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }

                if (number % 5 == 0)
                {
                    divisibleByFiveCount++;
                }
            }
            Console.WriteLine("\nCount Results:");
            Console.WriteLine($"Even numbers: {evenCount}");
            Console.WriteLine($"Odd numbers: {oddCount}");
            Console.WriteLine($"Divisible by 5: {divisibleByFiveCount}");
        }
    }
}




