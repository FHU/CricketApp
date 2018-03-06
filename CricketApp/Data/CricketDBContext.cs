using System;
using Microsoft.EntityFrameworkCore;

namespace CricketApp.Data
{
    public class CricketDBContext: DbContext 
    {
        public CricketDBContext( DbContextOptions<CricketDBContext> options )
            :base(options)
        {
        }

        public DbSet<Player> Players { get; set; }

    }
}
