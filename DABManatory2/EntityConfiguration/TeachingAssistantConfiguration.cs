using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class TeachingAssistantConfiguration : IEntityTypeConfiguration<TeachingAssistant>
    {
        public void Configure(EntityTypeBuilder<TeachingAssistant> builder)
        {
            builder.HasKey(key => new {key.AU_ID, key.Teacher_ID});

            builder
                .HasOne(t => t.Teacher)
                .WithOne(t => t.TeachingAssistant)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey<TeachingAssistant>();

            builder
                .Property(t => t.Assistant_Or_Responsible)
                .HasDefaultValue("Assistant");
        }
    }
}
