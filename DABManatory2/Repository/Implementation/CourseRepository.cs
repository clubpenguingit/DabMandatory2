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

        public Tuple<IEnumerable<IsEnrolledTo>,IEnumerable<IsAssignedTo>> GetAssignees(string id)
        {
            return new Tuple<IEnumerable<IsEnrolledTo>, IEnumerable<IsAssignedTo>>(
                _context.Set<IsEnrolledTo>().Where(e => e.Course_ID == id).AsEnumerable().ToList(),
                _context.Set<IsAssignedTo>().Where(a => a.Course_ID == id).AsEnumerable().ToList()
            );
        }

        public IEnumerable<CourseContent> GetCourseContent(string id)
        {
            return _context.Set<CourseContent>().Where(c => c.Course_ID == id).AsEnumerable().ToList();
        }


    }
}