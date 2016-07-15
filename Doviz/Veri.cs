using System.Net;

namespace Doviz
{
    class Veri
    {
        string tur, donusturu;
        public string Tur { get; set; }
        public string Donusturu { get; set; }

        public Veri(string tur, string donusturu)
        {
            this.tur = tur;
            this.donusturu = donusturu;
        }

        public string VeriCek()
        {
            string token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJpc3MiOiJodHRwczovL2F1dGgucGF4aW11bS5jb20iLCJhdWQiOiJodHRwczovL2FwaS5wYXhpbXVtLmNvbSIsIm5iZiI6MTQ2ODMxMDQ5MiwiZXhwIjoxNDcyNjg4MDAwLCJzdWIiOiI0MzZiYWYwNy01ZTRmLTQyMDEtYjBlNS01Njk3NzUyZGI3NmUiLCJyb2xlIjoicGF4OmRldmVsb3BlciJ9.jnHkmkXThdVZAwzr38lgqi3ZnnXEM3fpY-XeZsQyfnw";
            string apiurl = "http://api.dev.paximum.com/v1/currency/GetExchangeRates?basecurrency=" + tur + "&access_token=" + token;
            string sonuc;

            using (var webClient = new WebClient())
            {
                webClient.Headers.Add("Accept", donusturu);
                sonuc = webClient.DownloadString(apiurl);
            }

            return sonuc;
        }
    }
}
