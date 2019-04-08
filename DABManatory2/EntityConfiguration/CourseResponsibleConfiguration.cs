using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class CourseResponsibleConfiguration : IEntityTypeConfiguration<CourseResponsible>
    {
        public void Configure(EntityTypeBuilder<CourseResponsible> builder)
        {
            builder.HasKey(key => new {key.AU_ID, key.Teacher_ID});

            builder
                .HasOne(t => t.Teacher)
                .WithOne(t => t.CourseResponsible)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<CourseResponsible>();

            builder
                .Property(t => t.Assistant_Or_Responsible)
                .HasDefaultValue("Responsible");

            builder.HasData(new CourseResponsible()
            {
               AU_ID = "auid", Birthday = new DateTime(2000, 10, 20),
                Name = "Andy Frækkesen", Teacher = null, Teacher_ID = "Henrik"
            });
        }
    }
}
