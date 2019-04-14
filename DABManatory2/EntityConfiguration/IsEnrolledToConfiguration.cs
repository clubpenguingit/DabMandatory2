using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class IsEnrolledToConfiguration : IEntityTypeConfiguration<IsEnrolledTo>
    {
        public void Configure(EntityTypeBuilder<IsEnrolledTo> builder)
        {
            builder.HasKey(key => new {key.AU_ID, key.Course_ID});

            builder
                .HasOne(c => c.Course)
                .WithMany(c => c.Enrollments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(c => c.Course_ID);

            builder
                .HasOne(s => s.Student)
                .WithMany(s => s.Enrollments)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(s => s.AU_ID);


            #region Dataseeding

            builder.HasData(new IsEnrolledTo()
            {
                ActiveOrPassed = true,
                AU_ID = "au590761",
                Course_ID = "I4DAB",
                Grade = 12,
            });

            builder.HasData(new IsEnrolledTo()
            {
                ActiveOrPassed = true,
                AU_ID = "au590761",
                Course_ID = "I4SWT",
                Grade = 02,
            });

            #endregion
        }
    }
}
