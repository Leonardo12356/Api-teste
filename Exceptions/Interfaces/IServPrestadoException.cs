using FluentResults;

namespace ApiTest.Exceptions.Interfaces
{
    public interface IServPrestadoException
    {
        Result ServicoJaCadastrado(double valorServ);
    }
}