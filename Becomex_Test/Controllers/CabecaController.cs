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
    public class CabecaController : ControllerBase
    {
        private IRobo _robo;

        public CabecaController(IRobo robo)
        {
            _robo = robo;
        }

        [HttpPost]
        [Route(nameof(RotacionarCabecaPositivo))]
        public ActionResult<ResultadoViewModel> RotacionarCabecaPositivo()
        {
            bool sucesso = _robo.Cabeca.Rotacionar(Movimento.Positivo, _robo.Cabeca.EstadoAtualInclinacao);
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
        [Route(nameof(RotacionarCabecaNegativo))]
        public ActionResult<ResultadoViewModel> RotacionarCabecaNegativo()
        {
            bool sucesso = _robo.Cabeca.Rotacionar(Movimento.Negativo, _robo.Cabeca.EstadoAtualInclinacao);
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
        [Route(nameof(InclinarParaBaixo))]
        public ActionResult<ResultadoViewModel> InclinarParaBaixo()
        {
            bool sucesso = _robo.Cabeca.InclinarParaBaixo();
            string menssagemResultado = Menssagens.Sucesso;
            if (!sucesso) { menssagemResultado = Menssagens.LimiteInclinacao; }

            return new ResultadoViewModel()
            {
                Sucesso = sucesso,
                Menssagem = menssagemResultado,
                Dados = _robo
            };
        }

        [HttpPost]
        [Route(nameof(InclinarParaCima))]
        public ActionResult<ResultadoViewModel> InclinarParaCima()
        {
            bool sucesso = _robo.Cabeca.InclinarParaCima();
            string menssagemResultado = Menssagens.Sucesso;
            if (!sucesso) { menssagemResultado = Menssagens.LimiteInclinacao; }

            return new ResultadoViewModel()
            {
                Sucesso = sucesso,
                Menssagem = menssagemResultado,
                Dados = _robo
            };
        }
    }
}
