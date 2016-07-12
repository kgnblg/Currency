using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace Doviz
{
    class XmlCek
    {
        public static XmlDocument Baglanti(string Tur)
        {
            string Token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczovL2F1dGgucGF4aW11bS5jb20iLCJhdWQiOiJodHRwczovL2FwaS5wYXhpbXVtLmNvbSIsIm5iZiI6MTQ2ODMxMDQ5MiwiZXhwIjoxNDcyNjg4MDAwLCJzdWIiOiI0MzZiYWYwNy01ZTRmLTQyMDEtYjBlNS01Njk3NzUyZGI3NmUiLCJyb2xlIjoicGF4OmRldmVsb3BlciJ9.jnHkmkXThdVZAwzr38lgqi3ZnnXEM3fpY-XeZsQyfnw";
            string ApiUrl = "http://api.dev.paximum.com/v1/currency/GetExchangeRates?basecurrency="+Tur+"&access_token="+Token;
            string sonuc;
            XmlDocument Doc = new XmlDocument();

            using (var webClient = new WebClient())
            {
                webClient.Headers.Add("Accept", "text/xml");
                sonuc = webClient.DownloadString(ApiUrl);
            }

            Doc.LoadXml(sonuc);

            return Doc;
        }

        public static string [] XmlParser(XmlDocument Doc)
        {
            XmlNode GenelNode = Doc.DocumentElement.SelectSingleNode("CurrencyPairs");
            XmlNodeList OzelNode = GenelNode.SelectNodes("CurrencyPair");
            string [] sonuc = new string[OzelNode.Count];
            int i = 0;

            foreach (XmlNode singleNode in OzelNode)
            {
                //get counter currency
                string Currency = singleNode.SelectSingleNode("CounterCurrency").InnerText;
                //get rate
                string Rate = singleNode.SelectSingleNode("Rate").InnerText;

                sonuc[i] = Currency + " - " + Rate;
                i++;
            }

            return sonuc;
        }
    }
}
