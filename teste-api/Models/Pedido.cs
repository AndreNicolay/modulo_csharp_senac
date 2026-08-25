using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace teste_api.Models
{
    [Table("Pedido")]
    public class Pedido
    {
        [Key]
        public int id { get; set; }

        public DateTime data_compra { get; set; }

        public decimal valor_total { get; set; }

        public int cliente_id { get; set; }

        public int fruta_id { get; set; }
        public int quantidade_comprada { get; set; }
    }
}