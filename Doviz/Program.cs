using System;
using System.Xml;

namespace Doviz
{
    class Program
    {
        static void Main(string[] args)
        {
            Doviz1 doviz = new Doviz1(500, "USD");

            string jsoncikti = Json1.BaglantiKur("USD");
            string [] gelen = Json1.JsonParcala(jsoncikti);

            //XmlDocument doc = Xml.BaglantiKur(doviz.Birim1);
            //string[] gelen = Xml.XmlParcala(doc);

            Hesap hesap = new Hesap(doviz.Tutar,gelen);
            hesap.Hesapla();
            Console.ReadLine();

        }
    }
}
