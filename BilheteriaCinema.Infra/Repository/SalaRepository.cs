using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;
using Microsoft.EntityFrameworkCore;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public class SalaRepository : ISalaRepository
    {
        private readonly DbBilheteriaCinemaContext _dbContext;

        public SalaRepository(DbBilheteriaCinemaContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<List<SalaModel>> BuscarSalas(bool? disponivel, int? min, int? max)
        {
            return await _dbContext.Salas.Where(x => (disponivel == null || x.Disponivel == disponivel) &&
                                        (min == null || x.Lugares >= min) &&
                                        (max == null || x.Lugares <= max))
                                        .ToListAsync();
        }

        public async Task<SalaModel> BuscarSala(int codigo)
        {
            return await _dbContext.Salas.FirstAsync(x => x.Codigo == codigo);
        }

        public async Task<SalaModel> CriarSala(SalaModel sala)
        {
            sala = _dbContext.Salas.Add(sala).Entity;
            await _dbContext.SaveChangesAsync();

            return sala;
        }
    }
}
