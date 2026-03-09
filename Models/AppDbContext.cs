using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace charts.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Chart> Charts { get; set; }
        public DbSet<ChartData> ChartDatas { get; set; }
    }
}
