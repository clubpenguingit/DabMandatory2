using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class Teacher
    {
        [MaxLength(10)]
        public string Teacher_ID { get; set; }

        [MaxLength(15)]
        public string AssistantOrResponsible { get; set; }

        public TeachingAssistant TeachingAssistant { get; set; }
        public CourseResponsible CourseResponsible { get; set; }
    }

}