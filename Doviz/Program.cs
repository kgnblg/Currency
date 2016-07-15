using System;

namespace Doviz
{
    class Program
    {
        static void Main(string[] args)
        {
            Doviz doviz = new Doviz(500, "USD");
            Veri veri = new Veri(doviz.birim, "application/json"); //text/xml
            //Xml xml = new Xml(veri.VeriCek());
            Json jsn = new Json(veri.VeriCek());
            GetExchangeRatesResponse gelenveri = jsn.Parcala(); // Xml.Parcala();
            Hesap hesap = new Hesap(doviz.tutar, gelenveri);
            Cikti.EkranaYaz(hesap.KurHesapla());
            Console.ReadLine();
        }
    }
}
