using App.Application.ViewModels;
using App.Domain.Entities;

namespace App.Application.Services.Interfaces
{
    public interface IEmpresaService
    {
        List<Empresa> GetAll();
        Task<Guid> Create(Empresa empresa);
    }
}
