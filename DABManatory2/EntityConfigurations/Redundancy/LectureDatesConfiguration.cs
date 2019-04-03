//using DABMandatory2.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace DABMandatory2.EntityConfigurations
//{
//    public class LectureDatesConfiguration : IEntityTypeConfiguration<LectureDates>
//    {
//        public void Configure(EntityTypeBuilder<LectureDates> builder)
//        {
//            builder.HasKey(c => c.Course_ID);

//            builder.HasAlternateKey(l => l.Calendar_ID);

//            builder.HasOne(l => l.Calendar)
//                .WithMany(c => c.LectureDates)
//                .HasForeignKey(l => l.Course_ID)
//                .HasPrincipalKey(l => l.Calendar_ID);
//        }
//    }
//}