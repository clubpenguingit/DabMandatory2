using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class IsAssignedTo
    {
        [MaxLength(100)]
        public string CourseID { get; set; }

        [MaxLength(10)]
        public string TeacherID { get; set; }
    }
}