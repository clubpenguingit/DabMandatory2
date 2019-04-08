using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class AssignmentConfiguration : IEntityTypeConfiguration<Assignments>
    {
        public void Configure(EntityTypeBuilder<Assignments> builder)
        {
            builder.HasKey(key => new {key.AU_ID, key.Assignment_ID});

            builder
                .HasOne(t=> t.Teacher)
                .WithMany(t=>t.Assignments)
                .OnDelete(DeleteBehavior.Restrict)
                .HasForeignKey(a => a.Teacher_ID); 

            builder
                .HasOne(a => a.Course)
                .WithMany(a => a.Assignments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(c => c.Course_ID);

            builder
                .HasOne(a => a.Student)
                .WithMany(a => a.Assignments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(a => a.AU_ID);

        }
    }
}
