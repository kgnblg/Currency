using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doviz
{
    class Doviz
    {
        decimal tutar;
        string currency;

        public Doviz(decimal tutar, string currency)
        {
            this.tutar = tutar;
            this.currency = currency;
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

        public string Currency
        {
            get
            {
                return currency;
            }

            set
            {
                currency = value;
            }
        }
    }
}
