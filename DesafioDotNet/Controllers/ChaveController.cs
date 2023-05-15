using DesafioNet.Business.Models;
using DesafioNet.Business.Service;
using Microsoft.AspNetCore.Mvc;

namespace DesafioDotNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChaveController : ControllerBase
    {
        private readonly ChaveService chaveService;


        public ChaveController(ChaveService chaveService)
        {
            this.chaveService = chaveService;
        }

        [HttpPost]
        public ActionResult Post(Chave chave)
        {
            try
            {
                chaveService.CadastrarChave(chave);
                return Ok("Sua chave foi criada!");
            }
            catch
            {

                return BadRequest("Não foi possivel criar sua chave!");
            }

            
        }

    }
}
