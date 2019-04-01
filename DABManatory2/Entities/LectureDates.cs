using System;
using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class LectureDates
    {
        [MaxLength(10)]
        public string CalendarID { get; set; }

        [MaxLength(100)]
        public string CourseID { get; set; }

        public DateTime Lectures { get; set; }
    }
}