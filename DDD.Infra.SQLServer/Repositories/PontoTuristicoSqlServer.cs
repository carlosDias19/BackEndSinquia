
using DDD.Domain.SinquiaContext;
using DDD.Infra.SQLite;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Repositories
{
    public class PontoTuristicoRepositorySqlServer : IPontoTuristicoRepository
    {

        private readonly SqlContext _context;

        public PontoTuristicoRepositorySqlServer(SqlContext context)
        {
            _context = context;
        }

        public void DeletePontoTuristico(PontoTuristico pontoTuristico)
        {
            try
            {
                _context.Set<PontoTuristico>().Remove(pontoTuristico);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public PontoTuristico GetPontoTuristicoById(int id)
        {
            return _context.PontoTuristico.Find(id);
        }

        public List<PontoTuristico> GetPontoTuristico()
        {
            return _context.PontoTuristico.ToList();

        }

        public void InsertPontoTuristico(PontoTuristico pontoTuristico)
        {
            try
            {
                _context.PontoTuristico.Add(pontoTuristico);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }

        public void UpdatePontoTuristico(PontoTuristico pontoTuristico)
        {
            try
            {
                _context.Entry(pontoTuristico).State = EntityState.Modified;
                _context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public List<PontoTuristico> BuscarPorNomeOuDescricao(string termo)
        {
            return _context.PontoTuristico
                .Where(p => p.Nome.Contains(termo) || p.Descricao.Contains(termo))
                .ToList();
        }

    }
}
