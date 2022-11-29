using ApiTest.Data;
using ApiTest.Exceptions.Interfaces;
using FluentResults;

namespace ApiTest.Exceptions
{
    public class ServPrestadoException : IServPrestadoException
    {
        public readonly AppDbContext _context;

        public ServPrestadoException(AppDbContext context)
        {
            _context = context;
        }

        public Result ServicoJaCadastrado(double valorServ)
        {
            var serv = _context.ServsPrestados.FirstOrDefault(serv => serv.Valor == valorServ);

            if (serv != null)
            {
                return Result.Fail("Não possui pagamento");
            }
            return Result.Ok();
        }


    }
}