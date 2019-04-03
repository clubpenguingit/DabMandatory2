using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DABMandatory2.Entities;

namespace DABMandatory2.Entities
{
    public class Teacher
    {
        [MaxLength(10)]
        public string Teacher_ID { get; set; }

        [Required]
        [MaxLength(15)]
        [RegularExpression(@"Assistant|Responsible")] 
        public string AssistantOrResponsible { get; set; }

        public virtual Assignments Assignments    { get; set; }

        public virtual TeachingAssistant TeachingAssistant { get; set; }
        public virtual CourseResponsible CourseResponsible { get; set; }

        public virtual List<IsAssignedTo> IsAssignedTos { get; set; }
    }
}