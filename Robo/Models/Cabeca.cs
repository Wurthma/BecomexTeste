using R.O.B.O.Interfaces;
using R.O.B.O.Util;

namespace R.O.B.O.Models
{
    public class Cabeca : Rotacao, ICabeca
    {
        private int _estadoAtualInclinacao { get; set; }
        public int EstadoAtualInclinacao { get { return _estadoAtualInclinacao; } }

        public Cabeca()
        {
            _estadoAtualInclinacao = (int)EstadoInclinacao.EmRepouso;
            SetarLimitesRotacao((int)LimitesRotacaoCabeca.ValorMaximo, (int)LimitesRotacaoCabeca.ValorMinimo);
        }

        public bool InclinarParaCima()
        {
            bool alcancouLimite = VerificarLimiteInclinacao(_estadoAtualInclinacao, Movimento.Positivo);

            if (!alcancouLimite) { _estadoAtualInclinacao++; }

            return !alcancouLimite;
        }

        public bool InclinarParaBaixo()
        {
            bool alcancouLimite = VerificarLimiteInclinacao(_estadoAtualInclinacao, Movimento.Negativo);

            if (!alcancouLimite) { _estadoAtualInclinacao--; }

            return !alcancouLimite;
        }

        private bool VerificarLimiteInclinacao(int estadoAtualInclinacao, Movimento movimento)
        {
            switch (movimento)
            {
                case Movimento.Positivo:
                    return _estadoAtualInclinacao == (int)LimitesInclinacao.ValorMaximo;
                case Movimento.Negativo:
                    return estadoAtualInclinacao == (int)LimitesInclinacao.ValorMinimo;
                default:
                    return false;
            }
             
        }

        public override bool Rotacionar(Movimento movimento, int estadoAtualInclinacaoCabeca)
        {
            if (estadoAtualInclinacaoCabeca == (int)EstadoInclinacao.ParaBaixo)
            {
                return false;
            }
            return base.Rotacionar(movimento, estadoAtualInclinacaoCabeca);
        }
    }
}
