
namespace Doviz
{
    public class Hesap
    {
        decimal tutar;
        GetExchangeRatesResponse paralistesi;

        public Hesap(decimal tutar, GetExchangeRatesResponse paralistesi)
        {
            this.tutar = tutar;
            this.paralistesi = paralistesi;
        }

        public string [] KurHesapla()
        {
            string[] sonuc = new string[paralistesi.CurrencyPairs.Length];
            for (int i = 0; i < paralistesi.CurrencyPairs.Length; i++)
            {
                string kisapara = paralistesi.CurrencyPairs[i].CounterCurrency;
                double kur = double.Parse(paralistesi.CurrencyPairs[i].Rate.ToString());

                double paradonustur = (double)tutar * kur;
                sonuc[i] = kisapara+" "+paradonustur.ToString();
            }
            return sonuc;
        }
    }
}
