using FluentResults;

namespace ApiTest.Exceptions.Interfaces
{
    public interface IClienteException
    {
        Result ClienteJaCadastrado(string clienteCadastrado);
    }
}