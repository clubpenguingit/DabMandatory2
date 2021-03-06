﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class TeachingAssistant
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
        public string Assistant_Or_Responsible { get; set; }
        //Assistant_OR_Responsible NVARCHAR(15) DEFAULT 'Assistant' NOT NULL

        public virtual Teacher Teacher { get; set; }
    }
}