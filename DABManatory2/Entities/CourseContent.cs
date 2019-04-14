using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class CourseContent
    {
        [MaxLength(50)]
        public string Content_ID { get; set; }

        [MaxLength(100)]
        public string Course_ID { get; set; }

        public virtual List<Folder> Folders { get; set; }
        
        public virtual Course Course { get; set; }
    }
}