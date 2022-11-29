namespace ApiTest.Models.Dtos.ServPrestatdoDto
{
    public class ReadServPrestadoDto
    {
        public int IdServico { get; set; }
        public string Servico { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        public virtual List<Models.Entities.Carro> ListaCarros { get; set; }
    }
}