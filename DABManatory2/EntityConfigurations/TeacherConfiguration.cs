using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfigurations
{
    class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder
                .HasKey(t => t.Teacher_ID);

            builder
                .HasOne(t => t.TeachingAssistant)
                .WithOne(t => t.Teacher)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(t => t.CourseResponsible)
                .WithOne(t => t.Teacher)
                .OnDelete(DeleteBehavior.Cascade);

            builder
                .HasOne(t => t.Assignments)
                .WithOne(t => t.Teacher)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(t => t.IsAssignedTos)
                .WithOne(t => t.Teacher)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);



        }
    }
}
