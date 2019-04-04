using System.Collections.Generic;
using System.Linq;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;

namespace DABMandatory2.Repository.Implementation
{
    public class StudentRepository : Repository<Student>
    {
        public StudentRepository(BlackBoardContext blackboardDbContext) 
            : base(blackboardDbContext)
        {
        }

        public IEnumerable<Student> GetStudents()
        {
            return _context.Set<Student>().AsEnumerable().ToList();
        }

        public IEnumerable<IsEnrolledTo> GetStudentsById(string id)
        {
            return _context.Set<IsEnrolledTo>().Where(x => x.Student.AU_ID == id);
        }
    }
}