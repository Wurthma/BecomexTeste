using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using R.O.B.O.Util;
using R.O.B.O.Models;

namespace API.ViewModels
{
    public class CabecaViewModel
    {
        [DisplayName("Estado atual de inclinação da cabeça")]
        public string EstadoAtualInclinacao { get; set; }

        [DisplayName("Estado atual da rotação da cabeça")]
        public string EstadoAtualRotacao { get; set; }
    }

    public class BracoViewModel
    {
        public BracoViewModel(CotoveloViewModel cotovelo, PulsoViewModel pulso)
        {
            Cotovelo = cotovelo;
            Pulso = pulso;
        }

        public CotoveloViewModel Cotovelo { get; set; }
        public PulsoViewModel Pulso { get; set; }
    }

    public class CotoveloViewModel
    {
        [DisplayName("Estado atual de contração do cotovelo")]
        public string EstadoAtualContracao { get; set; }
    }

    public class PulsoViewModel
    {
        [DisplayName("Estado atual da rotação do pulso")]
        public string EstadoAtualRotacao { get; set; }
    }

    public class RoboViewModel
    {
        public RoboViewModel(CabecaViewModel cabeca, BracoViewModel bracoEsquerdo, BracoViewModel bracoDireito)
        {
            Cabeca = cabeca;
            BracoEsquerdo = bracoEsquerdo;
            BracoDireito = bracoDireito;
        }

        public CabecaViewModel Cabeca { get; set; }
        public BracoViewModel BracoEsquerdo { get; set; }
        public BracoViewModel BracoDireito { get; set; }

        [DisplayName("Resposta do comando")]
        public bool Sucesso { get; set; }

        [DisplayName("Menssagem do comando")]
        public string Menssagem { get; set; }

        public static explicit operator RoboViewModel(ResultadoViewModel obj)
        {
            var robo = (Robo)obj.Dados;

            var roboVw = new RoboViewModel(
                new CabecaViewModel(), 
                new BracoViewModel(new CotoveloViewModel(), new PulsoViewModel()), 
                new BracoViewModel(new CotoveloViewModel(), new PulsoViewModel())
            );

            roboVw.Cabeca.EstadoAtualInclinacao = ConverterEstadoInclinacao(robo.Cabeca.EstadoAtualInclinacao);
            roboVw.Cabeca.EstadoAtualRotacao = Menssagens.GerarTextoRotacao(robo.Cabeca.EstadoAtualRotacao);
            roboVw.BracoEsquerdo.Cotovelo.EstadoAtualContracao = ConverterEstadoContracao(robo.BracoEsquerdo.Cotovelo.EstadoAtualContracao);
            roboVw.BracoEsquerdo.Pulso.EstadoAtualRotacao = Menssagens.GerarTextoRotacao(robo.BracoEsquerdo.Pulso.EstadoAtualRotacao);
            roboVw.BracoDireito.Cotovelo.EstadoAtualContracao = ConverterEstadoContracao(robo.BracoDireito.Cotovelo.EstadoAtualContracao);
            roboVw.BracoDireito.Pulso.EstadoAtualRotacao = Menssagens.GerarTextoRotacao(robo.BracoDireito.Pulso.EstadoAtualRotacao);
            roboVw.Sucesso = obj.Sucesso;
            roboVw.Menssagem = obj.Menssagem;

            return roboVw;
        }

        private static string ConverterEstadoInclinacao(int estadoInclinacao)
        {
            switch (estadoInclinacao)
            {
                case (int)EstadoInclinacao.EmRepouso:
                    return Menssagens.EmRepouso;
                case (int)EstadoInclinacao.ParaBaixo:
                    return Menssagens.ParaBaixo;
                case (int)EstadoInclinacao.ParaCima:
                    return Menssagens.ParaCima;
                default:
                    return Menssagens.Indenfinido;
            }
        }

        private static string ConverterEstadoContracao(int estadoContracao)
        {
            switch (estadoContracao)
            {
                case (int)EstadoCotovelo.EmRepouso:
                    return Menssagens.EmRepouso;
                case (int)EstadoCotovelo.Contraido:
                    return Menssagens.Contraido;
                case (int)EstadoCotovelo.LevementeContraido:
                    return Menssagens.LevementeContraido;
                case (int)EstadoCotovelo.FortementeContraido:
                    return Menssagens.FortementeContraido;
                default:
                    return Menssagens.Indenfinido;
            }
        }
    }
}
