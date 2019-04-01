using System.ComponentModel.DataAnnotations;

namespace BlackBoard.Entities
{
    public class IsEnrolledTo
    {
        [Required]
        public bool ActiveOrPassed { get; set; }

        [MaxLength(100)]
        public string CourseID { get; set; }

        [MaxLength(10)]
        public string AuID { get; set; }

    }
}