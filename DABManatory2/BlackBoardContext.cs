using Microsoft.EntityFrameworkCore;
using DABMandatory2.Entities;


namespace DABMandatory2
{
    class BlackBoardContext : DbContext
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
            var connectionString = "Data Source=DESKTOP-UGIDUH3;Initial Catalog=MandatoryDAB2;Integrated Security=True";
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
            
            //optionsBuilder.UseSqlServer(
            //    "Data Source=DESKTOP-UGIDUH3;Initial Catalog=MandatoryDAB2;Integrated Security=True");
        }
    }
}
