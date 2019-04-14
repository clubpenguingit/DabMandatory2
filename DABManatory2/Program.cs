using System;

namespace DABMandatory2
{
    class Program
    {
        static void Main(string[] args)
        {
            var uow = new UnitOfWork();

            //// The below lines of commented code shows how to fulfill the creation requirements of the exercise. 
            //// The below can only be run once, as duplicate keys will throw exceptions. 
            //// Add student; 
            //uow.StudentRepository.Add(new Student()
            //{
            //    AU_ID = "au589973",
            //    Birthday = DateTime.Parse("07/02/1995"),
            //    Name = "Tobias Lund",
            //    EnrollmentDate = DateTime.Parse("01/01/2017"),
            //    GraduationDate = DateTime.Parse("01/01/2021"),
            //});
            //uow.Complete();

            //// Add Course
            //uow.CourseRepository.Add(new Course()
            //{
            //    Course_ID = "I4ISU",
            //});
            //uow.Complete();

            //// Enroll student in course
            //uow.EnrollRepository.Add(new IsEnrolledTo()
            //{
            //    ActiveOrPassed = true,
            //    AU_ID = "au589973",
            //    Course_ID = "I4ISU",
            //    Grade = 12,
            //});
            //uow.Complete();

            //// Add assignment
            //uow.AssignmentRepository.Add(new Assignments()
            //{
            //    Assignment_ID = "Makefiles",
            //    AU_ID = "au589973",
            //    Course_ID = "I4ISU",
            //    Grade = 7,
            //    GroupSize = 4,
            //    Passed = true,
            //    Teacher_ID = "Henrik",
            //    TIMESTAMP = DateTime.Now,
            //});
            //uow.Complete();
            

            // This main program will let you query the required views.
            // Use the approach above to add to your database. 
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Hello user! What do you want to do? " +
                                  "(You have a limited amount of possibilities)");
                Console.WriteLine("Press Z for a list of students");
                Console.WriteLine("Press X for a list of courses");
                Console.WriteLine("Press C for a list of students and his courses and grades");
                Console.WriteLine("Press V for a list of students and teachers assigned to a course");
                Console.WriteLine("Press B for a list of course content to a course");
                Console.WriteLine("Press N to see a list of a students assignments");
                Console.WriteLine("Press Q to quit.");

                var choice = Console.ReadKey();

                switch (choice.Key)
                {
                    case ConsoleKey.Z:
                        {
                            var students = uow.StudentRepository.GetAll();
                            foreach (var variable in students)
                            {
                                Console.WriteLine("\nName: {0}", variable.Name);
                            }
                            Console.ReadLine();

                            break;
                        }
                    case ConsoleKey.X:
                        {
                            var courses = uow.CourseRepository.GetAll();
                            foreach (var course in courses)
                            {
                                Console.WriteLine("\nCourse ID:{0}", course.Course_ID);
                            }
                            Console.ReadLine();

                            break;
                        }
                    case ConsoleKey.C:
                        {
                            Console.WriteLine("\nWrite the id for a student (A default one could be au590761)");
                            var id = Console.ReadLine();
                            var list = uow.StudentRepository.GetEnrolledToByStudentId(id);
                            foreach (var variable in list)
                            {
                                Console.WriteLine("ID: {0} | CourseID: {1} | Grade: {2} | ActiveOrPassed: {3}",
                                variable.AU_ID, variable.Course_ID, variable.Grade, variable.ActiveOrPassed);
                            }
                            Console.ReadLine();

                            break;
                        }
                    case ConsoleKey.V:
                        {
                            Console.WriteLine("\nEnter a course ID to see the assigned " +
                                              "students and teachers (Default = I4DAB )");
                            var courseID = Console.ReadLine();
                            var list = uow.CourseRepository.GetAssignees(courseID);
                            foreach (var student in list.Item1)
                            {
                                Console.WriteLine("Student ID: {0}", student.AU_ID);
                            }

                            foreach (var teacher in list.Item2)
                            {
                                Console.WriteLine("Teacher ID: {0}", teacher.Teacher_ID);
                            }
                            Console.ReadLine();

                            break;
                        }
                    case ConsoleKey.B:
                        {
                            Console.WriteLine("\nEnter a course ID to see the course content (Default = I4DAB )");
                            var courseID = Console.ReadLine();
                            var list = uow.CourseRepository.GetCourseContent(courseID);
                            foreach (var content in list)
                            {
                                Console.WriteLine("Content id: {0}", content.Content_ID);
                            }
                            Console.ReadLine();

                            break;
                        }
                    case ConsoleKey.N:
                        {
                            Console.WriteLine("\nEnter a student id (Default = au590761 )");
                            var studID = Console.ReadLine();
                            Console.WriteLine("Enter a course id (Default = I4DAB )");
                            var courseID = Console.ReadLine();

                            var list = uow.StudentRepository.GetStudentAssignments(studID, courseID);
                            foreach (var variable in list)
                            {
                                Console.WriteLine("AssignmentID: {0} | Grade: {1} | Graded by: {2}", variable.Assignment_ID,
                                    variable.Grade, variable.Teacher_ID);
                            }
                            Console.ReadLine();

                            break;
                        }
                    case ConsoleKey.Q:
                        {
                            running = false;
                            Console.Clear();
                            Console.WriteLine("\nBye!");
                            Console.ReadLine();

                            break;
                        }



                }
            }


        }

    }
}
