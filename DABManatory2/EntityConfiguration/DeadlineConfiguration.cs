using System;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class DeadlineConfiguration : IEntityTypeConfiguration<Deadlines>
    {
        public void Configure(EntityTypeBuilder<Deadlines> builder)
        {
            builder.HasKey(key => new {key.DeadlineDate, key.Calendar_ID, key.Course_ID});

            builder.HasOne(c => c.Calendar)
                .WithMany(d => d.Deadlines)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(c => new {c.Calendar_ID, c.Course_ID});
            builder.HasData(new Deadlines()
            {
                Calendar = null, Calendar_ID = "calendarid", Course_ID = "I4DAB",
                DeadlineDate = new DateTime(2020, 10, 10)
            });
        }
    }
}
