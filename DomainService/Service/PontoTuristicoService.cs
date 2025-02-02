using DDD.Domain.SinquiaContext;
using DDD.Infra.SQLServer.Interfaces;
using DomainService.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Service
{
    public class PontoTuristicoService : IPontoTuristicoService
    {
        public readonly IPontoTuristicoRepository _pontoTuristicoRepository;

        public PontoTuristicoService(IPontoTuristicoRepository pontoTuristicoRepository)
        {
            _pontoTuristicoRepository = pontoTuristicoRepository;
        }

            public List<PontoTuristico> GetPontoTuristico()
            {
                return _pontoTuristicoRepository.GetPontoTuristico();
            }

            public PontoTuristico GetPontoTuristicoById(int id)
            {
                return _pontoTuristicoRepository.GetPontoTuristicoById(id);
            }

            public void InsertPontoTuristico(PontoTuristico pontoTuristico)
            {
                _pontoTuristicoRepository.InsertPontoTuristico(pontoTuristico);
            }

            public void UpdatePontoTuristico(PontoTuristico pontoTuristico)
            {
                _pontoTuristicoRepository.UpdatePontoTuristico(pontoTuristico);
        }

        public void DeletePontoTuristico(int id)
        {

            var pontoTuristico = _pontoTuristicoRepository.GetPontoTuristicoById(id);
            if (pontoTuristico == null)
                throw new Exception("Esse ponto turistico não existe.");

            _pontoTuristicoRepository.DeletePontoTuristico(pontoTuristico);
        }
        public List<PontoTuristico> BuscarPorNomeOuDescricao(string termo)
        {
            return _pontoTuristicoRepository.BuscarPorNomeOuDescricao(termo);
        }
    }
}
