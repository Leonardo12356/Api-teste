using ApiTest.Models.Dtos.ServPrestatdoDto;
using ApiTest.Models.Entities;
using AutoMapper;

namespace ApiTest.Profiles
{
    public class ServPrestadoProfile : Profile
    {
        public ServPrestadoProfile()
        {
            CreateMap<AddServPrestadoDto, ServPrestado>();
            CreateMap<ServPrestado, ReadServPrestadoDto>();
        }
    }
}