using App.Application.Services.Interfaces;
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
    }
}
