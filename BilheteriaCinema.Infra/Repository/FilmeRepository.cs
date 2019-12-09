using System.Collections.Generic;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;
using Microsoft.EntityFrameworkCore;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public class FilmeRepository : IFilmeRepository
    {
        private readonly DbBilheteriaCinemaContext _dbContext;

        public FilmeRepository(DbBilheteriaCinemaContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<List<FilmeModel>> BuscarFilmes()
        {
            return await _dbContext.Filmes.ToListAsync();
        }

        public async Task<FilmeModel> BuscarFilme(int codigo)
        {
            return await _dbContext.Filmes.FirstAsync(x => x.Codigo == codigo);
        }
    }
}
