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

        public virtual Course Course { get; set; }
        public virtual List<HandIns> Handins { get; set; }
        public virtual List<Deadlines> Deadlines { get; set; }
        public virtual List<LectureDates> LectureDates { get; set; }

    }
}