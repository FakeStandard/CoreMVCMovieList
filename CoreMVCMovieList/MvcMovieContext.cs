using CoreMVCMovieList.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreMVCMovieList
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options) { }

        public DbSet<Movie> Movie { get; set; }
    }
}
