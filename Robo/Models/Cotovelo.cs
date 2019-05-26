using R.O.B.O.Interfaces;
using R.O.B.O.Util;

namespace R.O.B.O.Models
{
    public class Cotovelo : ICotovelo
    {
        public Cotovelo()
        {
            _estadoAtualContracao = (int)EstadoCotovelo.EmRepouso;
        }

        private int _estadoAtualContracao { get; set; }
        public int EstadoAtualContracao { get { return _estadoAtualContracao; } }

        public bool Contrair()
        {
            bool alcancouLimite = VerificarLimiteContracao(_estadoAtualContracao, Movimento.Positivo);

            if (!alcancouLimite) { _estadoAtualContracao++; }

            return !alcancouLimite;
        }

        public bool Descontrair()
        {
            bool alcancouLimite = VerificarLimiteContracao(_estadoAtualContracao, Movimento.Negativo);

            if (!alcancouLimite) { _estadoAtualContracao--; }

            return !alcancouLimite;
        }

        private bool VerificarLimiteContracao(int estadoAtualContracao, Movimento movimento)
        {
            switch (movimento)
            {
                case Movimento.Positivo:
                    return estadoAtualContracao == (int)LimitesEstadoCotovelo.ValorMaximo;
                case Movimento.Negativo:
                    return estadoAtualContracao == (int)LimitesEstadoCotovelo.ValorMinimo;
                default:
                    return false;
            }
        }
            
    }
}
