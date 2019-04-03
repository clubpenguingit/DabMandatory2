//using DABMandatory2.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace DABMandatory2.EntityConfigurations
//{
//    public class CourseConfiguration : IEntityTypeConfiguration<Course>
//    {
//        public void Configure(EntityTypeBuilder<Course> builder)
//        {
//            builder.HasKey(key => key.Course_ID);

//            builder.HasMany( c => c.Assignments)
//                .WithOne(a => a.Course)
//                .OnDelete(DeleteBehavior.Cascade)
//                .HasForeignKey( a => a.Assignment_ID);
//        }
//    }
//}