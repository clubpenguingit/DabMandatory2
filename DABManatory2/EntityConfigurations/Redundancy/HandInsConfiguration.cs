//using System;
//using System.Collections.Generic;
//using System.Text;
//using DABMandatory2.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace DABMandatory2.EntityConfigurations
//{
//    class HandInsConfiguration : IEntityTypeConfiguration<HandIns>
//    {
//        public void Configure(EntityTypeBuilder<HandIns> builder)
//        {
//            builder
//                .HasKey(key => new {key.Course_ID, key.HandinDate});

//            builder
//                .HasAlternateKey(c => c.Calendar_ID);

//            builder
//                .HasOne(a => a.Calendar)
//                .WithMany(a => a.Handins)
//                .OnDelete(DeleteBehavior.Cascade)
//                .HasPrincipalKey(a => a.Calendar_ID);

//        }
//    }
//}
