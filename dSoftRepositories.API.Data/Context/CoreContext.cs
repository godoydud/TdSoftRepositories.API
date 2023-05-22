using Microsoft.EntityFrameworkCore;
using TdSoftRepositories.API.Domain.Entities;

namespace TdSoftRepositories.API.Data.Context
{
    public class CoreContext : DbContext
    {
        public DbSet<repositories>? repositories { get; set; }
        public DbSet<actors>? actors { get; set; }

        public CoreContext(DbContextOptions<CoreContext> options) : base(options) { }

    }
}
