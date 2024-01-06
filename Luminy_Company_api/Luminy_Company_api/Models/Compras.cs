using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Luminy_Company_api.Models
{
    public class Compras
    {
        [Key]
        public int Id { get; set; }
        public string Data_compra { get; set; }
        public double Total_compra { get; set; }
        public int ClientesId { get; set; }
        public Clientes Cliente { get; set; }
        public int PassagemId { get; set; }
        public Passagem Passagem { get; set; }
    }
}