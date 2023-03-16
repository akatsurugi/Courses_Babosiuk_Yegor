using System;
using System.Linq;

namespace _4_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
-Write a C# method to compute the sum of all the elements of an array of integers
- Write a C# method to get the larger value from array
            */

            int[] intValues = { 0, 5, 2 };
            Console.WriteLine($"Max Value from array {string.Join(" ", intValues)} is {MaxValue(intValues)}");

            Console.WriteLine($"Min Value from array {string.Join(" ", intValues)} is {MinValue(intValues)}");

            //Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same 
            Console.WriteLine($"Nearby value is {NearestValueTo(20, 19, 22)}");

            //Write a C# method to compute the sum of all the elements of an array of integers
            Console.WriteLine($"Sum of values is {SumValue(intValues)}");
        }

        public static int MaxValue(int[] intValues)
        {
            if (intValues == null || intValues.Count() == 0)
            {
                return -1;
            }

            var maxValue = intValues[0];
            foreach (var value in intValues)
            {
                if (value > maxValue)
                {
                    maxValue = value;
                }
            }

            return maxValue;
        }

        public static int MinValue(int[] intValues)
        {
            if (intValues == null || intValues.Count() == 0)
            {
                return -1;
            }

            var minValue = intValues[0];
            foreach (var value in intValues)
            {
                if (value < minValue)
                {
                    minValue = value;
                }
            }

            return minValue;
        }

        public static int NearestValueTo(int compareVal, int x, int y)
        {
            var ch1 = Math.Abs(compareVal - x);
            var ch2 = Math.Abs(compareVal - y);
            if (ch1 == ch2)
            {
                return 0;
            }
            if (ch1 > ch2)
            {
                return y;
            }
            else
            {
                return x;
            }
        }

        public static int SumValue(int[] intValues)
        {
            var sum = 0;
            foreach ( var a in intValues)
            {
                sum += a;
            }
            return sum;
        }




    }
}
