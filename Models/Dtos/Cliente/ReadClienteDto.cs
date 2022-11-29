namespace ApiTest.Models.Dtos.Cliente
{
    public class ReadClienteDto
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }

        public virtual List<Models.Entities.Carro> Carros { get; set; }

    }
}