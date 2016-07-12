using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doviz
{
    class Hesapla
    {
        decimal tutar;
        string[] currency;

        public Hesapla(decimal tutar, string [] currency)
        {
            this.tutar = tutar;
            this.currency = currency;
        }

        public void hesaplaYaz()
        {
            for (int i = 0; i < currency.Length; i++)
            {
                string kisaCurrency = CurrencyParser(currency[i]);
                double kur = RateParser(currency[i]);

                double para = (double)tutar * kur;
                string sonuc = kisaCurrency+" "+para.ToString();
                Console.WriteLine(sonuc);
            }
        }

        public static string CurrencyParser(string CurrencyRate)
        {
            string[] ayir = CurrencyRate.Split('-');
            string Currency = ayir[0].Trim();
            return Currency;
        }

        public static double RateParser(string CurrencyRate)
        {
            string[] ayir = CurrencyRate.Split('-');
            double kur =  double.Parse(ayir[1].Trim());
            return kur;
        }
    }
}
