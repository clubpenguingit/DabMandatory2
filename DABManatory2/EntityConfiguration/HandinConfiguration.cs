using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class HandinConfiguration : IEntityTypeConfiguration<HandIns>
    {
        public void Configure(EntityTypeBuilder<HandIns> builder)
        {
            builder.HasKey(key => new {key.HandinDate, key.Calendar_ID, key.Course_ID});

            builder
                .HasOne(c => c.Calendar)
                .WithMany(h => h.Handins)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(fk => new {fk.Calendar_ID, fk.Course_ID});
            builder.HasData(new HandIns()
            {
                Calendar = null, Calendar_ID = "calendarid", Course_ID = "I4DAB",
                HandinDate = new DateTime(2020, 10, 10)
            });
        }
    }
}
