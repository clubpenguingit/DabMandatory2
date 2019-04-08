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

        //public void PrintStudentAssignments(string studentId, string assignmentId)
        //{
        //    var assignments = StudentRepository.GetStudentAssignments(studentId, assignmentId).ToList();
        //    if (assignments.Any())
        //    {
        //        Console.WriteLine("Printing Assignment sheet");
        //        foreach (var assignment in assignments)
        //        {
        //            Console.WriteLine($"Assignment: {assignment.Assignment_ID}\n" +
        //                              $"Student: {assignment.AU_ID}\n" +
        //                              $"Status: {assignment.Passed}\n" +
        //                              $"Grade: {assignment.Grade}\n" +
        //                              $"Graded by: {assignment.Teacher_ID}");
        //        }
        //    }
        //}

        //public void PrintEnrolledInto(string studentId)
        //{
        //    var enrolled = StudentRepository.GetEnrolledToByStudentId(studentId).ToList();
        //    if (enrolled.Any())
        //    {
        //        Console.WriteLine("Printing Enrolled Sheet");
        //        foreach (var isEnrolledTo in enrolled)
        //        {
        //            Console.WriteLine($"Student AU-Id is: {isEnrolledTo.AU_ID}\n" +
        //                              $"Passed: {isEnrolledTo.ActiveOrPassed}\n" +
        //                              $"Grade: {isEnrolledTo.Grade}\n");
        //        }
        //    }
        //}
        static void Main(string[] args)
        {
            var uow = new UnitOfWork();
            Console.WriteLine("Hello user! What do you want to do? " +
                              "(You have a limited amount of possibilities)");
            Console.WriteLine("Press 1 for a list of students");
            Console.WriteLine("Press 2 for a list of courses");
            Console.WriteLine("Press 3 for a list of students and his courses and grades");
            Console.WriteLine("Press 4 for a list of students and teachers assigned to a course");
            Console.WriteLine("Press 5 for a list of course content to a course");
            Console.WriteLine("Press 6 to see a list of a students assignments");

            var choice = Console.ReadKey();

            switch (choice.Key)
            {
                case ConsoleKey.NumPad1:
                {
                    var students = uow.StudentRepository.GetAll();
                    foreach (var VARIABLE in students)
                    {
                        Console.WriteLine(VARIABLE.Name);
                    }
                    break;
                }
                case ConsoleKey.NumPad2:
                {
                    var courses = uow.CourseRepository.GetAll();
                    foreach (var VARIABLE in courses)
                    {
                        Console.WriteLine(VARIABLE);
                    }
                    break;
                }

                
            }


        }

    }
}
