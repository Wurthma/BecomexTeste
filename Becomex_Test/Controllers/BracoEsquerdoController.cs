using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;
using R.O.B.O.Interfaces;
using R.O.B.O.Models;
using R.O.B.O.Util;

namespace Becomex_Test.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BracoEsquerdoController : BracoController
    {
        private IRobo _robo;

        protected override IBraco Braco { get { return _robo.BracoEsquerdo; } }

        public BracoEsquerdoController(IRobo robo) : base(robo)
        {
            _robo = robo;
        }
    }
}
