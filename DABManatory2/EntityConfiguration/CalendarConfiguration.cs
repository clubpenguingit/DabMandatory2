using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class CalendarConfiguration : IEntityTypeConfiguration<Entities.Calendar>
    {
        public void Configure(EntityTypeBuilder<Entities.Calendar> builder)
        {
            builder.HasKey(key => new {key.Calendar_ID, key.Course_ID});

            builder
                .HasOne(c => c.Course)
                .WithOne(c => c.Calendar)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<Course>();

            
        }
    }
}
