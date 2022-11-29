using ApiTest.Data;
using ApiTest.Interfaces;
using ApiTest.Models.Dtos.Carro;
using ApiTest.Models.Entities;
using AutoMapper;

namespace ApiTest.Domain
{
    public class CarroDomain : ICarro
    {
        public readonly AppDbContext _context;
        public readonly IMapper _mapper;

        public CarroDomain(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual ReadCarroDto Adicionar(AddCarroDto dto)
        {
            Carro carro = _mapper.Map<Carro>(dto);

            _context.Carros.Add(carro);

            ReadCarroDto carroDto = _mapper.Map<ReadCarroDto>(carro);
            _context.SaveChanges();

            return carroDto;
        }

        public ReadCarroDto BuscarPorId(int id)
        {
            var Carro = _context.Carros.FirstOrDefault(carro => carro.IdCarro == id);

            ReadCarroDto carroDto = _mapper.Map<ReadCarroDto>(Carro);
            return carroDto;
        }

        public IEnumerable<ReadCarroDto> BuscarTodos()
        {
            var carros = _context.Carros.ToList();

            IEnumerable<ReadCarroDto> carrosDtos = _mapper.Map<List<ReadCarroDto>>(carros);

            return carrosDtos;
        }

        public ReadCarroDto Editar(int id, AddCarroDto dto)
        {
            var carros = _context.Carros.FirstOrDefault(carro => carro.IdCarro == id);

            if (carros != null)
            {
                _mapper.Map(dto, carros);

                ReadCarroDto carroDto = _mapper.Map<ReadCarroDto>(carros);
                _context.SaveChanges();

                return carroDto;
            }
            return null;
        }

        public bool Excluir(int id)
        {
            var carros = _context.Carros.FirstOrDefault(carro => carro.IdCarro == id);

            if (carros != null)
            {
                _context.Carros.Remove(carros);
                _context.SaveChanges();
                return true;
            }

            return false;
        }
    }
}