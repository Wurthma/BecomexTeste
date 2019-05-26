namespace R.O.B.O.Util
{
    public enum Movimento
    {
        Positivo = 1,
        Negativo = -1
    }

    public enum EstadoInclinacao
    {
        EmRepouso = 0,
        ParaCima = 1,
        ParaBaixo = -1
    }

    public enum LimitesInclinacao
    {
        ValorMinimo = EstadoInclinacao.ParaBaixo,
        ValorMaximo = EstadoInclinacao.ParaCima
    }

    public enum EstadoCotovelo
    {
        EmRepouso = 0,
        LevementeContraido = 1,
        Contraido = 2,
        FortementeContraido = 3
    }

    public enum LimitesEstadoCotovelo
    {
        ValorMinimo = EstadoCotovelo.EmRepouso,
        ValorMaximo = EstadoCotovelo.FortementeContraido
    }

    public enum LimitesRotacaoCabeca
    {
        ValorMaximo = 90,
        ValorMinimo = -90
    }

    public enum LimitesRotacaoPulso
    {
        ValorMaximo = 180,
        ValorMinimo = -90
    }
}
