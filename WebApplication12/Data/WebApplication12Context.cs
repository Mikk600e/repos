using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace WebApplication12.Models
{
    public class WebApplication12Context : DbContext
    {
        public WebApplication12Context (DbContextOptions<WebApplication12Context> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}
