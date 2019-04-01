using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using DABMandatory2.EntityConfigurations;


namespace DABMandatory2
{
    class BlackBoardContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=DESKTOP-UGIDUH3;Initial Catalog=MandatoryDAB2;Integrated Security=True";
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
            
            //optionsBuilder.UseSqlServer(
            //    "Data Source=DESKTOP-UGIDUH3;Initial Catalog=MandatoryDAB2;Integrated Security=True");


        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new AssignmentConfiguration());
            modelbuilder.ApplyConfiguration(new CalendarConfiguration());
            modelbuilder.ApplyConfiguration(new ContentAreaConfiguration());
            modelbuilder.ApplyConfiguration(new CourseConfiguration());
            modelbuilder.ApplyConfiguration(new CourseContentConfiguration());
            modelbuilder.ApplyConfiguration(new CourseResponsibleConfiguration());
            modelbuilder.ApplyConfiguration(new DeadlinesConfiguration());
            modelbuilder.ApplyConfiguration(new FolderConfiguration());
            modelbuilder.ApplyConfiguration(new HandInsConfiguration());
            modelbuilder.ApplyConfiguration(new IsAssignedToConfiguration());
            modelbuilder.ApplyConfiguration(new IsEnrolledToConfiguration());
            modelbuilder.ApplyConfiguration(new LectureDatesConfiguration());
            modelbuilder.ApplyConfiguration(new StudentConfiguration());
            modelbuilder.ApplyConfiguration(new TeacherConfiguration());
            modelbuilder.ApplyConfiguration(new TeachingAssistantConfiguration());
        }
    }
}
