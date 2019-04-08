using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Calendar = DABMandatory2.Entities.Calendar;

namespace DABMandatory2.EntityConfiguration
{
    public class CalendarConfiguration : IEntityTypeConfiguration<Entities.Calendar>
    {
        public void Configure(EntityTypeBuilder<Calendar> builder)
        {
            builder.HasKey(key => new {key.Calendar_ID, key.Course_ID});

            builder
                .HasOne(c => c.Course)
                .WithOne(c => c.Calendar)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<Calendar>();

            builder.HasData(new Calendar() {Calendar_ID = "calendarid", Course_ID = "I4DAB"});
        }
    }
}
