using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DABMandatory2.Entities;

namespace BlackBoard.Entities
{
    public class Course
    {
        [MaxLength(100)]
        public string CourseID { get; set; }

        public List<Assignments> Assignments { get; set; }
    }
}