namespace ApiTest.Models.Dtos.Carro
{
    public class AddCarroDto
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public string Ano { get; set; }
        public int ClienteId { get; set; }
        public int ServPrestadoId { get; set; }
    }
}