using System.Linq;

namespace RomanNumerals
{
    public class NumeralConverter
    {
        public static int ConvertRomanNumeralToInt(string numeral)
        {
            numeral = Validator.ValidateNumeral(numeral);

            var result = 0;

            foreach (var character in numeral.Select((value, index) => new { value, index }))
            {
                var substring = numeral.Substring(character.index);

                if (substring.Any(x => x.IsGreater(character.value)))
                {
                    result -= character.value.ToInt();
                }
                else
                {
                    result += character.value.ToInt();
                }
            }

            return result;
        }
    }
}