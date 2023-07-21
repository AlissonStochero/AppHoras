using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class AtividadeRealizada: BaseEntity
    {
        public AtividadeRealizada(decimal horasFeitas, decimal valorRecebido, DateTime createdAt, DateTime updatedAt)
        {
            HorasFeitas = horasFeitas;
            ValorRecebido = valorRecebido;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public decimal HorasFeitas { get; private set; }
        public decimal ValorRecebido { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        // Relacionamento com a Tabela de Horas
        public Guid TabelaHorasId { get; set; }
        public TabelaHoras TabelaHoras { get; set; }
    }
}
