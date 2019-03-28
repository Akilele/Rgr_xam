using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace prakt3.models
{
    public class ApplicationContext : DbContext
    {
        private readonly string _db_path;
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Topic> Topics { get; set; }

        public ApplicationContext(string db_path)
        {
            _db_path = db_path;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptions)
        {
            dbContextOptions.UseSqlite($"Filename={_db_path}");
            dbContextOptions.EnableSensitiveDataLogging();
        }
    }
}
