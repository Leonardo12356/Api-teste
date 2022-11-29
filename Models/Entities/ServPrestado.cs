using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiTest.Models.Entities
{
    [Table("servPrestado")]
    public class ServPrestado
    {
        [Key]
        [Required]
        [Column("id")]
        public int IdServico { get; set; }

        [Column("servico")]
        public string Servico { get; set; }

        [Required]
        [Column("valor")]
        public double Valor { get; set; }
        [Required]
        [Column("data")]
        public DateTime Data { get; set; }

        [JsonIgnore]
        public virtual List<Carro> Carros { get; set; }
    }
}