using Doviz;
using NUnit.Framework;
using System.Xml;
using System.Net;

namespace DovizTest
{
    [TestFixture]
    public class XmlTest
    {
        [Test]
        public void BaglantiKur()
        {
            XmlDocument gelen = new XmlDocument();

            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczovL2F1dGgucGF4aW11bS5jb20iLCJhdWQiOiJodHRwczovL2FwaS5wYXhpbXVtLmNvbSIsIm5iZiI6MTQ2ODMxMDQ5MiwiZXhwIjoxNDcyNjg4MDAwLCJzdWIiOiI0MzZiYWYwNy01ZTRmLTQyMDEtYjBlNS01Njk3NzUyZGI3NmUiLCJyb2xlIjoicGF4OmRldmVsb3BlciJ9.jnHkmkXThdVZAwzr38lgqi3ZnnXEM3fpY-XeZsQyfnw";
            string apiurl = "http://api.dev.paximum.com/v1/currency/GetExchangeRates?basecurrency=USD&access_token=" + token;
            string sonuc;
            XmlDocument doc = new XmlDocument();

            using (var webClient = new WebClient())
            {
                webClient.Headers.Add("Accept", "text/xml");
                sonuc = webClient.DownloadString(apiurl);
            }

            doc.LoadXml(sonuc);

            gelen = Xml.BaglantiKur("USD");

            Assert.AreEqual(doc.InnerText,gelen.InnerText);
        }

        [Test]
        public void XmlParcala()
        {
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczovL2F1dGgucGF4aW11bS5jb20iLCJhdWQiOiJodHRwczovL2FwaS5wYXhpbXVtLmNvbSIsIm5iZiI6MTQ2ODMxMDQ5MiwiZXhwIjoxNDcyNjg4MDAwLCJzdWIiOiI0MzZiYWYwNy01ZTRmLTQyMDEtYjBlNS01Njk3NzUyZGI3NmUiLCJyb2xlIjoicGF4OmRldmVsb3BlciJ9.jnHkmkXThdVZAwzr38lgqi3ZnnXEM3fpY-XeZsQyfnw";
            string apiurl = "http://api.dev.paximum.com/v1/currency/GetExchangeRates?basecurrency=USD&access_token=" + token;
            string sonuc;
            XmlDocument doc = new XmlDocument();

            using (var webClient = new WebClient())
            {
                webClient.Headers.Add("Accept", "text/xml");
                sonuc = webClient.DownloadString(apiurl);
            }

            doc.LoadXml(sonuc);

            XmlNode genelnode = doc.DocumentElement.SelectSingleNode("CurrencyPairs");
            XmlNodeList ozelnode = genelnode.SelectNodes("CurrencyPair");
            string[] sonucnode = new string[ozelnode.Count];
            string[] gelenxml = Xml.XmlParcala(doc);
            int i = 0;

            foreach (XmlNode teknode in ozelnode)
            {
                string para = teknode.SelectSingleNode("CounterCurrency").InnerText;
                string kur = teknode.SelectSingleNode("Rate").InnerText;

                sonucnode[i] = para + " - " + kur;
                i++;
            }
        
            Assert.AreEqual(sonucnode,gelenxml);
        }
    }
}
