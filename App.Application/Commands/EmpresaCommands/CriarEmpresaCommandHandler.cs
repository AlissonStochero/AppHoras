using App.Domain.Entities;
using App.Infrastructure.Persistence;
using MediatR;

namespace App.Application.Commands.EmpresaCommands
{
    public class CriarEmpresaCommandHandler : IRequestHandler<CriarEmpresaCommand, Empresa>
    {
        private readonly AppDbContext appdbContext;
        public CriarEmpresaCommandHandler(AppDbContext _appDbContext)
        {
            appdbContext = _appDbContext;
        }
        public async Task<Empresa> Handle(CriarEmpresaCommand request, CancellationToken cancellationToken)
        {
            var empresa = new Empresa(request.Nome, request.Cnpj);
            var empresacadastrada = await appdbContext.Empresas.AddAsync(empresa);
            _ = await appdbContext.SaveChangesAsync();
            return empresacadastrada.Entity;
        }
    }
}
