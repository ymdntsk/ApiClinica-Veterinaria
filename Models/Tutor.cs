
using ApiClinica_Veterinaria.Models;
using System.Text.Json.Serialization;


namespace ApiClinica_Veterinaria.Models
{
    public class Tutor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }

        [JsonIgnore]
        public ICollection<Pet> Pets { get; set; } = new List<Pet>();
    }
}