namespace ApiTest.Models.Dtos.Carro
{
    public class AddCarroDto
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }
        public int IdCliente { get; set; }
        public int IdServico { get; set; }
    }
}