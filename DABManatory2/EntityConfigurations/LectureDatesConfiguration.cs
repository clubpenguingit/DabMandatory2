using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfigurations
{
    public class LectureDatesConfiguration : IEntityTypeConfiguration<LectureDates>
    {
        public void Configure(EntityTypeBuilder<LectureDates> builder)
        {
            builder.HasKey(c => new {c.Calendar_ID, c.Course_ID});

        }
    }
}