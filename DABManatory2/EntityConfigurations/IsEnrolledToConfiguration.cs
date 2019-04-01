using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfigurations
{
    public class IsEnrolledToConfiguration : IEntityTypeConfiguration<IsEnrolledTo>
    {
            public void Configure(EntityTypeBuilder<IsEnrolledTo> builder)
            {
                builder
                    .HasKey(key => new {key.AU_ID,key.Course_ID});

                builder
                    .HasOne(s => s.Student)
                    .WithMany(e => e.Enrollments)
                    .HasForeignKey(s => s.AU_ID)
                    .OnDelete(DeleteBehavior.Cascade);

                builder
                    .HasOne(c => c.Course)
                    .WithMany(e => e.Enrollments)
                    .HasForeignKey(c => c.Course_ID)
                    .OnDelete(DeleteBehavior.Cascade);
            }
    }
}