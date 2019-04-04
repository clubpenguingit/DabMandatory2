using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DABMandatory2.Entities;
using DABMandatory2.Interfaces;

namespace DABMandatory2.Repository.Implementation
{
    public class CourseRepository : Repository<Course>
    {
        public CourseRepository(BlackBoardContext blackBoardContext) : base(blackBoardContext) { }

        public Tuple<IEnumerable<IsEnrolledTo>,IEnumerable<IsAssignedTo>> GetAssignees(Course entity)
        {
            return new Tuple<IEnumerable<Student>, IEnumerable<IsAssignedTo>>(
                _context.Set<IsEnrolledTo>().Find(entity).Student,
                _context.Set<IsAssignedTo>().Find(entity).Teacher);
        }


    }
}