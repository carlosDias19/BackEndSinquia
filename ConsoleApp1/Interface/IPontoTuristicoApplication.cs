using DDD.Domain.SinquiaContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Interface
{
    public interface IPontoTuristicoApplication
    {
        void DeletePontoTuristico(int Id);
        List<PontoTuristico> GetPontoTuristico();
        PontoTuristico GetPontoTuristicoById(int id);
        void InsertPontoTuristico(PontoTuristico pontoTuristico);
        void UpdatePontoTuristico(PontoTuristico pontoTuristico);
        List<PontoTuristico> BuscarPorNomeOuDescricao(string termo);
    }
}
