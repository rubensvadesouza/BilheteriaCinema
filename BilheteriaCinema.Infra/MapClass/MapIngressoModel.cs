using BilheteriaCinema.Infra.EF.Model;
using Microsoft.EntityFrameworkCore;

namespace BilheteriaCinema.Infra.EF.MapClass
{
    public static class MapIngressoModel
    {
        public static void MapIngresso(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IngressoModel>(e =>
            {
                e.ToTable("Ingresso", "dbo");
                
                e.HasIndex(p => p.Id)
                    .IsUnique();
                
                e.HasIndex(p => p.Codigo)
                    .IsUnique();

                e.Property(p => p.Id)
                    .ValueGeneratedOnAdd();
                e.Property(p => p.CPF)
                    .HasMaxLength(11)
                    .IsRequired();
                e.Property(p => p.DataCompra)
                    .IsRequired();
                e.Property(p => p.ValorPago)
                    .IsRequired();
                e.Property(p => p.Observacao)
                    .HasMaxLength(240)
                    .IsRequired();
                e.Property(p => p.CodigoSessao)
                    .IsRequired();
            });
        }
    }
}