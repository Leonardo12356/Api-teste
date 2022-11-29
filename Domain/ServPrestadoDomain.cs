using ApiTest.Data;
using ApiTest.Interfaces;
using ApiTest.Models.Dtos.ServPrestatdoDto;
using ApiTest.Models.Entities;
using AutoMapper;

namespace ApiTest.Domain
{
    public class ServPrestadoDomain : IServPrestado
    {
        public readonly AppDbContext _context;

        public readonly IMapper _mapper;

        public ServPrestadoDomain(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual ReadServPrestadoDto Adicionar(AddServPrestadoDto dto)
        {
            ServPrestado servico = _mapper.Map<ServPrestado>(dto);
            _context.ServsPrestados.Add(servico);
            _context.SaveChanges();
            ReadServPrestadoDto servPrestadoDto = _mapper.Map<ReadServPrestadoDto>(servico);
            return servPrestadoDto;
        }

        public ReadServPrestadoDto BuscarPorId(int id)
        {
            ServPrestado servico = _context.ServsPrestados.FirstOrDefault(servico => servico.IdServico == id);

            ReadServPrestadoDto servicoDto = _mapper.Map<ReadServPrestadoDto>(servico);
            return servicoDto;
        }

        public IEnumerable<ReadServPrestadoDto> BuscarTodos()
        {
            var lista = _context.ServsPrestados.ToList();
            IEnumerable<ReadServPrestadoDto> readServPrestadoDtos = _mapper.Map<List<ReadServPrestadoDto>>(lista);
            return readServPrestadoDtos;
        }

        public bool Excluir(int id)
        {
            ServPrestado servico = _context.ServsPrestados.FirstOrDefault(servico => servico.IdServico == id);

            if (servico != null)
            {
                _context.Remove(servico);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public ReadServPrestadoDto Editar(int id, AddServPrestadoDto dto)
        {
            ServPrestado servico = _context.ServsPrestados.FirstOrDefault(servico => servico.IdServico == id);
            if (servico != null)
            {
                _mapper.Map(dto, servico);

                ReadServPrestadoDto servicoDto = _mapper.Map<ReadServPrestadoDto>(servico);

                _context.SaveChanges();
                return servicoDto;
            }
            return null;
        }
    }
}