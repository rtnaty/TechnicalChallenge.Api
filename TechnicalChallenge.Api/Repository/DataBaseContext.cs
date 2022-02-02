using Microsoft.EntityFrameworkCore;

namespace TechnicalChallenge.Api.Repository
{
    /// <summary>
    /// Database context implementation with entity framework
    /// </summary>
    public class DataBaseContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<CourseModel> Courses { get; set; }
        public DbSet<LessonModel> Lessons { get; set; }
        public DbSet<TrackingLogModel> TrackingLogs { get; set; }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().ToTable("User");
            modelBuilder.Entity<CourseModel>().ToTable("Course");
            modelBuilder.Entity<LessonModel>().ToTable("Lesson");
            modelBuilder.Entity<TrackingLogModel>().ToTable("TrackingLog");

        }
    }
}