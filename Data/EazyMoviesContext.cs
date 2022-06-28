using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EazyMoviesDatabase.Models;

namespace EazyMoviesDatabase.Data
{
    public class EazyMoviesContext : DbContext
    {
        public EazyMoviesContext (DbContextOptions<EazyMoviesContext> options)
            : base(options)
        {
        }

        public DbSet<EazyMoviesDatabase.Models.Movie> Movie { get; set; }
    }
}
