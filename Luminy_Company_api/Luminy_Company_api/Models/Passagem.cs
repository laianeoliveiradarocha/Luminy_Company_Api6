using Luminy_Company_api.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Luminy_Company_api.Models
{
    public class Passagem
    {
        [Key]
        public int Id { get; set; }
        public string Destino { get; set; }
        public double Preco { get; set; }
        [JsonIgnore]
        public List<Compras> Compras { get; set; }
    }
}