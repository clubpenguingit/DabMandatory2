﻿using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfigurations
{
    class HandInsConfiguration : IEntityTypeConfiguration<HandIns>
    {
        public void Configure(EntityTypeBuilder<HandIns> builder)
        {
            builder
                .HasKey(key => new {key.Calendar_ID, key.Course_ID, key.HandinDate});

            //How to do this other stuff
            //FOREIGN KEY(Calendar_ID, Course_ID) REFERENCES Calendar ON DELETE CASCADE ON UPDATE CASCADE

            builder
                .HasOne(a => a.Calendar)
                .WithMany(a => a.Handins)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(a => a.Calendar_ID);
            builder
                .HasOne(a => a.Course)
                .WithMany(a => a.HandIns)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(a => a.Course_ID);
        }
    }
}
