using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class TabelaHoras : BaseEntity
    {
        public TabelaHoras(DateTime horaInicio, DateTime horaTermino, string descricaoAtividade, DateTime createdAt, DateTime updatedAt)
        {
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            DescricaoAtividade = descricaoAtividade;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }

        public DateTime HoraInicio { get; private set; }
        public DateTime HoraTermino { get; private set; }
        public string DescricaoAtividade { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        // Relacionamento com o Colaborador
        [ForeignKey(nameof(Colaborador))]
        public Guid ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }
        public IList<AtividadeRealizada> AtividadesRealizadas { get; set; }
    }
}
