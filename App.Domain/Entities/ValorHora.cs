using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class ValorHora : BaseEntity
    {
        public ValorHora(decimal valor, DateTime data, DateTime createdAt, DateTime updatedAt)
        {
            Valor = valor;
            Data = data;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public decimal Valor { get; private set; }
        public DateTime Data { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        // Relacionamento com o Colaborador
        public int ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }
    }
}
