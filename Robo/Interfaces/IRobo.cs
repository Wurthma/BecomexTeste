using System;
using System.Collections.Generic;
using System.Text;

namespace R.O.B.O.Interfaces
{
    public interface IRobo
    {
        ICabeca Cabeca { get; }
        IBraco BracoDireito { get; }
        IBraco BracoEsquerdo { get; }
    }
}
