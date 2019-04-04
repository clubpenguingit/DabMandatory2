using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Remotion.Linq.Clauses;

namespace DABMandatory2.Repository.Implementation
{
    public class StudentRepository : Repository<Student>
    {
        public StudentRepository(BlackBoardContext blackboardDbContext) 
            : base(blackboardDbContext)
        {
          
        }
        
        public IEnumerable<IsEnrolledTo> GetEnrolledToByStudentId(string id)
        {
            return _context.Set<IsEnrolledTo>().Where(x => x.Student.AU_ID == id);
        }

        public IEnumerable<Assignments> GetStudentAssignments(string studId, string assignmentId)
        {
            return _context.Set<Assignments>()
                    .Where( a => a.AU_ID == studId && a.Assignment_ID == assignmentId)
                    .AsEnumerable().ToList();
        }

        public void PrintStudentAssignments(string studentId, string assignmentId)
        {
            var assignments = this.GetStudentAssignments("589973", "Mandatory 2").ToList();
            if (assignments.Any())
            {
                Console.WriteLine("Printing Assignment sheet");
                foreach (var assignment in assignments)
                {
                    Console.WriteLine($"Assignment: {assignment.Assignment_ID}\n" +
                                      $"Student: {assignment.AU_ID}\n" +
                                      $"Status: {assignment.Passed}" +
                                      $"Grade: {assignment.Grade}\n" +
                                      $"Graded by: {assignment.Teacher_ID}");
                }
            }
        }

        public void PrintEnrolledInto(string studentId)
        {
            var enrolled = this.GetEnrolledToByStudentId("589973").ToList();
            if (enrolled.Any())
            {
                Console.WriteLine("Printing Enrolled Sheet");
                foreach (var isEnrolledTo in enrolled)
                {
                    Console.WriteLine($"Student AU-Id is: {isEnrolledTo.AU_ID}\n" +
                                      $"Passed: {isEnrolledTo.ActiveOrPassed}\n" +
                                      $"Grade: {isEnrolledTo.Grade}\n");
                }
            }
        }

    }
}