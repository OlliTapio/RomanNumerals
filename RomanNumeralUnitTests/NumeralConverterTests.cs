using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;
using System;

namespace RomanNumeralUnitTests
{
    [TestClass]
    public class NumeralConverterTests
    {
        [DataTestMethod]
        [DataRow("i", 1)]
        [DataRow("ii", 2)]
        [DataRow("iv", 4)]
        [DataRow("vi", 6)]
        [DataRow("XVIII", 18)]
        [DataRow("LXXX", 80)]
        [DataRow("DCLXVI", 666)]
        [DataRow("MCMIV", 1904)]
        [DataRow("MCMX ", 1910)]
        [DataRow("MMMCMXCIX ", 3999)]
        public void ShouldConvertProperly(string numeral, int expected)
        {
            var result = NumeralConverter.ConvertRomanNumeralToInt(numeral);

            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow("iVxvX")]
        [DataRow("asdasdsa")]
        [DataRow("MDCCCCX")]
        [DataRow("MDCCCCIIII")]
        [DataRow("XVIIMXXI")]
        [DataRow("LXXJX")]
        [DataRow("LXaXJ123X")]
        public void ShouldRaiseError(string numeral)
        {
            Assert.ThrowsException<ArgumentException>(() => NumeralConverter.ConvertRomanNumeralToInt(numeral));
        }
    }
}