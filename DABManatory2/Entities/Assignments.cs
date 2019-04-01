using System;
using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class Assignments
    {
        // Composite key not made here. 

        [Required]
        // TODO: Må kun være  -03, 00, 02, 04, 7, 10 & 12[Range()]
        public int Grade { get; set; }

        [Required]
        public int  GroupSize { get; set; }

        [Required]
        public bool Passed { get; set; }

        [MaxLength(255)]
        public string Assignment_ID { get; set; }

        [MaxLength(10)]
        public string AU_ID { get; set; }

        [MaxLength(100)]
        public string Course_ID { get; set; }

        [MaxLength(10)]
        public string Teacher_ID { get; set; }

        [Required]
        public DateTime TIMESTAMP { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
        public virtual Teacher Teacher { get; set; }


    }
}