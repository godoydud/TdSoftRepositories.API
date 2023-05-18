using Microsoft.EntityFrameworkCore;
using TdSoftRepositories.API.Domain.Entities;

namespace TdSoftRepositories.API.Data.Context
{
    public class CoreContext : DbContext
    {
        public DbSet<Repository>? Repository { get; set; }

        public CoreContext(DbContextOptions<CoreContext> options) : base(options) { }

    }
}
