using System.Collections.Generic;
using System.Linq;
using DABMandatory2.Entities;

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

        public IEnumerable<Assignments> GetStudentAssignments(string studId, string courseID)
        {
            return _context.Set<Assignments>()
                    .Where( a => a.AU_ID == studId && a.Course_ID == courseID)
                    .AsEnumerable().ToList();
        }



    }
}