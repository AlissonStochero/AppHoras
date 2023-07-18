using App.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Colaborador>()
            .HasOne(c => c.Empresa)
            .WithMany(e => e.Colaboradores)
            .HasForeignKey(c => c.EmpresaId)
            .OnDelete(DeleteBehavior.Cascade); // Ou outra ação apropriada quando uma empresa é excluída

        modelBuilder.Entity<TabelaHoras>()
            .HasOne(t => t.Colaborador)
            .WithMany(c => c.TabelasHoras)
            .HasForeignKey(t => t.ColaboradorId)
            .OnDelete(DeleteBehavior.Cascade); // Ou outra ação apropriada quando um colaborador é excluído

        modelBuilder.Entity<ValorHora>()
            .HasOne(v => v.Colaborador)
            .WithMany(c => c.ValorHora)
            .HasForeignKey(v => v.ColaboradorId)
            .OnDelete(DeleteBehavior.Cascade); // Ou outra ação apropriada quando um colaborador é excluído

        modelBuilder.Entity<AtividadeRealizada>()
            .HasOne(a => a.TabelaHoras)
            .WithMany(t => t.AtividadesRealizadas)
            .HasForeignKey(a => a.TabelaHorasId)
            .OnDelete(DeleteBehavior.Cascade);
    }

    public DbSet<Empresa> Empresas { get; set; }
    public DbSet<Colaborador> Colaboradores { get; set; }
    public DbSet<TabelaHoras> TabelasHoras { get; set; }
    public DbSet<ValorHora> ValoresHora { get; set; }
    public DbSet<AtividadeRealizada> AtividadesRealizadas { get; set; }
}
