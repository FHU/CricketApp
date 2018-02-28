using System;
using Microsoft.EntityFrameworkCore;

namespace CricketApp.Data
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext()
        {
        }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=cricket.db");
        }
    }
}
