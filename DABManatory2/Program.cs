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
