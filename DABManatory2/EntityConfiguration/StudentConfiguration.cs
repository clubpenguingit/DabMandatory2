using System;
using System.Collections.Generic;
using System.Text;
using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(key => key.AU_ID);

            #region Dataseeding
            
            builder.HasData(new Student()
            {
                AU_ID = "au590761",
                Birthday = new DateTime(1997, 02, 05),
                EnrollmentDate = new DateTime(2017, 08, 25),
                GraduationDate = new DateTime(2021, 01, 31),
                Name = "Andy",
            });

            builder.HasData(new Student()
            {
                AU_ID = "au000000",
                Birthday = new DateTime(1900, 1, 1),
                EnrollmentDate = new DateTime(2000, 1, 1),
                GraduationDate = new DateTime(2100, 1, 1),
                Name = "Falsk studerende",
            });



            #endregion


        }
    }
}
