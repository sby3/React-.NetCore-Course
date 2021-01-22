using System;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        protected DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Value> Values {get; set; }
    }
}
