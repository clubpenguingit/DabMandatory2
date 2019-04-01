﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BlackBoard.Entities
{
    public class Deadlines
    {
        [MaxLength(10)]
        public string Calendar_ID { get; set; }

        [MaxLength(100)]
        public string Course_ID { get; set; }
        public DateTime DeadlineDate { get; set; }


    }
}