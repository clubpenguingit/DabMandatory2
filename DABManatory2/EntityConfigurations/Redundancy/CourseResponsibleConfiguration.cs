//using System;
//using System.Collections.Generic;
//using System.Text;
//using DABMandatory2.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace DABMandatory2.EntityConfigurations
//{
//    class CourseResponsibleConfiguration : IEntityTypeConfiguration<CourseResponsible>
//    {
//        public void Configure(EntityTypeBuilder<CourseResponsible> builder)
//        {
//            builder
//                .HasKey(key => new {key.Teacher_ID, key.AU_ID});

//            builder
//                .HasOne(t => t.Teacher)
//                .WithOne(c => c.CourseResponsible)
//                .OnDelete(DeleteBehavior.Cascade)
//                .HasForeignKey<Teacher>();

//            builder
//                .Property(t => t.Assistant_Or_Responsible)
//                .HasDefaultValue("Responsible");

//        }
//    }
//}
