using System;
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
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {

            
            modelBuilder.Entity<Clientes>().HasData(new Clientes() { Nombres = "FERRETERIA GAMA" , ClienteId = 1});

            modelBuilder.Entity<Ventas>().HasData(new Ventas() {VentaId = 1, Fecha = new DateTime(2020, 09, 01), ClienteId = 1, Monto = 1000, Balance = 1000 });

            modelBuilder.Entity<Ventas>().HasData(new Ventas() {VentaId = 2, Fecha = new DateTime(2020, 10, 01), ClienteId = 1, Monto = 900, Balance = 800 });

 

            modelBuilder.Entity<Clientes>().HasData(new Clientes() { Nombres = "AVALON DISCO" , ClienteId = 2});

            modelBuilder.Entity<Ventas>().HasData(new Ventas() {VentaId = 3, Fecha = new DateTime(2020, 09, 01), ClienteId = 2, Monto = 2000, Balance = 2000 });

            modelBuilder.Entity<Ventas>().HasData(new Ventas() {VentaId = 4,Fecha = new DateTime(2020, 10, 01), ClienteId = 2, Monto = 1900, Balance = 1800 });

 

            modelBuilder.Entity<Clientes>().HasData(new Clientes() { Nombres = "PRESTAMOS CEFIPROD" , ClienteId = 3});

            modelBuilder.Entity<Ventas>().HasData(new Ventas() {VentaId = 5,Fecha = new DateTime(2020, 09, 01), ClienteId = 3, Monto = 3000, Balance = 3000 });

            modelBuilder.Entity<Ventas>().HasData(new Ventas() {VentaId = 6, Fecha = new DateTime(2020, 10, 01), ClienteId = 3, Monto = 2900, Balance = 1900 });

        }
    }
}