using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.O.B.O.Interfaces;
using R.O.B.O.Models;

namespace RoboUnitTest
{
    [TestClass]
    public class PulsoTestes
    {
        //NomeDoMétodo_Cenário_ComportamentoEsperado
        [TestMethod]
        public void Rotacionar_RotacaoPermitida_RetornaTrue()
        {
            var pulso = new Pulso();
            var resultado = pulso.Rotacionar(Movimento.Positivo, (int)EstadoCotovelo.FortementeContraido);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void Rotacionar_CotoveloSemContracaoSuficiente_RetornaFalse()
        {
            var pulso = new Pulso();
            var resultado = pulso.Rotacionar(Movimento.Positivo, (int)EstadoCotovelo.LevementeContraido);
            var resultado2 = pulso.Rotacionar(Movimento.Positivo, (int)EstadoCotovelo.Contraido);
            var resultado3 = pulso.Rotacionar(Movimento.Positivo, (int)EstadoCotovelo.EmRepouso);
            Assert.IsFalse(resultado);
            Assert.IsFalse(resultado2);
            Assert.IsFalse(resultado3);
        }

        [TestMethod]
        public void Cabeca_PropriedadesNaoNulas_NaoNulosComEstadosEmRepouso()
        {
            var pulso = new Pulso();
            Assert.IsNotNull(pulso);
            Assert.AreEqual(0, pulso.EstadoAtualRotacao);
        }
    }
}
