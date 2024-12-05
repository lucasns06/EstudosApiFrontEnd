using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstudosApiFront.Models.Enuns;

namespace EstudosApiFront.Models
{
    public class TarefaViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public PrioridadeEnum Prioridade { get; set; }
        public bool Completo { get; set; } = false;
    }

}