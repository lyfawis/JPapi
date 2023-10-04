
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelo.Application;
using Modelo.Application.Interface;
using Modelo.Domain;

namespace JPapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoApplication _alunoApplication;

        public AlunoController(IAlunoApplication alunoApplication)
        {
            _alunoApplication = alunoApplication;
        }
                

        [HttpGet("BuscarDadosAluno/{id}")]

        public async Task<IActionResult> BuscarDadosAluno(int id)
        {

            try
            {
                var aluno = _alunoApplication.BuscarAluno(id);
                return Ok(aluno);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}

