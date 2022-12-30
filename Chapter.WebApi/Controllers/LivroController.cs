using Chapter.WebApi.Interfaces;
using Chapter.WebApi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using System.Data;

namespace Chapter.WebApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[Livro]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly ILivroRepository _ilivroRepository;
        public LivroController(ILivroRepository ilivroRepository)
        {
            _ilivroRepository = ilivroRepository;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_ilivroRepository.Ler());
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }    
    }
}
