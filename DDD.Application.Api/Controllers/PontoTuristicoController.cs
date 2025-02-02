
using ApplicationService.Interface;
using DDD.Domain.SinquiaContext;
using DDD.Infra.SQLServer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DDD.Application.Api.Controllers
{
    [Route("api/[controller]")]
    //[Authorize]
    [ApiController] 
    public class PontoTuristicoController : ControllerBase
    {
        readonly IPontoTuristicoApplication _pontoTuristicoRepository;

        public PontoTuristicoController(IPontoTuristicoApplication pontoTuristicoRepository)
        {
            _pontoTuristicoRepository = pontoTuristicoRepository;
        }

        [HttpGet]
        public IActionResult GetPontoTuristico()
        {
            try
            {
                var pontoTuristicos = _pontoTuristicoRepository.GetPontoTuristico();
                return Ok(pontoTuristicos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetPontoTuristicoById(int id)
        {
            try
            {
                var pontoTuristico = _pontoTuristicoRepository.GetPontoTuristicoById(id);
                return Ok(pontoTuristico);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult InsertPontoTuristico(PontoTuristico pontoTuristico)
        {
            try
            {
                _pontoTuristicoRepository.InsertPontoTuristico(pontoTuristico);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult UpdatePontoTuristico(PontoTuristico pontoTuristico)
        {
            try
            {
                _pontoTuristicoRepository.UpdatePontoTuristico(pontoTuristico);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{Id}")]
        public IActionResult DeletePontoTuristico(int Id)
        {
            try
            {
                _pontoTuristicoRepository.DeletePontoTuristico(Id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("buscar")]
        public IActionResult BuscarPontoTuristico([FromQuery] string termo)
        {
            try
            {
                var resultados = _pontoTuristicoRepository.BuscarPorNomeOuDescricao(termo);
                return Ok(resultados);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
