using System.ComponentModel.DataAnnotations;

namespace BlackBoard.Entities
{
    public class Course
    {
        [MaxLength(100)]
        public string CourseID { get; set; }
    }
}