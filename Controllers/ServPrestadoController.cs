using ApiTest.Interfaces;
using ApiTest.Models.Dtos.ServPrestatdoDto;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ServPrestadoController : ControllerBase
    {
        private readonly IServPrestado _interfaces;

        public ServPrestadoController(IServPrestado interfaces)
        {
            _interfaces = interfaces;
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody] AddServPrestadoDto dto)
        {
            var servico = _interfaces.Adicionar(dto);
            if (servico != null)
            {
                return Ok("Serviço cadastrado com sucesso!");
            }
            return BadRequest("Falha ao adicionar serviço.");
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            var servicos = _interfaces.BuscarTodos();
            if (servicos != null)
            {
                return Ok(servicos);
            }
            return NotFound("Servico não encontrado.");
        }
    }
}