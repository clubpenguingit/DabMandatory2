using System;
using System.Collections.Generic;
using System.Text;
using BlackBoard.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfigurations
{
    class TeachingAssistantConfiguration : IEntityTypeConfiguration<TeachingAssistant>
    {
        public void Configure(EntityTypeBuilder<TeachingAssistant> builder)
        {
            builder
                .HasKey(key => new {key.AU_ID, key.Teacher_ID});

            builder
                .HasOne(t => t.Teacher)
                .WithOne(ta => ta.TeachingAssistant)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<Teacher>(t => t.TeacherID);

            builder
                .Property(t => t.Assistant_Or_Responsible)
                .HasDefaultValue("Assistant");
        }

    }
}
