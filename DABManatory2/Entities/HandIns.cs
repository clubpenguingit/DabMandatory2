using System;
using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class HandIns
    {
        [MaxLength(10)]
        public string Calendar_ID { get; set; }
        [MaxLength(100)]
        public string Course_ID { get; set; }        
        public DateTime HandinDate { get; set; }
    }
}