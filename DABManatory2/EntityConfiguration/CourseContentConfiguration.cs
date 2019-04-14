using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class CourseContentConfiguration : IEntityTypeConfiguration<CourseContent>
    {
        public void Configure(EntityTypeBuilder<CourseContent> builder)
        {
            builder.HasKey(key => new {key.Content_ID, key.Course_ID});

            builder
                .HasOne(c => c.Course)
                .WithOne(c => c.CourseContent)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<CourseContent>();
            builder.HasData(new CourseContent()
                {Content_ID = "contentid", Course_ID = "I4DAB", Course = null, Folders = null});
        }
    }
}
