using System;

namespace Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            Console.WriteLine($"Print the result of dividing two numbers : {10 / 2}");
            

            //-- print the result of the specified operations 
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

            //-- swap two numbers

            int x = 5;
            int y = 6;

            Console.WriteLine($"First Number: {x}");
            Console.WriteLine($"Second Number: {y}");

            Console.WriteLine("Swap");
            int z = x;
            x = y;
            y = z;

            Console.WriteLine($"First Number: {x}");
            Console.WriteLine($"Second Number: {y}");

            Console.WriteLine("Input the first number to multiply:");
            x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number to multiply:");
            y = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Input the third number to multiply:");
            z = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Result: {x * y * z}");
        }
    }
}
