using Microsoft.VisualStudio.TestTools.UnitTesting;
using R.O.B.O.Interfaces;
using R.O.B.O.Models;

namespace RoboUnitTest
{
    [TestClass]
    public class RoboTestes
    {
        [TestMethod]
        public void Robo_PropriedadesNaoNulas_NaoNulosComEstados()
        {
            var robo = new Robo(
                new Cabeca(), 
                new Braco(new Cotovelo(), new Pulso()), 
                new Braco(new Cotovelo(), new Pulso())
            );
            Assert.IsNotNull(robo);
            Assert.IsNotNull(robo.Cabeca);
            Assert.IsNotNull(robo.BracoDireito);
            Assert.IsNotNull(robo.BracoDireito.Cotovelo);
            Assert.IsNotNull(robo.BracoDireito.Pulso);
            Assert.IsNotNull(robo.BracoEsquerdo);
            Assert.IsNotNull(robo.BracoEsquerdo.Cotovelo);
            Assert.IsNotNull(robo.BracoEsquerdo.Pulso);
        }
    }
}
