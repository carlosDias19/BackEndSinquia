using ApplicationService.Interface;
using DDD.Domain.SinquiaContext;
using DDD.Infra.SQLServer.Interfaces;
using DomainService.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService.Application
{
    public class PontoTuristicoApplication : IPontoTuristicoApplication
    {
        public readonly IPontoTuristicoService _pontoTuristicoService;

        public PontoTuristicoApplication(IPontoTuristicoService pontoTuristicoService)
        {
            _pontoTuristicoService = pontoTuristicoService;
        }
        public List<PontoTuristico> GetPontoTuristico()
        {
            return _pontoTuristicoService.GetPontoTuristico();
        }

        public PontoTuristico GetPontoTuristicoById(int id)
        {
            return _pontoTuristicoService.GetPontoTuristicoById(id);
        }

        public void InsertPontoTuristico(PontoTuristico pontoTuristico)
        {
            _pontoTuristicoService.InsertPontoTuristico(pontoTuristico);
        }

        public void UpdatePontoTuristico(PontoTuristico pontoTuristico)
        {
            _pontoTuristicoService.UpdatePontoTuristico(pontoTuristico);
        }

        public void DeletePontoTuristico(int id)
        {
            _pontoTuristicoService.DeletePontoTuristico(id);
        }
        public List<PontoTuristico> BuscarPorNomeOuDescricao(string termo)
        {
            return _pontoTuristicoService.BuscarPorNomeOuDescricao(termo);
        }
    }
}
