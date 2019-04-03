using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class LectureDateConfiguration : IEntityTypeConfiguration<LectureDates>
    {
        public void Configure(EntityTypeBuilder<LectureDates> builder)
        {
            builder.HasKey(key => new {key.Lecture, key.Calendar_ID, key.Course_ID});

            builder
                .HasOne(c => c.Calendar)
                .WithMany(l => l.LectureDates)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(c => new {c.Calendar_ID, c.Course_ID});
        }
    }
}
