using ApiTest.Data;
using ApiTest.Interfaces;
using ApiTest.Models.Dtos.Cliente;
using ApiTest.Models.Entities;
using AutoMapper;

namespace ApiTest.Domain
{
    public class ClienteDomain : ICliente
    {
        public readonly AppDbContext _context;

        public readonly IMapper _mapper;

        public ClienteDomain(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public virtual ReadClienteDto Adicionar(AddClienteDto dto)
        {
            Cliente cliente = _mapper.Map<Cliente>(dto);

            ReadClienteDto clienteDto = _mapper.Map<ReadClienteDto>(cliente);
            _context.Clientes.Add(cliente);
            _context.SaveChanges();

            return clienteDto;
        }

        public ReadClienteDto BuscarPorId(int id)
        {
            var Cliente = _context.Clientes.FirstOrDefault(cliente => cliente.IdCliente == id);

            ReadClienteDto clienteDto = _mapper.Map<ReadClienteDto>(Cliente);
            return clienteDto;
        }

        public IEnumerable<ReadClienteDto> BuscarTodos()
        {
            var clientes = _context.Clientes.ToList();

            IEnumerable<ReadClienteDto> clientesDtos = _mapper.Map<List<ReadClienteDto>>(clientes);

            return clientesDtos;
        }

        public ReadClienteDto Editar(int id, AddClienteDto dto)
        {
            var clientes = _context.Clientes.FirstOrDefault(cliente => cliente.IdCliente == id);

            if (clientes != null)
            {
                _mapper.Map(dto, clientes);

                ReadClienteDto clienteDto = _mapper.Map<ReadClienteDto>(clientes);
                _context.SaveChanges();

                return clienteDto;
            }

            return null;
        }

        public bool Excluir(int id)
        {
            var clientes = _context.Clientes.FirstOrDefault(cliente => cliente.IdCliente == id);

            if (clientes != null)
            {
                _context.Clientes.Remove(clientes);
                _context.SaveChanges();
                return true;
            }

            return false;
        }

    }
}