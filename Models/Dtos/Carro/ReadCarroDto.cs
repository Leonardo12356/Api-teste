
namespace ApiTest.Models.Dtos.Carro
{
    public class ReadCarroDto
    {

        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }

        public virtual Models.Entities.Cliente Cliente { get; set; }
        public virtual List<Models.Entities.ServPrestado>? Servicos { get; set; }

        public int IdCliente { get; set; }
        public int IdServico { get; set; }


    }
}