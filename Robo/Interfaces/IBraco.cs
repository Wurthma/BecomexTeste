using R.O.B.O.Models;

namespace R.O.B.O.Interfaces
{
    public interface IBraco
    {
        ICotovelo Cotovelo { get; }
        IPulso Pulso { get; }
    }
}
