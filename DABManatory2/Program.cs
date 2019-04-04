using System;
using DABMandatory2;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore.Internal;

namespace DABManatory2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var yyy = new BlackBoardContext();
            yyy.Calendars.Add(new Calendar(){Calendar_ID = "DABKal",Course = null, Course_ID = "DAB", Deadlines = null, Handins = null, LectureDates = null,});
            yyy.SaveChanges();
        }
    }
}
