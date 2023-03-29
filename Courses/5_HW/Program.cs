using System;
using System.Collections.Generic;
using System.Linq;
using static _5_HW.Program;

namespace _5_HW
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            var courses = new List<Course> {
                new Course("Transfiguration"),
                new Course("Defence Against the Dark Arts"),
                new Course("Dark Arts")
            };

            var students = new List<Student> {
                new Student("Lovegood", "Luna", 15, "London"),
                new Student("Longbottom", "Nevil", 15, "London"),
                new Student("Potter", "Harry", 16, "London")
            };

            var teachers = new List<Teacher>
            {
                new Teacher("Dumbledore", "Albus", 50, "London"),
                new Teacher("Moody", "Alastor", 60, "London"),
                new Teacher("Carrow", "Alecto", 40, "London")
            };

            teachers[0].Add(courses[0]);
            teachers[1].Add(courses[1]);
            teachers[2].Add(courses[2]);


            foreach (var student in students)
            {
                foreach (var course in courses)
                    student.Add(course);
            }

            foreach (var course in courses)
            {
                foreach(var student in students)
                {
                    course.Add(student);
                }
            }

            courses[0].Add(teachers[0]);
            courses[1].Add(teachers[1]);
            courses[2].Add(teachers[2]);

            // Output
            foreach(var student in students)
            {
                student.DescribeYourself();
            }

            Console.WriteLine("====== Teachers =======");            
            foreach(var teacher in teachers)
            {
                teacher.DescribeYourself();
            }

            Console.WriteLine("====== Courses =======");

            foreach (var course in courses)
            {
                course.PrintData();
            }

            Console.WriteLine("Find all students that has teacher by the name of student");
            Console.WriteLine("Write Teacher Name or Student");
            var name = Console.ReadLine();

            var filteredTeachers = teachers.Where(arg => arg.FirstName.Contains(name) || arg.LastName.Contains(name));
            
            foreach(var teacher in filteredTeachers)
            {
                teacher.DescribeYourself();
            }

            var filteredStudnets = students.Where(arg => arg.FirstName.Contains(name) || arg.LastName.Contains(name));

            foreach (var student in filteredStudnets)
            {
                student.DescribeYourself();
            }


        }
    }
}
