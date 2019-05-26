using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.O.B.O.Interfaces;
using R.O.B.O.Models;

namespace RoboUnitTest
{
    [TestClass]
    public class CotoveloTestes
    {
        //NomeDoMétodo_Cenário_ComportamentoEsperado
        [TestMethod]
        public void Contrair_ContracaoNaoAtingiuLimite_RetornaTrue()
        {
            var cotovelo = new Cotovelo();
            var resultado = cotovelo.Contrair();
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Contrair_ContracaoAtingiuLimite_RetornaFalse()
        {
            var cotovelo = new Cotovelo();

            while(cotovelo.EstadoAtualContracao != (int)LimitesEstadoCotovelo.ValorMaximo)
            {
                cotovelo.Contrair();
            }

            var resultado = cotovelo.Contrair();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Descontrair_DescontracaoNaoAtingiuLimite_RetornaTrue()
        {
            var cotovelo = new Cotovelo();
            cotovelo.Contrair();
            var resultado = cotovelo.Descontrair();
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Descontrair_DescontracaoAtingiuLimite_RetornaFalse()
        {
            var cotovelo = new Cotovelo();

            while (cotovelo.EstadoAtualContracao != (int)LimitesEstadoCotovelo.ValorMinimo)
            {
                cotovelo.Descontrair();
            }

            var resultado = cotovelo.Descontrair();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Cabeca_PropriedadesNaoNulas_NaoNulosComEstadosEmRepouso()
        {
            Cotovelo cotovelo = new Cotovelo();
            Assert.IsNotNull(cotovelo);
            Assert.AreEqual((int)EstadoCotovelo.EmRepouso, cotovelo.EstadoAtualContracao);
        }
    }
}
