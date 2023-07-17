 using System;
using Registration.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace Registration
{
    public class DataBaseContext:DbContext
    {
        
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        

        public DbSet<Doctor> Doctors { get; set; }
        public DataBaseContext()
        {
            Database.Migrate();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string appDataPath = AppDomain.CurrentDomain.BaseDirectory;
            string dbPath = Path.Combine(appDataPath, "db01.db");
            optionsBuilder.UseSqlite($"Filename={dbPath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, Username = "admin", Password = "123", Role = "Admin" },
                new User { Id = 2, Username = "user", Password = "1234",Role="User"}
            );
            base.OnModelCreating(modelBuilder);
        }
    }
}
