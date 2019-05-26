using R.O.B.O.Interfaces.Common;
using R.O.B.O.Util;

namespace R.O.B.O.Models
{
    public class Rotacao : IRotacao
    {
        public Rotacao()
        {
            _estadoAtualRotacao = 0;
        }

        private int _estadoAtualRotacao { get; set; }
        private int _limiteMaximoRotacao { get; set; }
        private int _limiteMinimoRotacao { get; set; }

        public int EstadoAtualRotacao { get { return _estadoAtualRotacao; } }

        public virtual bool Rotacionar(Movimento movimento, int estadoAtual)
        {
            bool alcancouLimite = VerificarLimiteRotacao(_estadoAtualRotacao, movimento);
            if (alcancouLimite) { return false; }

            switch (movimento)
            {
                case Movimento.Positivo:
                    _estadoAtualRotacao += 45;
                    break;
                case Movimento.Negativo:
                    _estadoAtualRotacao -= 45;
                    break;
            }
            return !alcancouLimite;
        }

        private bool VerificarLimiteRotacao(int estadoAtualRotacao, Movimento movimento)
        {
            switch (movimento)
            {
                case Movimento.Positivo:
                    return estadoAtualRotacao == _limiteMaximoRotacao;
                case Movimento.Negativo:
                    return estadoAtualRotacao == _limiteMinimoRotacao;
                default:
                    return false;
            }
        }

        protected void SetarLimitesRotacao(int maximo, int minimo)
        {
            _limiteMaximoRotacao = maximo;
            _limiteMinimoRotacao = minimo;
        }
    }
}
