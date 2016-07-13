using System.Net;
using System.Xml;

namespace Doviz
{
    public class Xml
    {
        public static XmlDocument BaglantiKur(string tur)
        {
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczovL2F1dGgucGF4aW11bS5jb20iLCJhdWQiOiJodHRwczovL2FwaS5wYXhpbXVtLmNvbSIsIm5iZiI6MTQ2ODMxMDQ5MiwiZXhwIjoxNDcyNjg4MDAwLCJzdWIiOiI0MzZiYWYwNy01ZTRmLTQyMDEtYjBlNS01Njk3NzUyZGI3NmUiLCJyb2xlIjoicGF4OmRldmVsb3BlciJ9.jnHkmkXThdVZAwzr38lgqi3ZnnXEM3fpY-XeZsQyfnw";
            string apiurl = "http://api.dev.paximum.com/v1/currency/GetExchangeRates?basecurrency="+tur+"&access_token="+token;
            string sonuc;
            XmlDocument doc = new XmlDocument();

            using (var webClient = new WebClient())
            {
                webClient.Headers.Add("Accept", "text/xml");
                sonuc = webClient.DownloadString(apiurl);
            }

            doc.LoadXml(sonuc);

            return doc;
        }

        public static string [] XmlParcala(XmlDocument doc)
        {
            XmlNode genelnode = doc.DocumentElement.SelectSingleNode("CurrencyPairs");
            XmlNodeList ozelnode = genelnode.SelectNodes("CurrencyPair");
            string [] sonuc = new string[ozelnode.Count];
            int i = 0;

            foreach (XmlNode teknode in ozelnode)
            {
                string para = teknode.SelectSingleNode("CounterCurrency").InnerText;
                string kur = teknode.SelectSingleNode("Rate").InnerText;

                sonuc[i] = para + " - " + kur;
                i++;
            }

            return sonuc;
        }
    }
}
