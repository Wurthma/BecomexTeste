using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.O.B.O.Models;

namespace RoboUnitTest
{
    [TestClass]
    public class BracoTestes
    {
        //NomeDoMétodo_Cenário_ComportamentoEsperado
        [TestMethod]
        public void Braco_PropriedadesNaoNulas_NaoNulosComEstadosEmRepouso()
        {
            Braco braco = new Braco(
                new Cotovelo(), 
                new Pulso()
            );
            Assert.IsNotNull(braco.Cotovelo);
            Assert.IsNotNull(braco.Pulso);
            Assert.AreEqual((int)EstadoCotovelo.EmRepouso, braco.Cotovelo.EstadoAtualContracao);
            Assert.AreEqual(0, braco.Pulso.EstadoAtualRotacao);
        }
    }
}
