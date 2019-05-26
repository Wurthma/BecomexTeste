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
    public abstract class BracoController : ControllerBase
    {
        private IRobo _robo;
        protected abstract IBraco Braco { get; }

        public BracoController(IRobo robo)
        {
            _robo = robo;
        }

        [HttpPost]
        [Route(nameof(ContrairCotovelo))]
        public ActionResult<ResultadoViewModel> ContrairCotovelo()
        {
            bool sucesso = Braco.Cotovelo.Contrair();
            string menssagemResultado = Menssagens.Sucesso;
            if (!sucesso) { menssagemResultado = Menssagens.LimiteContracao; }

            return new ResultadoViewModel()
            {
                Sucesso = sucesso,
                Menssagem = menssagemResultado,
                Dados = _robo
            };
        }

        [HttpPost]
        [Route(nameof(DescontrairCotovelo))]
        public ActionResult<ResultadoViewModel> DescontrairCotovelo()
        {
            bool sucesso = Braco.Cotovelo.Descontrair();
            string menssagemResultado = Menssagens.Sucesso;
            if (!sucesso) { menssagemResultado = Menssagens.LimiteContracao; }

            return new ResultadoViewModel()
            {
                Sucesso = sucesso,
                Menssagem = menssagemResultado,
                Dados = _robo
            };
        }

        [HttpPost]
        [Route(nameof(RotacionarPulsoPositivo))]
        public ActionResult<ResultadoViewModel> RotacionarPulsoPositivo()
        {
            bool sucesso = Braco.Pulso.Rotacionar(Movimento.Positivo, Braco.Cotovelo.EstadoAtualContracao);
            string menssagemResultado = nameof(sucesso);
            if (!sucesso) { menssagemResultado = Menssagens.NaoFoiPossivelRotacionar; }

            return new ResultadoViewModel()
            {
                Sucesso = sucesso,
                Menssagem = menssagemResultado,
                Dados = _robo
            };
        }

        [HttpPost]
        [Route(nameof(RotacionarPulsoNegativo))]
        public ActionResult<ResultadoViewModel> RotacionarPulsoNegativo()
        {
            bool sucesso = Braco.Pulso.Rotacionar(Movimento.Negativo, Braco.Cotovelo.EstadoAtualContracao);
            string menssagemResultado = nameof(sucesso);
            if (!sucesso) { menssagemResultado = Menssagens.NaoFoiPossivelRotacionar; }

            return new ResultadoViewModel()
            {
                Sucesso = sucesso,
                Menssagem = menssagemResultado,
                Dados = _robo
            };
        }
    }
}
