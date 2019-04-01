﻿using System.ComponentModel.DataAnnotations;
using DABMandatory2.Entities;

namespace DABMandatory2.Entities
{
    public class IsEnrolledTo
    {
        [Required]
        public bool ActiveOrPassed { get; set; }

        [MaxLength(100)]
        public string Course_ID { get; set; }

        [MaxLength(10)]
        public string AU_ID { get; set; }

        public virtual Student Student { get; set; }
        public virtual Course Course { get; set; }
    }
}