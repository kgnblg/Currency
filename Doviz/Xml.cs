using System.IO;
using System.Xml.Serialization;

namespace Doviz
{
    public class Xml: IParcala
    {
        string veri;

        public string Veri { get; set; }

        public Xml(string veri)
        {
            this.veri = veri;
        }

        public GetExchangeRatesResponse Parcala()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(GetExchangeRatesResponse));
            return (GetExchangeRatesResponse)serializer.Deserialize(new StringReader(veri));
        }
    }
}
