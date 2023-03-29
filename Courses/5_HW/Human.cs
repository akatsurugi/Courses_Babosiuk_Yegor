using System;

namespace _5_HW
{
    internal partial class Program
    {
        public class Human
        {
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public int Age { get; private set; }
            public string City { get; private set; }

            public Human(string firstName, string lastName, int age, string city)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                City = city;
            }

            public void DescribeYourself()
            {
                Console.WriteLine($"FirstName {FirstName}");
                Console.WriteLine($"LastName {LastName}");
                Console.WriteLine($"Age {Age}");
                Console.WriteLine($"City {City}");
            }
        }
    }
}
