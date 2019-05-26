using R.O.B.O.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace R.O.B.O.Models
{
    public class Robo : IRobo
    {
        public Robo(ICabeca cabeca, IBraco bracoDireito, IBraco bracoEsquerdo)
        {
            Cabeca = cabeca;
            BracoDireito = bracoDireito;
            BracoEsquerdo = bracoEsquerdo;
        }

        public ICabeca Cabeca { get; private set; }
        public IBraco BracoDireito { get; private set; }
        public IBraco BracoEsquerdo { get; private set; }
    }
}
