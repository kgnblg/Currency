namespace Doviz
{
    public class Doviz1
    {
        decimal tutar;
        string birim;

        public Doviz1(decimal tutar, string birim)
        {
            this.Tutar = tutar;
            this.Birim1 = birim;
        }

        public string Birim1
        {
            get
            {
                return birim;
            }

            set
            {
                birim = value;
            }
        }

        public decimal Tutar
        {
            get
            {
                return tutar;
            }

            set
            {
                tutar = value;
            }
        }
    }
}
