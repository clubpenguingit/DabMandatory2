using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class FolderConfiguration : IEntityTypeConfiguration<Folder>
    {
        public void Configure(EntityTypeBuilder<Folder> builder)
        {
            builder.HasKey(key => new {key.Folder_ID, key.Content_ID, key.Course_ID});

            builder
                .HasOne(c => c.CourseContent)
                .WithMany(f => f.Folders)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(fk => new {fk.Content_ID, fk.Course_ID});
            builder.HasData(new Folder()
            {
                Content_ID = "contentid", ContentAreas = null, Course_ID = "courseid", CourseContent = null,
                Folder_ID = "folderid"
            });
        }
    }
}
