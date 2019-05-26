using R.O.B.O.Interfaces.Common;
using R.O.B.O.Util;

namespace R.O.B.O.Interfaces
{
    public interface ICabeca : IInclinacao
    {
        int EstadoAtualInclinacao { get; }
        int EstadoAtualRotacao { get; }
        bool Rotacionar(Movimento movimento, int estadoAtualInclinacaoCabeca);
    }
}
