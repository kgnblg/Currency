using System.Net;
using Newtonsoft.Json.Linq;

namespace Doviz
{
    public class Json1
    {
        public static string BaglantiKur(string tur)
        {
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczovL2F1dGgucGF4aW11bS5jb20iLCJhdWQiOiJodHRwczovL2FwaS5wYXhpbXVtLmNvbSIsIm5iZiI6MTQ2ODMxMDQ5MiwiZXhwIjoxNDcyNjg4MDAwLCJzdWIiOiI0MzZiYWYwNy01ZTRmLTQyMDEtYjBlNS01Njk3NzUyZGI3NmUiLCJyb2xlIjoicGF4OmRldmVsb3BlciJ9.jnHkmkXThdVZAwzr38lgqi3ZnnXEM3fpY-XeZsQyfnw";
            string apiurl = "http://api.dev.paximum.com/v1/currency/GetExchangeRates?basecurrency=" + tur + "&access_token=" + token;
            string sonuc;

            using (var webClient = new WebClient())
            {
                sonuc = webClient.DownloadString(apiurl);
            }

            return sonuc;
        }

        public static string [] JsonParcala(string veri)
        {
            JObject gelenveri = JObject.Parse(veri);
            JArray jsondizisi = (JArray)gelenveri["currencyPairs"];
            string[] dizi = new string[jsondizisi.Count];
            int i = 0;

            foreach (var cocukdugum in jsondizisi)
            {
                string para = cocukdugum["counterCurrency"].ToString();
                string kur = cocukdugum["rate"].ToString();
                dizi[i] = para + " - " + kur;
                i++;
            }

            return dizi;
        }
    }
}
