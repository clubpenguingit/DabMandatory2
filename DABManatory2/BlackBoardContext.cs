﻿using Microsoft.EntityFrameworkCore;
using DABMandatory2.Entities;
using DABMandatory2.EntityConfiguration;


namespace DABMandatory2
{
    public class BlackBoardContext : DbContext
    {
        public DbSet<Assignments> Assignments { get; set; }
        public DbSet<Calendar> Calendars { get; set; }
        public DbSet<ContentArea> ContentAreas { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseContent> CourseContents { get; set; }
        public DbSet<CourseResponsible> CourseResponsibles { get; set; }
        public DbSet<Deadlines> Deadlines { get; set; }
        public DbSet<Folder> Folders { get; set; }
        public DbSet<HandIns> HandIns { get; set; }
        public DbSet<IsAssignedTo> IsAssignedTos { get; set; }
        public DbSet<IsEnrolledTo> IsEnrolledTos { get; set; }
        public DbSet<LectureDates> LectureDates { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<TeachingAssistant> TeachingAssistants { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Data Source=DESKTOP-QND3SFP\\MSSQLSERVER03;Initial Catalog=DABMandatory2;Integrated Security=True";
            
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
            
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            modelbuilder.ApplyConfiguration(new AssignmentConfiguration());
            modelbuilder.ApplyConfiguration(new CalendarConfiguration());
            modelbuilder.ApplyConfiguration(new ContentAreaConfiguration());
            modelbuilder.ApplyConfiguration(new CourseConfiguration());
            modelbuilder.ApplyConfiguration(new CourseContentConfiguration());
            modelbuilder.ApplyConfiguration(new CourseResponsibleConfiguration());
            modelbuilder.ApplyConfiguration(new DeadlineConfiguration());
            modelbuilder.ApplyConfiguration(new FolderConfiguration());
            modelbuilder.ApplyConfiguration(new HandinConfiguration());
            modelbuilder.ApplyConfiguration(new IsAssignedToConfiguration());
            modelbuilder.ApplyConfiguration(new IsEnrolledToConfiguration());
            modelbuilder.ApplyConfiguration(new LectureDateConfiguration());
            modelbuilder.ApplyConfiguration(new StudentConfiguration());
            modelbuilder.ApplyConfiguration(new TeacherConfiguration());
            modelbuilder.ApplyConfiguration(new TeachingAssistantConfiguration());
        }
    }
}
