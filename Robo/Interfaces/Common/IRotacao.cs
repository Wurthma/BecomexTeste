using R.O.B.O.Util;

namespace R.O.B.O.Interfaces.Common
{
    public interface IRotacao
    {
        int EstadoAtualRotacao { get; }
        bool Rotacionar(Movimento movimento, int estadoAtual);
    }
}
