﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class Course
    {
        [MaxLength(100)]
        public string Course_ID { get; set; }
        public virtual List<Assignments> Assignments { get; set; }
        public virtual List<IsEnrolledTo> Enrollments { get; set; }
        public virtual Calendar Calendar { get; set; }
        public virtual List<IsAssignedTo> IsAssignedTos { get; set; }
        public virtual CourseContent CourseContent { get; set; }
    }
}