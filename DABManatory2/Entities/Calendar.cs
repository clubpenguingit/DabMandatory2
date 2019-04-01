using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class Calendar
    {
        [MaxLength(10)]
        public string Calendar_ID { get; set; }

        [MaxLength(100)]
        public string Course_ID { get; set; }

    }
}