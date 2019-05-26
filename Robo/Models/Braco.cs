using R.O.B.O.Interfaces;
using R.O.B.O.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace R.O.B.O.Models
{
    public class Braco : IBraco
    {
        public Braco(ICotovelo cotovelo, IPulso pulso)
        {
            Pulso = pulso;
            Cotovelo = cotovelo;
        }

        public ICotovelo Cotovelo { get; private set; }
        public IPulso Pulso { get; private set; }
    }
}
