using System.Linq;
using BilheteriaCinema.Infra.EF.MapClass;
using BilheteriaCinema.Infra.EF.Model;
using Microsoft.EntityFrameworkCore;

namespace BilheteriaCinema.Infra.EF
{
    public class DbBilheteriaCinemaContext : DbContext
    {
        public DbSet<FilmeModel> Filmes { get; set; }
        public DbSet<IngressoModel> Ingressos { get; set; }
        public DbSet<SalaModel> Salas { get; set; }
        public DbSet<SessaoModel> Sessoes { get; set; }
        
        public DbBilheteriaCinemaContext(DbContextOptions options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
            
            modelBuilder.MapFilme();
            modelBuilder.MapIngresso();
            modelBuilder.MapSala();
            modelBuilder.MapSessao();
        }
    }
}