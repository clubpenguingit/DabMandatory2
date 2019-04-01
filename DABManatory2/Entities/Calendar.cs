using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class Calendar
    {
        [MaxLength(10)]
        public string Calendar_ID { get; set; }

        [MaxLength(100)]
        public string Course_ID { get; set; }

        public Course Course { get; set; }
        public List<HandIns> Handins { get; set; }
        public List<Deadlines> Deadlines { get; set; }
        public List<LectureDates> LectureDates { get; set; }

    }
}