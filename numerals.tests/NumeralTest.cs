using System;
using System.Collections.Generic;
using System.Text;

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

        // IXCMXCIX 9999
        [Test]
        public void Covert_DCCXXXIV_To_734()
        {
            var numeral = new Numeral();
            numeral.Roman = "DCCXXXIV";


            Assert.AreEqual(734, numeral.Arabic);


        }


    }
}
