using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace DABMandatory2.Entities
{
    public class ContentArea
    {
        [MaxLength(50)]
        public string ContentArea_ID { get; set; }
        [MaxLength(50)]
        public string Content_ID { get; set; }
        [MaxLength(100)]
        public string Course_ID { get; set; }
        [MaxLength(10)]
        public string Folder_ID { get; set; }
        [MaxLength(100)]
        public string Text_Block { get; set; }
        [MaxLength(50)]
        public string Video { get; set; }
        [MaxLength(50)]
        public string Group_Signup { get; set; }
        [MaxLength(50)]
        public string Audio { get; set; }
        public virtual Folder Folder { get; set; }
        
    }
}