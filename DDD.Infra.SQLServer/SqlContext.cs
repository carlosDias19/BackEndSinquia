using DDD.Domain.SinquiaContext;
using DDD.Domain.UserManagementContext;
using Microsoft.EntityFrameworkCore;


namespace DDD.Infra.SQLite
{
    public class SqlContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=SinquiaDB.db");
        }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Estado> Estado { get; set; }
        public DbSet<PontoTuristico> PontoTuristico { get; set; }

    }
}
