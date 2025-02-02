
using DDD.Domain.SinquiaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Infra.SQLServer.Interfaces
{
    public interface IPontoTuristicoRepository
    {
        public List<PontoTuristico> GetPontoTuristico();
        public PontoTuristico GetPontoTuristicoById(int id);
        public void InsertPontoTuristico(PontoTuristico pontoTuristico);
        public void UpdatePontoTuristico(PontoTuristico pontoTuristico);
        public void DeletePontoTuristico(PontoTuristico pontoTuristico);
        public List<PontoTuristico> BuscarPorNomeOuDescricao(string termo);
    }
}