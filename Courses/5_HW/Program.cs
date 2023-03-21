using System;
using System.Collections.Generic;
using System.Linq;
using static _5_HW.Program;

namespace _5_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student("Harry", "Potter", 18, "London");
            student.PrintData();

            var progCourse = new Course("Herbalogy", "Pomona Leaf");
            progCourse.AddStudent(student);
            progCourse.PrintData();
                
        }

        public class Course
        {
            public string Name { get; private set; }
            public string TeacherName { get; private set; } 
            public int Duration { get; private set; }
            public List<Student> Students { get; private set; }

            public Course(string name, string teacherName, int duration = 120)
            {
                Name = name;
                TeacherName = teacherName;
                Duration = duration;
                Students = new List<Student>();
            }

            public Course(string name, string teacherName, List<Student> students, int duration = 120) : this (name, teacherName, duration)
            {
                Students = students;
            }

            public void AddStudent(Student student)
            {
                Students.Add(student);
            }

            public void PrintData()
            {
                Console.WriteLine($"Name {Name}");
                Console.WriteLine($"TeacherName {TeacherName}");
                Console.WriteLine($"Duration {Duration}");
               
                foreach (var student in Students)
                {
                    student.PrintData();
                }
            }
        }

        public class Student
        {
            // First name, last name, age, city, courses attended (an array of courses).
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public int Age { get; private set; }
            public string City { get; private set; }
            public List<string> Courses { get; private set; }

            public Student(string firstName, string lastName, int age, string city)
            {
                FirstName = firstName;
                LastName = lastName;
                Age = age;
                City = city;
                Courses = new List<string>();
            }

            public Student(string firstName, string lastName, int age, string city, List<string> courses) 
                : this(firstName, lastName, age, city)
            {
                Courses = courses;
            }

            public void AddCourse(string courseName)
            {
                Courses.Add(courseName);
            }

            public void PrintData()
            {
                Console.WriteLine($"FirstName {FirstName}");
                Console.WriteLine($"LastName {LastName}");
                Console.WriteLine($"Age {Age}");
                Console.WriteLine($"City {City}");

                if (Courses != null || Courses.Count > 0)
                {
                    Console.WriteLine($"Courses {string.Join(" ", Courses)}");
                }
            }
        }
    }
}
