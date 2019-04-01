using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DABMandatory2.Entities;

namespace DABMandatory2.Entities
{
    public class Course
    {
        [MaxLength(100)]
        public string Course_ID { get; set; }
        public List<Assignments> Assignments { get; set; }

        public List<IsEnrolledTo> Enrollments { get; set; }
        public Calendar Calendar { get; set; }
        public List<IsAssignedTo> IsAssignedTos { get; set; }
        public List<HandIns> HandIns { get; set; }
        public List<Deadlines> Deadlines { get; set; }
        public CourseContent CourseContent { get; set; }
    }
}