using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class ContentAreaConfiguration : IEntityTypeConfiguration<ContentArea>
    {
        public void Configure(EntityTypeBuilder<ContentArea> builder)
        {
            builder.HasKey(key => new {key.ContentArea_ID, key.Folder_ID, key.Content_ID, key.Course_ID});

            builder
                .HasOne(f => f.Folder)
                .WithMany(c => c.ContentAreas)
                .OnDelete(DeleteBehavior.Cascade)
                .HasForeignKey(fk => new {fk.Folder_ID, fk.Content_ID, fk.Course_ID});
            builder.HasData(new ContentArea()
            {
                Content_ID = "contentid", Audio = "audio.wav", ContentArea_ID = "contentareaid", Course_ID = "I4DAB",
                Folder = null, Folder_ID = "folderid", Group_Signup = "www.signup.com", Text_Block = "textblock",
                Video = "video.mp4"
            });
        }
    }
}
