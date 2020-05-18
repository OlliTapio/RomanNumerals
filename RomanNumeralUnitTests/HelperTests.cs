using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;
using System;

namespace RomanNumeralUnitTests
{
    [TestClass]
    public class HelperTests
    {
        [DataTestMethod]
        [DataRow("MDCCCCIIII")]
        [DataRow("MDCCCCX")]
        [DataRow("iiiii")]
        [DataRow("ssssss")]
        [DataRow("ssssss")]
        [DataRow("xxxassssawrasxxxx")]
        [DataRow("xxdasw2gdfghtruxxxxasfdawaxxx")]
        public void ShouldReturnTrueForCharacterRepetionError(string numeral)
        {
            var result = Helpers.CheckCharacterRepetionErrors(numeral);

            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow("MDCCCIII")]
        [DataRow("MDCCCX")]
        [DataRow("iii")]
        [DataRow("sss")]
        [DataRow("vvv")]
        [DataRow("xxxasssawrasxxx")]
        [DataRow("xxdasw2gdfghtruxxxasfdawaxxx")]
        public void ShouldReturnFalseForCharacterRepetionError(string numeral)
        {
            var result = Helpers.CheckCharacterRepetionErrors(numeral);

            Assert.IsFalse(result);
        }

        [DataTestMethod]
        [DataRow("DDasDD")]
        [DataRow("MDDX")]
        [DataRow("LL")]
        [DataRow("VVV")]
        public void ShouldReturnTrueForQuintupleCharacterRepetionError(string numeral)
        {
            var result = Helpers.CheckQuintupleCharacterRepetionErrors(numeral);

            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow("II")]
        [DataRow("MM")]
        [DataRow("MDCCCIII")]
        [DataRow("xxdasw2gdfghtruxxxasfdawaxxx")]
        [DataRow("MDCCCX")]
        public void ShouldReturnFalseForQuintupleCharacterRepetionError(string numeral)
        {
            var result = Helpers.CheckQuintupleCharacterRepetionErrors(numeral);

            Assert.IsFalse(result);
        }

        [DataTestMethod]
        [DataRow("ssssss")]
        [DataRow("ssssss")]
        [DataRow("xxxassssawrasxxxx")]
        [DataRow("xxdasw2gdfghtruxxxxasfdawaxxx")]
        [DataRow("MDCCsCCIIzII")]
        [DataRow("MDCC24CCX")]
        public void ShouldReturnTrueForAllowedCharacterError(string numeral)
        {
            var result = Helpers.CheckAllowedCharacterErrors(numeral);

            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow("DCLXVI")]
        [DataRow("MMM")]
        [DataRow("MDCCII")]
        [DataRow("MDCCCX")]
        public void ShouldReturnFalseForAllowedCharacterError(string numeral)
        {
            var result = Helpers.CheckAllowedCharacterErrors(numeral);

            Assert.IsFalse(result);
        }


        [DataTestMethod]
        [DataRow("MDCCIIIICC")]
        [DataRow("MDCCCCXXXMM")]
        public void ShouldReturnTrueForCharacterOrderError(string numeral)
        {
            var result = Helpers.CheckCharacterOrderErrors(numeral);

            Assert.IsTrue(result);
        }

        [DataTestMethod]
        [DataRow("DCLXVI")]
        [DataRow("MDCCCCX")]
        [DataRow("MMMCMXCIX")]
        public void ShouldReturnFalseForCharacterOrderError(string numeral)
        {
            var result = Helpers.CheckCharacterOrderErrors(numeral);

            Assert.IsFalse(result);
        }

        [DataTestMethod]
        [DataRow("IIX")]
        [DataRow("VVX")]
        [DataRow("MIVLLM")]
        public void ShouldReturnTrueForSubstractionError(string numeral)
        {
            var result = Helpers.CheckSubstractionErrors(numeral);

            Assert.IsTrue(result);
        }


        [DataTestMethod]
        [DataRow("DCLXVI")]
        [DataRow("MDCCCCX")]
        [DataRow("MMMCMXCIX")]
        public void ShouldReturnFalseForSubstractionError(string numeral)
        {
            var result = Helpers.CheckSubstractionErrors(numeral);

            Assert.IsFalse(result);
        }



    }
}