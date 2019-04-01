using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class Course
    {
        [MaxLength(100)]
        public string Course_ID { get; set; }
    }
}