using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace DABMandatory2.Entities
{
    public class CourseResponsible
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [MaxLength(10)]
        public string AU_ID { get; set; }

        [MaxLength(10)]
        public string Teacher_ID { get; set; }

        [MaxLength(15)]
        [RegularExpression(@"Responsible|Assistant")]
        public string Assistant_Or_Responsible { get; set; }

        public Teacher Teacher { get; set; }
    }
}