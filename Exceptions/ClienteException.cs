using ApiTest.Data;
using ApiTest.Exceptions.Interfaces;
using FluentResults;

namespace ApiTest.Exceptions
{
    public class ClienteException : IClienteException
    {
        private readonly AppDbContext _context;

        public ClienteException(AppDbContext context)
        {
            _context = context;
        }

        public Result ClienteJaCadastrado(string clienteCadastrado)
        {
            var cliente = _context.Clientes.FirstOrDefault(cliente => cliente.Nome == clienteCadastrado);

            if (cliente != null)
            {
                return Result.Fail("Cliente já cadastrado.");
            }

            return Result.Ok();
        }
    }
}