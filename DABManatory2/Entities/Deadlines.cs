using System;
using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class Deadlines
    {
        [MaxLength(10)]
        public string Calendar_ID { get; set; }

        [MaxLength(100)]
        public string Course_ID { get; set; }
        public DateTime DeadlineDate { get; set; }

        public virtual Calendar Calendar { get; set; }
        public virtual Course Course { get; set; }
    }
}