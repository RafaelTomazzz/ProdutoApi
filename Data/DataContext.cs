using Microsoft.EntityFrameworkCore;
using ProdutoApi.Models;
using System;

namespace ProdutoApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasData
            (
                new Produto() { Id = 1, Nome = "Produto01", Valor = 20, Validade = Convert.ToDateTime("5/12/2023")},
                new Produto() { Id = 2, Nome = "Produto02", Valor = 30, Validade = Convert.ToDateTime("20/10/2023")},
                new Produto() { Id = 3, Nome = "Produto03", Valor = 5, Validade = Convert.ToDateTime("10/10/2024")},
                new Produto() { Id = 4, Nome = "Produto04", Valor = 50, Validade = Convert.ToDateTime("27/01/2024")}
            );
        }
    }
}