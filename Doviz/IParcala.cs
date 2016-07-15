
namespace Doviz
{
    public interface IParcala
    {
        string Veri { get; set; }
        GetExchangeRatesResponse Parcala();
    }
}
