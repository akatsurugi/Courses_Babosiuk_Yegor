using System;
using System.Collections.Generic;
using static _5_HW.Program;

namespace _5_HW
{
    internal partial class Program
    {
        public class Student : Human
        {
            // First name, last name, age, city, courses attended (an array of courses).

            public List<Course> Courses = new List<Course>();

            public Student(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city) { }

            public Student(string firstName, string lastName, int age, string city, List<Course> courses) 
                : base(firstName, lastName, age, city)
            {
                Courses = courses;
            }

            public void DescribeYourself(bool addAdditionalInfo = true)
            {
                base.DescribeYourself();

                if (Courses != null && Courses.Count > 0)
                {
                    if (addAdditionalInfo)
                    {
                        foreach (var course in Courses)
                        {
                            Console.WriteLine("-------------");
                            Console.WriteLine($"Courses info");
                            course.DisplayCourses();
                        }
                    }
                }
                Console.WriteLine();
            }

            public void Add(object obj)
            {
                if (obj == null) return;

                if (obj is Course)
                    Courses.Add((Course)obj);
            }

            public void Remove(object obj)
            {
                if (obj == null) return;

                if (obj is Course)
                    Courses.Remove((Course)obj);
            }

            public int CollectionCount(object obj)
            {
                if (obj == null) return 0;

                if (obj is List<Course>)
                    return Courses.Count;

                return 0;
            }
        }
    }
}
