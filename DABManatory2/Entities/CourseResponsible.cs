using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;

namespace DABMandatory2.Entities
{
    public class CourseResponsible
    {
        [MaxLength(255)]
        public string Name { get; set; }
        public DateTime Birthday { get; set; }

        [MaxLength(10)]
        public string AU_ID { get; set; }

        [MaxLength(10)]
        public string Teacher_ID { get; set; }

        [MaxLength(15)]
        public string Assistant_Or_Responsible { get; set; }
    }
}