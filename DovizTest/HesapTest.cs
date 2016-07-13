using NUnit.Framework;
using Doviz;

namespace DovizTest
{
    [TestFixture]
    public class HesapTest
    {
        string parabirimi = "USD - 212";

        [Test]
        public void ParabirimiBol()
        {
            string[] ayir = parabirimi.Split('-');
            string parabolunmus = ayir[0].Trim();

            string gelen = Hesap.ParabirimiBol(parabirimi);

            Assert.AreEqual(parabolunmus,gelen);
        }

        [Test]
        public void KurBol()
        {
            string[] ayir = parabirimi.Split('-');
            string parabolunmus = ayir[1].Trim();

            string gelen = Hesap.KurBol(parabirimi).ToString();

            Assert.AreEqual(parabolunmus, gelen);
        }
    }
}
