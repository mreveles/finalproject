using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;

namespace BuffTeks.Models {

    public class BuffTeksDBContext : DbContext {

        public BuffTeksDBContext(DbContextOptions<BuffTeksDBContext> options)
            : base(options) { }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Project> Projects{ get;set; }

    }
}