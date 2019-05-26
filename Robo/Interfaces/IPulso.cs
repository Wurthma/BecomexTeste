using R.O.B.O.Interfaces.Common;
using R.O.B.O.Util;

namespace R.O.B.O.Interfaces
{
    public interface IPulso : IRotacao
    {
        bool Rotacionar(Movimento movimento, int estadoAtualContracaoCotovelo);
    }
}
