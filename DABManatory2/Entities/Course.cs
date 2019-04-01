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
    }
}