using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(key => key.Course_ID);


            #region Dataseeding

            builder.HasData(new Course()
            {
                Course_ID = "I4DAB",
            });

            builder.HasData(new Course()
            {
                Course_ID = "I4SWT",
            });


            #endregion
        }
    }
}
