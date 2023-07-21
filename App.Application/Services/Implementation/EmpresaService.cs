using App.Application.Services.Interfaces;
using App.Application.ViewModels;
using App.Domain.Entities;
using App.Infrastructure.Persistence;

namespace App.Application.Services.Implementation;

public class EmpresaService : IEmpresaService
{
    private readonly AppDbContext appdbContext;
    public EmpresaService(AppDbContext _appDbContext)
    {
        appdbContext = _appDbContext;
    }
    public List<Empresa> GetAll()
    {
        return appdbContext.Empresas.ToList();
    }
    public async Task<Guid> Create(Empresa empresa)
    {
        var empresacadastrada = await appdbContext.Empresas.AddAsync(empresa);
        await appdbContext.SaveChangesAsync();
        return empresacadastrada.Entity.Id;
    }
}
