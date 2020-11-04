using maximo_P2_A2.Entities;
using Microsoft.EntityFrameworkCore;

namespace maximo_P2_A2.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Cobros> Cobros { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"DataSource=Data/cobro.db");
        } 
    }
}