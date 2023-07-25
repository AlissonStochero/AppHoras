using App.Application.Commands.EmpresaCommands.CriarEmpresa;
using App.Application.Services.Interfaces;
using App.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaService _empresaService;
        private readonly IMediator mediator;
        public EmpresaController(IEmpresaService empresaService, IMediator _mediator)
        {
            _empresaService = empresaService;
            mediator = _mediator;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_empresaService.GetAll());
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CriarEmpresaCommand command)
        {
            return CreatedAtAction(nameof(Create), await mediator.Send(command));
        }
    }
}
