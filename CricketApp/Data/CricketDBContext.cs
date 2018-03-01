using System;
using Microsoft.EntityFrameworkCore;

namespace CricketApp.Data
{
    public class CricketDBContext: DbContext 
    {
        public CricketDBContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=cricket.db");
        }

        public DbSet<Player> Players { get; set; }

    }
}
