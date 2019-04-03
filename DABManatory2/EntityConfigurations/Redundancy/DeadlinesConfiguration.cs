//using System;
//using System.Collections.Generic;
//using System.Text;
//using DABMandatory2.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace DABMandatory2.EntityConfigurations
//{
//    class DeadlinesConfiguration : IEntityTypeConfiguration<Deadlines>
//    {
//        public void Configure(EntityTypeBuilder<Deadlines> builder)
//        {
//            builder
//                .HasKey(key => new { key.Course_ID, key.DeadlineDate });

//            builder
//                .HasAlternateKey(c => c.Calendar_ID);

//            builder
//                .HasOne(a => a.Calendar)
//                .WithMany(a => a.Deadlines)
//                .OnDelete(DeleteBehavior.Cascade)
//                .HasPrincipalKey(a => a.Calendar_ID);


//        }
//    }
//}
