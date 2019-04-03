//using System;
//using System.Collections.Generic;
//using System.Text;
//using DABMandatory2.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace DABMandatory2.EntityConfigurations
//{
//    class ContentAreaConfiguration : IEntityTypeConfiguration<ContentArea>
//    {
//        public void Configure(EntityTypeBuilder<ContentArea> builder)
//        {
//            builder
//                .HasKey(key => new {key.Course_ID, key.ContentArea_ID});

//            builder
//                .HasAlternateKey(c => c.Content_ID);

//            builder.HasOne(c => c.Folder)
//                .WithMany(c => c.ContentAreas)
//                .IsRequired()
//                .HasForeignKey(c => c.Folder_ID)
//                .HasForeignKey(c => c.Course_ID)
//                .HasPrincipalKey(c => c.Content_ID)
//                .OnDelete(DeleteBehavior.Cascade);
//        }
//    }
//}
