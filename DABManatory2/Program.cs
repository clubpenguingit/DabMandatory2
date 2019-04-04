using System;
using Castle.DynamicProxy.Generators.Emitters.SimpleAST;
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
            AddDataToDatabase(new BlackBoardContext());
            Console.WriteLine("Goodbye cruel world!");
            
        }

        static public void AddDataToDatabase(BlackBoardContext context)
        {
            var CourseRepo = new Repository<Course>(context);
            var course = new Course();
            course.Course_ID = "DAB";
            CourseRepo.Add(course);
            var course2 = new Course();
            course2.Course_ID = "ISU";
            CourseRepo.Add(course2);

            var teacherRepo = new Repository<Teacher>(context);
            var teacher = new Teacher();
            teacher.AssistantOrResponsible = "Responsible";
            teacher.Teacher_ID = "Henrik";
            
            
            //var AssRepository = new Repository<Assignments>(context);
            //var Assignment = new Assignments()
            //{ Assignment_ID = "EFCore",
            //    AU_ID = "au590761",
            //    Course_ID = "DAB",
            //    Grade = 4, GroupSize = 1,
            //    TIMESTAMP = DateTime.Now,
            //    Passed = true,
            //    Teacher_ID = "Henrik", };
            //AssRepository.Add(Assignment);

            context.SaveChanges();
            return;
        }
    }
}
