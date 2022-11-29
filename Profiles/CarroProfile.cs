using ApiTest.Models.Dtos.Carro;
using ApiTest.Models.Entities;
using AutoMapper;

namespace ApiTest.Profiles
{
    public class CarroProfile : Profile
    {
        public CarroProfile()
        {
            CreateMap<AddCarroDto, Carro>();
            CreateMap<Carro, ReadCarroDto>();
        }
    }
}