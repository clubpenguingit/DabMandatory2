using System;
using System.ComponentModel.DataAnnotations;

namespace BlackBoard.Entities
{
    public class TeachingAssistant
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        public string AU_ID { get; set; }

        public string Teacher_ID { get; set; }

        
        public string Assistant_Or_Responsible { get; set; }
        //Assistant_OR_Responsible NVARCHAR(15) DEFAULT 'Assistant' NOT NULL

    }
}