using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace BuffTeks.Models {

    public class BuffTeksDBContext : DbContext {

        public BuffTeksDBContext(DbContextOptions<BuffTeksDBContext> options)
            : base(options) { }

        public DbSet<BuffTeks.Models.Client> Clients { get; set; }
        public DbSet<BuffTeks.Models.Member> Members { get; set; }
        public DbSet<BuffTeks.Models.Project> Projects{ get;set; }

    }

    // public class BuffTeksDBContextFactory
    //         : IDesignTimeDbContextFactory<BuffTeksDBContext> {

    //     public BuffTeksDBContext CreateDbContext(string[] args) =>
    //         Program.BuildWebHost(args).Services
    //             .GetRequiredService<BuffTeksDBContext>();
    // }
}