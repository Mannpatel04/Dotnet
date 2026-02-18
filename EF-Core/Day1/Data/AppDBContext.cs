using Day1.Model;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Demo.Data
{
    internal class AppDBContext: DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Trainer> Trainers { get; set; } 
        public DbSet<Batch> Batchs { get; set; }    


            
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =MANN\\SQLEXPRESS; Database =EF_Demo; Trusted_Connection = True; TrustServerCertificate = true");
        }

    }
}
