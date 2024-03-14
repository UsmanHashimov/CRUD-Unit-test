using Crud_Unit_Test.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Crud_Unit_Test.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
