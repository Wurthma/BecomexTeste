using R.O.B.O.Interfaces;
using R.O.B.O.Util;
using System;
using System.Collections.Generic;
using System.Text;

namespace R.O.B.O.Models
{
    public class Pulso : Rotacao, IPulso
    {
        public Pulso()
        {
            SetarLimitesRotacao((int)LimitesRotacaoPulso.ValorMaximo, (int)LimitesRotacaoPulso.ValorMinimo);
        }

        public override bool Rotacionar(Movimento movimento, int estadoAtualContracaoCotovelo)
        {
            if(estadoAtualContracaoCotovelo != (int)EstadoCotovelo.FortementeContraido)
            {
                return false;
            }
            return base.Rotacionar(movimento, estadoAtualContracaoCotovelo);
        }
    }
}
