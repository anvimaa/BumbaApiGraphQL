using BumbaApiGraphQL.Models;
using Microsoft.EntityFrameworkCore;

namespace BumbaApiGraphQL.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> User { get; set; }
    }
}
