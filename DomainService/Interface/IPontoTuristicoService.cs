using DDD.Domain.SinquiaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Interface
{
    public interface IPontoTuristicoService
    {
        void DeletePontoTuristico(int id);
        List<PontoTuristico> GetPontoTuristico();
        PontoTuristico GetPontoTuristicoById(int id);
        void InsertPontoTuristico(PontoTuristico pontoTuristico);
        void UpdatePontoTuristico(PontoTuristico pontoTuristico);
        List<PontoTuristico> BuscarPorNomeOuDescricao(string termo);

    }
}