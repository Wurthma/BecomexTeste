using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using API.ViewModels;
using Becomex_Test.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using R.O.B.O.Interfaces;

namespace API.Controllers
{
    /// <summary>
    /// Razor page para envio de comandos para o robo.
    /// </summary>
    [ApiExplorerSettings(IgnoreApi = true)]
    [Route("[controller]")]
    public class ComandosRoboController : Controller
    {
        private IRobo _robo;

        public ComandosRoboController(IRobo robo)
        {
            _robo = robo;
        }

        public IActionResult Index(int id = 0)
        {
            ResultadoViewModel dados = new ResultadoViewModel();

            switch (id)
            {
                case 0: //Buscar dados robo
                    dados = new RoboController(_robo).Get().Value;
                    break;

                #region Cabeça
                case 1: //Inclinar cabeça para baixo
                    dados = new CabecaController(_robo).InclinarParaBaixo().Value;
                    break;
                case 2: //Inclinar cabeça para cima
                    dados = new CabecaController(_robo).InclinarParaCima().Value;
                    break;
                case 3: //Rotação positiva cabeça
                    dados = new CabecaController(_robo).RotacionarCabecaPositivo().Value;
                    break;
                case 4: //Rotação negavita cabeça
                    dados = new CabecaController(_robo).RotacionarCabecaNegativo().Value;
                    break;
                #endregion Cabeça

                #region Braço Esquerdo
                case 5: //Contrair cotovelo esquerdo
                    dados = new BracoEsquerdoController(_robo).ContrairCotovelo().Value;
                    break;
                case 6: //Descontrair cotovelo esquerdo
                    dados = new BracoEsquerdoController(_robo).DescontrairCotovelo().Value;
                    break;
                case 7: //Rotação positiva pulso esquerdo
                    dados = new BracoEsquerdoController(_robo).RotacionarPulsoPositivo().Value;
                    break;
                case 8: //Rotação negativa pulso esquerdo
                    dados = new BracoEsquerdoController(_robo).RotacionarPulsoNegativo().Value;
                    break;
                #endregion Braço Esquerdo

                #region Braço Direito
                case 9: //Contrair cotovelo esquerdo
                    dados = new BracoDireitoController(_robo).ContrairCotovelo().Value;
                    break;
                case 10: //Descontrair cotovelo esquerdo
                    dados = new BracoDireitoController(_robo).DescontrairCotovelo().Value;
                    break;
                case 11: //Rotação positiva pulso esquerdo
                    dados = new BracoDireitoController(_robo).RotacionarPulsoPositivo().Value;
                    break;
                case 12: //Rotação negativa pulso esquerdo
                    dados = new BracoDireitoController(_robo).RotacionarPulsoNegativo().Value;
                    break;
                #endregion Braço Direito
            }

            RoboViewModel comandosRobo = (RoboViewModel)dados;

            return View(comandosRobo);
        }
    }
}