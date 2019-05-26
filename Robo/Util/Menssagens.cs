using System;
using System.Collections.Generic;
using System.Text;

namespace R.O.B.O.Util
{
    public static class Menssagens
    {
        public const string Sucesso = "Sucesso";

        public const string LimiteContracao = "Limite de contração atingido";

        public const string LimiteInclinacao = "Limite de inclinação atingido";

        public const string NaoFoiPossivelRotacionar = "Não foi possível rotacionar";

        public const string EmRepouso = "Em repouso";

        public const string ParaBaixo = "Para baixo";

        public const string ParaCima = "Para cima";

        public const string Contraido = "Contraído";

        public const string LevementeContraido = "Levemente contraído";

        public const string FortementeContraido = "Fortemente contraído";

        public const string Indenfinido = "Indefinido";

        public static string GerarTextoRotacao(int rotacaoAtual)
        {
            if(rotacaoAtual == 0)
            {
                return EmRepouso;
            }
            return $"{rotacaoAtual}º";
        }
    }
}
