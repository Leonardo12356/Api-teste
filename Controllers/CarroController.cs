using ApiTest.Interfaces;
using ApiTest.Models.Dtos.Carro;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CarroController : ControllerBase
    {
        private readonly ICarro _Interfaces;

        public CarroController(ICarro interfaces)
        {
            _Interfaces = interfaces;
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody] AddCarroDto dto)
        {
            var carro = _Interfaces.Adicionar(dto);

            if (carro != null)
            {
                return Ok("Carro cadastrado com sucesso!");
            }

            return BadRequest("Falha ao cadastrar carro.");
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {
            var carro = _Interfaces.BuscarTodos();

            if (carro != null)
            {
                return Ok(carro);
            }
            return NotFound("Carro não encontrado.");
        }

    }
}