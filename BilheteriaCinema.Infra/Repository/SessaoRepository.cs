using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BilheteriaCinema.Infra.EF.Model;
using Microsoft.EntityFrameworkCore;

namespace BilheteriaCinema.Infra.EF.Repository
{
    public class SessaoRepository : ISessaoRepository
    {
        private readonly DbBilheteriaCinemaContext _dbContext;

        public SessaoRepository(DbBilheteriaCinemaContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<List<SessaoModel>> BuscarSessoes(DateTime? inicio, DateTime? fim, int? sala, int? filme)
        {
            return await _dbContext.Sessoes.Where(x => (inicio == null || x.Horario >= inicio) &&
                                                     (fim == null || x.Horario <= fim) &&
                                                     (sala == null || x.CodigoSala == sala) &&
                                                     (filme == null || x.CodigoFilme == filme))
                                                .ToListAsync();
        }

        public async Task<SessaoModel> BuscarSessao(int codigo)
        {
            return await _dbContext.Sessoes.FirstAsync(x => x.Codigo == codigo);
        }

        public async Task<SessaoModel> CriarSessao(SessaoModel sessao)
        {
            sessao = _dbContext.Sessoes.Add(sessao).Entity;
            await _dbContext.SaveChangesAsync();

            return sessao;
        }

        public async Task DeletarSessao(int codigo)
        {
            var sessao = await _dbContext.Sessoes.FirstAsync(x => x.Codigo == codigo);
            
            _dbContext.Remove(sessao);
            await _dbContext.SaveChangesAsync();
        }
    }
}
