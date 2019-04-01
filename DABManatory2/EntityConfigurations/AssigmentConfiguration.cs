using System;
using System.Collections.Generic;
using System.Text;
using BlackBoard.Entities;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfigurations
{
    class AssignmentConfiguration : IEntityTypeConfiguration<Assignments>
    {
        public void Configure(EntityTypeBuilder<Assignments> builder)
        {
            // Composite Primary Key
            builder.HasKey(key => new { key.AU_ID, key.Assignment_ID });

            // Foreign Key Student
            builder.HasOne(a => a.Student)
                .WithMany(s => s.Assignments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(a => a.AU_ID);

            // Foreign Key Course
            builder.HasOne(a => a.Course)
                .WithMany(c => c.Assignments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(a => a.Course_ID);

            // Foreign Key Teacher
            builder.HasOne(a => a.Teacher)
                .WithOne(t => t.Assignments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<Teacher>( t => t.Teacher_ID);
        }
    }
}
