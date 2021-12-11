using NUnit.Framework;

namespace numerals.tests
{
    public class NumeralTest
    {
        [Test]
        public void Covert_MCMXII_To_1912()
        {
            var numeral = new Numeral();
            numeral.Roman = "MCMXII";

            Assert.AreEqual(1912, numeral.Arabic);
        }

        [Test]
        public void Covert_DCCXXXIV_To_734()
        {
            var numeral = new Numeral();
            numeral.Roman = "DCCXXXIV";

            Assert.AreEqual(734, numeral.Arabic);
        }

        [Test]
        public void Covert_CCCLXXVIII_To_378()
        {
            var numeral = new Numeral();
            numeral.Roman = "CCCLXXVIII";

            Assert.AreEqual(378, numeral.Arabic);
        }

        [Test]
        public void Covert_378_To_CCCLXXVIII()
        {
            var numeral = new Numeral();
            numeral.Arabic = 378;

            Assert.AreEqual("CCCLXXVIII", numeral.Roman);
        }

        [Test]
        public void Covert_298_To_CCXCVIII()
        {
            var numeral = new Numeral();
            numeral.Arabic = 298;

            Assert.AreEqual("CCXCVIII", numeral.Roman);
        }

    }
}
