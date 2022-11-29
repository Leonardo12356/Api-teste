using ApiTest.Interfaces;
using ApiTest.Models.Dtos.Cliente;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class ClienteController : ControllerBase
    {
        private readonly ICliente _Interfaces;

        public ClienteController(ICliente interfaces)
        {
            _Interfaces = interfaces;
        }

        [HttpPost]
        public IActionResult Adicionar([FromBody] AddClienteDto dto)
        {
            var cliente = _Interfaces.Adicionar(dto);

            if (cliente != null)
            {
                return Ok("Cliente cadastrado com sucesso!");
            }
            return BadRequest("Falha ao cadastrar cliente.");
        }

        [HttpGet]
        public IActionResult BuscarTodos()
        {

            var cliente = _Interfaces.BuscarTodos();

            if (cliente != null)
            {
                return Ok(cliente);
            }

            return NotFound("Cliente não encontrado");
        }
    }
}