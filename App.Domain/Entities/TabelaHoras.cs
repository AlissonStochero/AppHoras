using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Entities
{
    public class TabelaHoras : BaseEntity
    {
        public TabelaHoras(DateTime horaInicio, DateTime horaTermino, string descricaoAtividade, DateTime createdAt, DateTime updatedAt, Colaborador colaborador)
        {
            HoraInicio = horaInicio;
            HoraTermino = horaTermino;
            DescricaoAtividade = descricaoAtividade;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Colaborador = colaborador;
        }

        public DateTime HoraInicio { get; private set; }
        public DateTime HoraTermino { get; private set; }
        public string DescricaoAtividade { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        // Relacionamento com o Colaborador
        public int ColaboradorId { get; set; }
        public Colaborador Colaborador { get; set; }
        public IList<AtividadeRealizada> AtividadesRealizadas { get; set; }
    }
}
