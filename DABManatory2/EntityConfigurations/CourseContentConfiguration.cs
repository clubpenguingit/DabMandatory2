using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfigurations
{
    class CourseContentConfiguration : IEntityTypeConfiguration<CourseContent>
    {
        public void Configure(EntityTypeBuilder<CourseContent> builder)
        {
            builder
                .HasOne(c => c.Course)
                .WithOne(c => c.CourseContent)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<Course>(c => c.Course_ID);

            builder
                .HasKey(key => new {key.Content_ID, key.Course_ID});

        }
    }
}
