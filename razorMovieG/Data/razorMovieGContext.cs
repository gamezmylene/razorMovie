#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using razorMovieG.Models;

namespace razorMovieG.Data
{
    public class razorMovieGContext : DbContext
    {
        public razorMovieGContext (DbContextOptions<razorMovieGContext> options)
            : base(options)
        {
        }

        public DbSet<razorMovieG.Models.Movie> Movie { get; set; }
    }
}
