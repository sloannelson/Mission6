using System;
using Microsoft.EntityFrameworkCore;

namespace Mission4.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext (DbContextOptions<MovieContext> options) : base (options)

        {

        }

        public DbSet<MovieForm> movies { get; set; }
    }

}
