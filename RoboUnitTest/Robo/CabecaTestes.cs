using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.O.B.O.Models;
using R.O.B.O.Util;

namespace RoboUnitTest
{
    [TestClass]
    public class CabecaTestes
    {
        //NomeDoMétodo_Cenário_ComportamentoEsperado
        [TestMethod]
        public void InclinarParaCima_InclinacaoNaoAtingiuLimite_RetornaTrue()
        {
            //Arrange
            var cabeca = new Cabeca();

            //Act
            var resultado = cabeca.InclinarParaCima();

            //Assert
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void InclinarParaCima_InclinacaoAtingiuLimite_RetornaFalse()
        {
            var cabeca = new Cabeca();
            while(cabeca.EstadoAtualInclinacao != (int)EstadoInclinacao.ParaCima)
            {
                cabeca.InclinarParaCima();
            }

            var resultado = cabeca.InclinarParaCima();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void InclinarParaBaixo_InclinacaoNaoAtingiuLimite_RetornaTrue()
        {
            var cabeca = new Cabeca();
            var resultado = cabeca.InclinarParaBaixo();
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void InclinarParaBaixo_InclinacaoAtingiuLimite_RetornaFalse()
        {
            var cabeca = new Cabeca();
            while (cabeca.EstadoAtualInclinacao != (int)EstadoInclinacao.ParaBaixo)
            {
                cabeca.InclinarParaBaixo();
            }

            var resultado = cabeca.InclinarParaBaixo();

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Rotacionar_PermiteRotacaoPositivo_RetornaTrue()
        {
            var cabeca = new Cabeca();
            var resultado = cabeca.Rotacionar(Movimento.Positivo, (int)EstadoInclinacao.EmRepouso);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Rotacionar_PermiteRotacaoNegativa_RetornaTrue()
        {
            var cabeca = new Cabeca();
            var resultado = cabeca.Rotacionar(Movimento.Negativo, (int)EstadoInclinacao.EmRepouso);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Rotacionar_NaoPermiteRotacao_RetornaFalse()
        {
            var cabeca = new Cabeca();
            var resultado = cabeca.Rotacionar(Movimento.Negativo, (int)EstadoInclinacao.ParaBaixo);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Cabeca_PropriedadesNaoNulas_NaoNulosComEstadosEmRepouso()
        {
            Cabeca cabeca = new Cabeca();
            Assert.IsNotNull(cabeca);
            Assert.AreEqual((int)EstadoInclinacao.EmRepouso, cabeca.EstadoAtualInclinacao);
            Assert.AreEqual(0, cabeca.EstadoAtualRotacao);
        }
    }
}
