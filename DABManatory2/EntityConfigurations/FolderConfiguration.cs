﻿using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfigurations
{
    class FolderConfiguration : IEntityTypeConfiguration<Folder>
    {
        public void Configure(EntityTypeBuilder<Folder> builder)
        {
            builder
                .HasKey(key => new { key.Course_ID, key.Content_ID, key.Folder_ID });


            //FOREIGN KEY(Course_ID, Content_ID) REFERENCES CourseContent ON DELETE CASCADE ON UPDATE CASCADE
            builder
                .HasOne(a => a.CourseContent)
                .WithMany(a =>a.Folders)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(a => a.Course_ID);

            builder
                .HasMany(a => a.ContentAreas)
                .WithOne(a => a.Folder)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(a => a.Content_ID);
        }
    }
}