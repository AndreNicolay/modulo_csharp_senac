using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace teste_api.Models
{
    [Table("Fruta")]
    public class Fruta
    {
        [Key]
        public int id { get; set; }

        public string? nome { get; set; }

        public string? cor { get; set; }

        public decimal? preco { get; set; }

        public int? quantidade { get; set; }

        public decimal? peso { get; set; }
    }
}