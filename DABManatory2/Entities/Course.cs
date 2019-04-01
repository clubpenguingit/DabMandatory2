using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DABMandatory.Entities;

namespace DABMandatory2.Entities
{
    public class Course
    {
        [MaxLength(100)]
        public string Course_ID { get; set; }

        public List<IsEnrolledTo> Enrollments { get; set; }
    }
}