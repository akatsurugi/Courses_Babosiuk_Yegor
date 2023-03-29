using System;
using System.Collections.Generic;
using static _5_HW.Program;

namespace _5_HW
{
    internal partial class Program
    {
        public class Course
        {
            public string Name { get; private set; }

            public List<Teacher> Teachers { get; private set; } = new List<Teacher>();
            public int Duration { get; private set; }
            public List<Student> Students { get; private set; } = new List<Student>();

            public Course(string name, int duration = 120)
            {
                Name = name;
                Duration = duration;
                Students = new List<Student>();
            }

            public Course(string name, List<Student> students, int duration = 120) : this (name, duration)
            {
                Students = students;
            }

            public void Add(object obj)
            {
                if (obj == null) return;

                if (obj is Student)
                    Students.Add((Student)obj);
                if (obj is Teacher)
                    Teachers.Add((Teacher)obj);
            }

            public void Remove(object obj)
            {
                if (obj == null) return;

                if (obj is Student)
                    Students.Remove((Student)obj);
                if (obj is Teacher)
                    Teachers.Remove((Teacher)obj);
            }

            public int CollectionCount(object obj)
            {
                if (obj == null) return 0;

                if (obj is List<Student>)
                    return Students.Count;
                if (obj is List<Teacher>)
                    return Teachers.Count;

                    return 0;
            }

            public void DisplayCourses()
            {
                try
                {
                    Console.WriteLine($"Name {Name}");
                    Console.WriteLine($"Duration {Duration}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            public void PrintData()
            {
                try
                {
                    Console.WriteLine($"Name {Name}");
                    Console.WriteLine($"Duration {Duration}");

                    Console.WriteLine("=====Students======");
                    foreach (var student in Students)
                    {
                        student.DescribeYourself(false);
                    }

                    Console.WriteLine("=====Teachers======");
                    foreach (var teacher in Teachers)
                    {
                        teacher.DescribeYourself(false);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }
    }
}
