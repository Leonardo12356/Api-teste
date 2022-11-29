using ApiTest.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiTest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<ServPrestado> ServsPrestados { get; set; }

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);

            Builder.Entity<Carro>()
            .HasOne(carro => carro.Cliente)
            .WithMany(cliente => cliente.Carros)
            .HasForeignKey(carro => carro.IdCliente);

            Builder.Entity<Carro>()
            .HasOne(carro => carro.ServPrestado)
            .WithMany(servico => servico.Carros)
            .HasForeignKey(carro => carro.ServPrestadoId);
        }
    }
}