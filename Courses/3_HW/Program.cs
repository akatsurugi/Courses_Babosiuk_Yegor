using System;

namespace _3_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Write a C# program to check two given integers and return true if one is negative and one is positive.
            Console.WriteLine("Input first integer:");
            var firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            var secondInt = int.Parse(Console.ReadLine());

            Console.WriteLine("Check if one is negative and one is positive:");
            Console.WriteLine(firstInt < 0 && secondInt >= 0);

            //- Write a C# program to check the sum of the two given integers
            //and return true if one of the integer is 20 or if their sum is 20.
            Console.WriteLine("Check the sum of the two given integers");
            Console.WriteLine("Input first integer:");
            firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            secondInt = int.Parse(Console.ReadLine());

            Console.WriteLine(firstInt == 20 || secondInt == 20 || firstInt + secondInt == 20);

            //Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.

            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Write a C# program to compute the sum of the first 500 prime numbers.
            int num = 2;
            int sum = 0;
            int primeNumberCounter = 0;
            do
            {
                if (IsNumPrime(num))
                {
                    sum += num;
                    primeNumberCounter++;
                }
                num++;
            }
            while (primeNumberCounter < 500);


            Console.WriteLine($"sum of the first 500 prime numbers: {sum}");

            //Write a C# program and compute the sum of the digits of an integer.
            Console.WriteLine("sum of the digits of an integer. Write line with digits");
            var line = Console.ReadLine().ToCharArray();
            int sum1 = 0;
            for (int i = 0; i < line.Length; i++)
            {
                sum1 += int.Parse(line[i].ToString());
            }
            Console.WriteLine(sum1);
        }

        private static bool IsNumPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }

            int limit = (int)Math.Sqrt(number);
            for (int i = 2; i <= limit; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
