﻿using DABMandatory2.Entities;
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

            #region Dataseeding
            builder
                .HasData(new Assignments()
                {
                    Assignment_ID = "EFCore",
                    AU_ID = "au590761",
                    Course_ID = "I4DAB",
                    Grade = 7,
                    GroupSize = 4,
                    Passed = true,
                    Teacher_ID = "Henrik",
                });

            builder.HasData(new Assignments()
            {
                Assignment_ID = "ATMS",
                AU_ID = "au590761",
                Course_ID = "I4SWT",
                Grade = 12,
                GroupSize = 4,
                Passed = true,
                Teacher_ID = "Troels",
            });

            #endregion

        }
    }
}
