using Luminy_Company_api.Models;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Luminy_Company_api.Models
{
    public class Clientes
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        [JsonIgnore]
        public List<Compras> Compras { get; set; }
    }
}