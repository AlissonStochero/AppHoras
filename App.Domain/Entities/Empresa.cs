using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class Empresa : BaseEntity
    {
        public Empresa(string nome, int cnpj, DateTime createdAt, DateTime updatedAt)
        {
            Nome = nome;
            Cnpj = cnpj;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public string Nome { get; private set; }
        public int Cnpj { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public IList<Colaborador> Colaboradores { get; private set; }
    }
}
