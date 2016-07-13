using NUnit.Framework;
using Doviz;

namespace DovizTest
{
    [TestFixture]
    public class HesapTest
    {
        string parabirimi = "USD - 2.12";

        [Test]
        public void ParabirimiBol()
        {
            string[] ayir = parabirimi.Split('-');
            string parabolunmus = ayir[0].Trim();

            string gelen = Hesap.ParabirimiBol(parabirimi);

            Assert.AreSame(parabolunmus,gelen);
        }

        [Test]
        public void KurBol()
        {
            string[] ayir = parabirimi.Split('-');
            string parabolunmus = ayir[1].Trim();

            string gelen = Hesap.ParabirimiBol(parabirimi);

            Assert.AreSame(parabolunmus, gelen);
        }
    }
}
