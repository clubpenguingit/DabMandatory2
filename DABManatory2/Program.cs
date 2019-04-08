using System;
using System.Linq;
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

            Console.WriteLine("Hello World!");
            var r = new StudentRepository(new BlackBoardContext());
            var yyy = new BlackBoardContext();

            var uow = new UnitOfWork();
          
            uow.PrintStudentAssignments("589973", "Mandatory 2");
            

            return;
            yyy.Calendars.Add(new Calendar(){Calendar_ID = "DABKal",Course = null, Course_ID = "DAB", Deadlines = null, Handins = null, LectureDates = null,});
            yyy.SaveChanges();
        }
    }
}
