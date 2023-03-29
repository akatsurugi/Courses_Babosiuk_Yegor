using System;
using System.Collections.Generic;

namespace _5_HW
{
    internal partial class Program
    {
        public class Teacher : Human
        {
            public List<Student> Students { get; private set; } = new List<Student>();
            public List<Course> Courses { get; private set; } = new List<Course>();

            public Teacher(string firstName, string lastName, int age, string city) : base(firstName, lastName, age, city) { }

            public void DescribeYourself(bool addAdditionalInfo = true)
            {
                base.DescribeYourself();

                if (addAdditionalInfo)
                {
                    foreach (var course in Courses)
                    {
                        course.DisplayCourses();
                    }
                }
                
                Console.WriteLine();
            }

            public void Add(object obj)
            {
                if (obj == null) return;

                if (obj is Student)
                    Students.Add((Student)obj);
                if (obj is Course)
                    Courses.Add((Course)obj);
            }

            public void Remove(object obj)
            {
                if (obj == null) return;

                if (obj is Student) 
                    Students.Remove((Student)obj);
                if (obj is Course)
                    Courses.Remove((Course)obj);
            }

            public int CollectionCount(object obj)
            {
                if (obj == null) return 0;

                if (obj is List<Student>)
                    return Students.Count;
                if (obj is List<Course>) 
                    return Courses.Count;

                return 0;
            }

        }
    }
}
