using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
         : base(options) { }

        public DbSet<Property> Properties { get; set; }
}
}
