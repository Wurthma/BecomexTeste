using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using R.O.B.O.Interfaces;
using R.O.B.O.Models;

namespace Becomex_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoboController : ControllerBase
    {
        private IRobo _robo;

        public RoboController(IRobo robo)
        {
            _robo = robo;
        }


        // GET api/Robo
        [HttpGet]
        public ActionResult<ResultadoViewModel> Get()
        {
            return new ResultadoViewModel()
            {
                Sucesso = true,
                Menssagem = "Sucesso",
                Dados = _robo
            };
        }
    }
}
