using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class Colaborador : BaseEntity
    {
        public Colaborador(string nome, DateTime createdAt, DateTime updatedAt)
        {
            Nome = nome;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public string Nome { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        // Relacionamento com a Empresa
        public int EmpresaId { get; set; }
        public Empresa Empresa { get; set; }
        public IList<TabelaHoras> TabelasHoras { get; set; }
        public IList<ValorHora> ValorHora { get; set; }
    }
}
