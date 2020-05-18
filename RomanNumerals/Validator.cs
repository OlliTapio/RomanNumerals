using System;
using System.Collections.Generic;
using System.Text;

namespace RomanNumerals
{
    class Validator
    {
        internal static string ValidateNumeral(string numeral)
        {
            numeral = numeral.Trim().ToUpper();

            if (numeral.CheckAllowedCharacterErrors())
                throw new ArgumentException("Not roman numeral. Invalid characters in the input.");

            if (numeral.CheckCharacterRepetionErrors())
                throw new ArgumentException("Not roman numeral. Invalid character repetition.");

            if(numeral.CheckCharacterOrderErrors())
                throw new ArgumentException("Not roman numeral. Invalid character order.");

            return numeral;
        }
    }
}
