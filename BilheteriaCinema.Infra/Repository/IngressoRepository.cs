using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;
using Microsoft.EntityFrameworkCore;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public class IngressoRepository : IIngressoRepository
    {
        private readonly DbBilheteriaCinemaContext _dbContext;

        public IngressoRepository(DbBilheteriaCinemaContext dbContext)
        {
            _dbContext = dbContext;
        }
       
        public async Task<IngressoModel> BuscarIngresso(int codigo)
        {
            return await _dbContext.Ingressos.FirstAsync(x => x.Codigo == codigo);
        }

        public async Task<IngressoModel> CriarIngresso(IngressoModel ingresso)
        {
            ingresso = _dbContext.Ingressos.Add(ingresso).Entity;
            await _dbContext.SaveChangesAsync();

            return ingresso;
        }

        public async Task DeletarIngresso(int codigo)
        {
            var ingresso = await _dbContext.Ingressos.FirstAsync(x => x.Codigo == codigo);
            
            _dbContext.Remove(ingresso);
            await _dbContext.SaveChangesAsync();
        }
    }
}
