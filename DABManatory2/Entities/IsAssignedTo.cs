using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class IsAssignedTo
    {
        [MaxLength(100)]
        public string Course_ID { get; set; }

        [MaxLength(10)]
        public string Teacher_ID { get; set; }
        
        public virtual Teacher Teacher { get; set; }

        public virtual Course Course { get; set; }
    }
}