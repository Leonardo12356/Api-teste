using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiTest.Models.Entities
{
    [Table("carros")]
    public class Carro
    {
        [Key]
        [Required]
        [Column("id")]
        public int IdCarro { get; set; }

        [Required]
        [Column("modelo")]
        public string Modelo { get; set; }
        [Required]
        [Column("marca")]
        public string Marca { get; set; }
        [Required]
        [Column("ano")]
        public string Ano { get; set; }


        [JsonIgnore]
        public virtual ServPrestado? ServPrestado { get; set; }

        [JsonIgnore]
        public int ServPrestadoId { get; set; }

        [JsonIgnore]
        public virtual Cliente Cliente { get; set; }


        [JsonIgnore]
        public int ClienteId { get; set; }

    }
}