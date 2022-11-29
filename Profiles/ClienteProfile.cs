using ApiTest.Models.Dtos.Cliente;
using ApiTest.Models.Entities;
using AutoMapper;

namespace ApiTest.Profiles
{
    public class ClienteProfile : Profile
    {
        public ClienteProfile()
        {
            CreateMap<AddClienteDto, Cliente>();
            CreateMap<Cliente, ReadClienteDto>();
        }
    }
}