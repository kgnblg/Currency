using Newtonsoft.Json;

namespace Doviz
{
    public class Json: IParcala
    {
        string veri;
        public string Veri { get; set; }

        public Json(string veri)
        {
            this.veri = veri;
        }

        public GetExchangeRatesResponse Parcala()
        {
            return (GetExchangeRatesResponse)JsonConvert.DeserializeObject(veri, typeof(GetExchangeRatesResponse));
        }
    }
}
