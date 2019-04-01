using System.ComponentModel.DataAnnotations;

namespace BlackBoard.Entities
{
    public class Teacher
    {
        [MaxLength(10)]
        public string TeacherID { get; set; }

        [MaxLength(15)]
        public string AssistantOrResponsible { get; set; }
    }

}