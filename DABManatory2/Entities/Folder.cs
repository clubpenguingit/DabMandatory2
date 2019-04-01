using System.ComponentModel.DataAnnotations;

namespace DABMandatory2.Entities
{
    public class Folder
    {
        [MaxLength(10)]
        public string Folder_ID { get; set; }
        [MaxLength(100)]
        public string Course_ID { get; set; }
        [MaxLength(50)]
        public string Content_ID { get; set; }
    }
}