using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace DatabaseContext
{
    public class EMSDbContext:DbContext
    {
        public EMSDbContext()
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Participant> Participants { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Trainer> Trainers { get; set; }

        protected  void OnModelBuilding(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            //modelBuilder.Entity<Organization>()
            //    .HasMany(t => t.Courses)
            //    .WithMany(t => t.Organizations);



        }
    }
}
