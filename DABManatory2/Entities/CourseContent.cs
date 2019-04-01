using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore.Design;

namespace BlackBoard.Entities
{
    public class CourseContent
    {
        [MaxLength(50)]
        public string Content_ID { get; set; }

        [MaxLength(100)]
        public string Course_ID { get; set; }

        public List<Folder> Folders { get; set; }
    }
}