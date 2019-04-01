using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfigurations
{
    public class CalendarConfiguration : IEntityTypeConfiguration<Calendar>
    {
        public void Configure(EntityTypeBuilder<Calendar> builder)
        {
            builder.HasKey(key => new {key.Calendar_ID, key.Course_ID});

            builder.HasOne(c => c.Course)
                .WithOne(course => course.Calendar)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<Calendar>(c => c.Course_ID);
        }
    }
}