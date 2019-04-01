using System.ComponentModel.DataAnnotations;
using DABMandatory2.Entities;

namespace BlackBoard.Entities
{
    public class Teacher
    {
        [MaxLength(10)]
        public string Teacher_ID { get; set; }

        [MaxLength(15)]
        public string AssistantOrResponsible { get; set; }

        public Assignments Assignments    { get; set; }
    }


}