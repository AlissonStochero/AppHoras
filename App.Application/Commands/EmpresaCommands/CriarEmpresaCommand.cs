using App.Application.Services.Implementation;
using App.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Application.Commands.EmpresaCommands
{
    public class CriarEmpresaCommand : IRequest<Empresa>
    {
        public CriarEmpresaCommand(string nome, int cnpj)
        {
            Nome = nome;
            Cnpj = cnpj;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
        public string Nome { get; private set; }
        public int Cnpj { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
    }
}
