using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Design;

namespace DABMandatory2.Entities
{
    public class CourseContent
    {
        [MaxLength(50)]
        public string Content_ID { get; set; }

        [MaxLength(100)]
        public string Course_ID { get; set; }
    }
}