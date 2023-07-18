using App.Application.ViewModels;

namespace App.Application.Services.Interfaces
{
    public interface IEmpresaService
    {
        List<EmpresaViewModel> GetAll();
    }
}
