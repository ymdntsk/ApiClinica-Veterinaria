using ApiClinica_Veterinaria.Models;
using System.Text.Json.Serialization;


namespace ApiClinica_Veterinaria.Models
{
    public class Veterinario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CRMV { get; set; }
        public string Especialidade { get; set; }

        [JsonIgnore]
        public ICollection<Consulta> Consultas { get; set; } = new List<Consulta>();
    }
}