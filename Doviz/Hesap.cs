using System;

namespace Doviz
{
    public class Hesap
    {
        decimal tutar;
        string[] para;

        public Hesap(decimal tutar, string [] para)
        {
            this.tutar = tutar;
            this.para = para;
        }

        public void HesaplaYaz()
        {
            for (int i = 0; i < para.Length; i++)
            {
                string kisapara = ParabirimiBol(para[i]);
                double kur = KurBol(para[i]);

                double paradonustur = (double)tutar * kur;
                string sonuc = kisapara+" "+paradonustur.ToString();
                Console.WriteLine(sonuc);
            }
        }

        public static string ParabirimiBol(string parabirimi)
        {
            string[] ayir = parabirimi.Split('-');
            string parabolunmus = ayir[0].Trim();
            return parabolunmus;
        }

        public static double KurBol(string parabirimi)
        {
            string[] ayir = parabirimi.Split('-');
            double kur =  double.Parse(ayir[1].Trim());
            return kur;
        }
    }
}
