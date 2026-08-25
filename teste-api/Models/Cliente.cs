using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace teste_api.Models
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int id { get; set; }

        public string nome { get; set; }

        public string cpf { get; set; }

        public string? email { get; set; } // O ? significa que aceita nulo (igual no banco)
    }
}