using BilheteriaCinema.Infra.EF.Model;
using Microsoft.EntityFrameworkCore;

namespace BilheteriaCinema.Infra.EF.MapClass
{
    public static class MapSessaoModel
    {
        public static void MapSessao(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SessaoModel>(e =>
            {
                e.ToTable("Sessao", "dbo");
                
                e.HasIndex(p => p.Id)
                    .IsUnique();
                
                e.HasIndex(p => p.Codigo)
                    .IsUnique();

                e.Property(p => p.Id)
                    .ValueGeneratedOnAdd();
                e.Property(p => p.Descricao)
                    .HasMaxLength(240)
                    .IsRequired();
                e.Property(p => p.Horario)
                    .IsRequired();
                e.Property(p => p.Valor)
                    .IsRequired();
                e.Property(p => p.CodigoSala)
                    .IsRequired();
                e.Property(p => p.CodigoFilme)
                    .IsRequired();
            });
        }
    }
}