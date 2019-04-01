using System;
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
        public string AuID { get; set; }

        [Required]
        public DateTime GraduationDate { get; set; }

        [Required]
        public DateTime EnrollmentDate { get; set; }
    }
}