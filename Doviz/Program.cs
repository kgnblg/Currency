using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Doviz
{
    class Program
    {
        static void Main(string[] args)
        {
            Doviz dvz = new Doviz(500,"USD");

            XmlDocument Doc = XmlCek.Baglanti(dvz.Currency);
            string[] gelen = XmlCek.XmlParser(Doc);

            Hesapla hsp = new Hesapla(dvz.Tutar,gelen);
            hsp.hesaplaYaz();
            Console.ReadLine();

        }
    }
}
