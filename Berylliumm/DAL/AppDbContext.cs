using Berylliumm.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Berylliumm.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<WorkPlace> WorkPlaces { get; set; }
        public DbSet<Slide> Slides { get; set; }

    }
}
