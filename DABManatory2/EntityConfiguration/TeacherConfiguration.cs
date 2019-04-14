using DABMandatory2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DABMandatory2.EntityConfiguration
{
    public class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(t => t.Teacher_ID);

            #region Dataseeding

            builder.HasData(new Teacher()
            {
                AssistantOrResponsible = "Assistant",
                Teacher_ID = "Troels",
            });

            builder.HasData(new Teacher()
            {
                AssistantOrResponsible = "Responsible",
                Teacher_ID = "Henrik",
            });

            #endregion

        }
    }
}
