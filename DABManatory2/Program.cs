using System;
using System.Linq;
using System.Runtime.InteropServices;
using DABMandatory2;
using DABMandatory2.Entities;
using DABMandatory2.Repository.Implementation;
using Microsoft.EntityFrameworkCore.Internal;

namespace DABManatory2
{
    class Program
    {
        static void Main(string[] args)
        {
            var uow = new UnitOfWork();
            Console.WriteLine("Hello user! What do you want to do? " +
                              "(You have a limited amount of possibilities)");
            Console.WriteLine("Press Z for a list of students");
            Console.WriteLine("Press X for a list of courses");
            Console.WriteLine("Press C for a list of students and his courses and grades");
            Console.WriteLine("Press V for a list of students and teachers assigned to a course");
            Console.WriteLine("Press B for a list of course content to a course");
            Console.WriteLine("Press N to see a list of a students assignments");

            var choice = Console.ReadKey();

            switch (choice.Key)
            {
                case ConsoleKey.Z:
                {
                    var students = uow.StudentRepository.GetAll();
                    foreach (var variable in students)
                    {
                        Console.WriteLine("Name: {0}", variable.Name);
                    }
                    break;
                }
                case ConsoleKey.X:
                {
                    var courses = uow.CourseRepository.GetAll();
                    foreach (var course in courses)
                    {
                        Console.WriteLine("Course ID:{0}", course.Course_ID);
                    }
                    break;
                }
                case ConsoleKey.C:
                {
                    Console.WriteLine("Write the id for a student (A default one could be au590761)");
                    var id = Console.ReadLine();
                    var list = uow.StudentRepository.GetEnrolledToByStudentId(id);
                    foreach (var variable in list)
                    {
                        Console.WriteLine("ID: {0} | CourseID: {1} | Grade: {2} | ActiveOrPassed: {3}",
                        variable.AU_ID, variable.Course_ID, variable.Grade, variable.ActiveOrPassed);
                    }
                    break;
                }
                case ConsoleKey.V:
                {
                    Console.WriteLine("Enter a course ID to see the assigned " +
                                      "students and teachers (Default = I4DAB )");
                    var courseID = Console.ReadLine();
                    var list = uow.CourseRepository.GetAssignees(courseID);
                    foreach (var student in list.Item1)
                    {
                        Console.WriteLine("Student ID: {0}",student.AU_ID);
                    }

                    foreach (var teacher in list.Item2)
                    {
                        Console.WriteLine("Teacher ID: {0}", teacher.Teacher_ID);
                    }
                    break;
                }
                case ConsoleKey.B:
                {
                    Console.WriteLine("Enter a course ID to see the course content (Default = I4DAB )");
                    var courseID = Console.ReadLine();
                    var list = uow.CourseRepository.GetCourseContent(courseID);
                    foreach (var content in list)
                    {
                        Console.WriteLine("Content id: {0}", content.Content_ID);   
                    }

                    break;
                }
                case ConsoleKey.N:
                {
                    Console.WriteLine("Enter a student id (Default = au590761 )");
                    var studID = Console.ReadLine();
                    Console.WriteLine("Enter a course id (Default = I4DAB )");
                    var courseID = Console.ReadLine();

                    var list = uow.StudentRepository.GetStudentAssignments(studID, courseID);
                    foreach (var variable in list)
                    {
                        Console.WriteLine("AssignmentID: {0} | Grade: {1} | Graded by: {2}", variable.Assignment_ID,
                            variable.Grade, variable.Teacher_ID);
                    }

                    break;
                }

                
            }


        }

    }
}
