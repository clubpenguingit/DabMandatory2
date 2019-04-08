using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class IsAssignedToConfiguration : IEntityTypeConfiguration<IsAssignedTo>
    {
        public void Configure(EntityTypeBuilder<IsAssignedTo> builder)
        {
            builder.HasKey(key => new {key.Teacher_ID, key.Course_ID});

            builder
                .HasOne(t => t.Teacher)
                .WithMany(t => t.IsAssignedTos)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(t => t.Teacher_ID);

            builder
                .HasOne(t => t.Course)
                .WithMany(t => t.IsAssignedTos)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(t => t.Course_ID);


            #region Dataseeding

            builder.HasData(new IsAssignedTo()
            {
                Course_ID = "I4DAB",
                Teacher_ID = "Henrik",
            });

            builder.HasData(new IsAssignedTo()
            {
                Course_ID = "I4SWT",
                Teacher_ID = "Troels",
            });

            #endregion
        }
    }
}
