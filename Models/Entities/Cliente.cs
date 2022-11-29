using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiTest.Models.Entities
{
    [Table("cliente")]
    public class Cliente
    {
        [Key]
        [Required]
        [Column("id")]
        public int IdCliente { get; set; }

        [Required]
        [Column("nome")]
        public string Nome { get; set; }

        [Required]
        [Column("cpf")]
        public string CPF { get; set; }


        [Column("telefone")]
        public string NumeroTelefone { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [JsonIgnore]
        public virtual List<Carro> Carros { get; set; }
    }
}