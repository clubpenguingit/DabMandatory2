//using System;
//using System.Collections.Generic;
//using System.Text;
//using DABMandatory2.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace DABMandatory2.EntityConfigurations
//{
//    class IsAssignedToConfiguration : IEntityTypeConfiguration<IsAssignedTo>
//    {
//        public void Configure(EntityTypeBuilder<IsAssignedTo> builder)
//        {
//            builder
//                .HasOne(t => t.Teacher)
//                .WithMany(t => t.IsAssignedTos)
//                .IsRequired()
//                .HasForeignKey(t => t.Teacher_ID);

//            builder
//                .HasOne(c => c.Course)
//                .WithMany(b => b.IsAssignedTos)
//                .IsRequired()
//                .HasForeignKey(c => c.Course_ID);

//            builder
//                .HasKey(key => new {key.Course_ID, key.Teacher_ID});
//        }
//    }
//}
