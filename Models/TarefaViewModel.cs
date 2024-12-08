using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using EstudosApiFront.Models.Enuns;

namespace EstudosApiFront.Models
{
    public class TarefaViewModel
    {
        [JsonIgnore]
        public int Id { get; set; }
        public string DataTermino { get; set; }
        public string Nome { get; set; } = string.Empty;
        public PrioridadeEnum Prioridade { get; set; }
        public bool Completo { get; set; } = false;
        public int CategoriaId { get; set; }
        //[JsonIgnore]
        //public CategoriaViewModel? Categoria { get; set; } = new CategoriaViewModel();
    }
}