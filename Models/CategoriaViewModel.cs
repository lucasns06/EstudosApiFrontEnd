using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace EstudosApiFront.Models
{
    public class CategoriaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public ICollection<TarefaViewModel> Tarefas { get; set; } = new List<TarefaViewModel>();
        // public int? UsuarioId { get; set; }
        // [JsonIgnore]
        // public Usuario? Usuario { get; set; }
    }
}