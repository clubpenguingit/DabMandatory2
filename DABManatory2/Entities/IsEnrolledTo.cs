using System.ComponentModel.DataAnnotations;

namespace DABMandatory.Entities
{
    public class IsEnrolledTo
    {
        [Required]
        public bool ActiveOrPassed { get; set; }

        [MaxLength(100)]
        public string Course_ID { get; set; }

        [MaxLength(10)]
        public string AU_ID { get; set; }

    }
}