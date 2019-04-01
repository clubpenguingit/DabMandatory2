using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class Student
    {
        [MaxLength(255)]
        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [MaxLength(10)]
        public string AU_ID { get; set; }

        [Required]
        public DateTime GraduationDate { get; set; }

        [Required]
        public DateTime EnrollmentDate { get; set; }

        public List<Assignments> Assignments { get; set; }
        public List<IsEnrolledTo> Enrollments { get; set; }
    }
}