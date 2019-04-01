using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfigurations
{
    class AssigmentConfiguration : IEntityTypeConfiguration<Assignments>
    {
        public void Configure(EntityTypeBuilder<Assignments> builder)
        {
            builder.HasKey(key => new { key.AU_ID, key.Assignment_ID });

            builder.HasOne(a => a.Student);


        }
    }
}
