using App.Application.Services.Interfaces;
using App.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmpresaController : ControllerBase
    {
        private readonly IEmpresaService _empresaService;
        public EmpresaController(IEmpresaService empresaService)
        {
            _empresaService = empresaService;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_empresaService.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] Empresa empresa)
        {
            return CreatedAtAction(nameof(Create),_empresaService.Create(empresa));
        }
    }
}
