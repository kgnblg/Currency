namespace Doviz
{
    public class Doviz
    {
        public decimal tutar { get; set; }
        public string birim { get; set; }

        public Doviz(decimal tutar, string birim)
        {
            this.tutar = tutar;
            this.birim = birim;
        }
    }
}
