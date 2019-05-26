using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.O.B.O.Interfaces;
using R.O.B.O.Models;

namespace RoboUnitTest
{
    [TestClass]
    public class RotacaoTestes
    {
        //NomeDoMétodo_Cenário_ComportamentoEsperado
        [TestMethod]
        public void Rotacionar_RotacaoPermitidaPulso_RetornaTrue()
        {
            var pulso = new Pulso();
            var resultado = pulso.Rotacionar(Movimento.Positivo, (int)EstadoCotovelo.FortementeContraido);
            Assert.AreEqual(45, pulso.EstadoAtualRotacao);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Rotacionar_RotacaoPulsoAtingiuLimiteMaximo_RetornaFalse()
        {
            var pulso = new Pulso();

            var resultado = pulso.Rotacionar(Movimento.Positivo, (int)LimitesRotacaoPulso.ValorMaximo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Rotacionar_RotacaoPulsoAtingiuLimiteMinimo_RetornaFalse()
        {
            var pulso = new Pulso();

            var resultado = pulso.Rotacionar(Movimento.Negativo, (int)LimitesRotacaoPulso.ValorMinimo);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Rotacionar_RotacaoCabecaAtingiuLimiteMaximo_RetornaFalse()
        {
            var cabeca = new Cabeca();

            while(cabeca.EstadoAtualRotacao != (int)LimitesRotacaoCabeca.ValorMaximo)
            {
                cabeca.Rotacionar(Movimento.Positivo, cabeca.EstadoAtualRotacao);
            }

            var resultado = cabeca.Rotacionar(Movimento.Positivo, cabeca.EstadoAtualRotacao);

            Assert.AreEqual((int)EstadoInclinacao.EmRepouso, cabeca.EstadoAtualInclinacao);
            Assert.AreEqual((int)LimitesRotacaoCabeca.ValorMaximo, cabeca.EstadoAtualRotacao);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Rotacionar_RotacaoCabecaAtingiuLimiteMinimo_RetornaFalse()
        {
            var cabeca = new Cabeca();

            while (cabeca.EstadoAtualRotacao != (int)LimitesRotacaoCabeca.ValorMinimo)
            {
                cabeca.Rotacionar(Movimento.Negativo, cabeca.EstadoAtualRotacao);
            }

            var resultado = cabeca.Rotacionar(Movimento.Negativo, cabeca.EstadoAtualRotacao);

            Assert.AreEqual((int)EstadoInclinacao.EmRepouso, cabeca.EstadoAtualInclinacao);
            Assert.AreEqual((int)LimitesRotacaoCabeca.ValorMinimo, cabeca.EstadoAtualRotacao);
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void Cabeca_PropriedadesNaoNulas_NaoNulosComEstadosEmRepouso()
        {
            var rotacao = new Rotacao();
            Assert.IsNotNull(rotacao);
            Assert.AreEqual(0, rotacao.EstadoAtualRotacao);
        }
    }
}
