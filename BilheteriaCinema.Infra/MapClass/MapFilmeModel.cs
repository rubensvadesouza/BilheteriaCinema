using BilheteriaCinema.Infra.EF.Model;
using Microsoft.EntityFrameworkCore;

namespace BilheteriaCinema.Infra.EF.MapClass
{
    public static class MapFilmeModel
    {
        public static void MapFilme(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FilmeModel>(e =>
            {
                e.ToTable("Filme", "dbo");
                
                e.HasIndex(p => p.Id)
                    .IsUnique();
                
                e.HasIndex(p => p.Codigo)
                    .IsUnique();

                e.Property(p => p.Id)
                    .ValueGeneratedOnAdd();
                e.Property(p => p.Nome)
                    .HasMaxLength(120)
                    .IsRequired();
                e.Property(p => p.Codigo)
                    .IsRequired();
                e.Property(p => p.Duracao)
                    .IsRequired();
                e.Property(p => p.FaixaEtaria)
                    .IsRequired();
                e.Property(p => p.Genero)
                    .HasMaxLength(20)
                    .IsRequired();
            });
        }
    }
}