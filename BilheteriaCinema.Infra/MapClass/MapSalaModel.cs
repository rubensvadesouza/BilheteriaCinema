using BilheteriaCinema.Infra.EF.Model;
using Microsoft.EntityFrameworkCore;

namespace BilheteriaCinema.Infra.EF.MapClass
{
    public static class MapSalaModel
    {
        public static void MapSala(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SalaModel>(e =>
            {
                e.ToTable("Sala", "dbo");
                
                e.HasIndex(p => p.Id)
                    .IsUnique();
                
                e.HasIndex(p => p.Codigo)
                    .IsUnique();

                e.Property(p => p.Id)
                    .ValueGeneratedOnAdd();
                e.Property(p => p.Descricao)
                    .HasMaxLength(240)
                    .IsRequired();
                e.Property(p => p.Lugares)
                    .IsRequired();
                e.Property(p => p.Disponivel)
                    .IsRequired();
            });
        }
    }
}