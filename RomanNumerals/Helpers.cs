﻿using System;
using System.IO;
using System.Linq;

namespace RomanNumerals
{
    public static class Helpers
    {
        internal static bool IsGreater(this char x, char comparedTo)
        {
            return (x.ToInt() > comparedTo.ToInt());
        }

        internal static bool IsSmaller(this char x, char comparedTo)
        {
            return (x.ToInt() < comparedTo.ToInt());
        }

        internal static int ToInt(this char x)
        {
            return x switch
            {
                'I' => 1,
                'V' => 5,
                'X' => 10,
                'L' => 50,
                'C' => 100,
                'D' => 500,
                'M' => 1000,
                _ => throw new ArgumentException("Invalid character for int transformation"),
            };
        }

        public static bool CheckCharacterRepetionErrors(this string numeral)
        {
            if (numeral.Length < 4) return false;

            var result = numeral
                        .Where((c, i) => i >= 3 && numeral[i - 1] == c && numeral[i - 2] == c && numeral[i - 3] == c)
                        .Any();

            return result;
        }

        public static bool CheckQuintupleCharacterRepetionErrors(this string numeral)
        {
            if (numeral.Length < 2) return false;

            var quintupleCharacters = "VLD";

            var result = numeral
                        .Where((c, i) => i >= 1 && numeral[i - 1] == c && quintupleCharacters.Contains(c))
                        .Any();

            return result;
        }


        public static bool CheckAllowedCharacterErrors(this string numeral)
        {
            var allowedCharacters = "IVXLCDM";

            return numeral.Any(x => !allowedCharacters.Contains(x));
        }

        public static bool CheckCharacterOrderErrors(this string numeral)
        {
            foreach(var character in numeral.Select((value, index) => new { value, index }))
            {
                var substring = numeral.Substring(character.index);
                if (substring.Where(x => x.IsGreater(character.value)).Count() > 1)
                    return true;
            }
            return false;
        }

        public static bool CheckSubstractionErrors(this string numeral)
        {
            foreach (var character in numeral.Select((value, index) => new { value, index }))
            {
                var substring = numeral.Substring(character.index);
                var greaterChar = substring.FirstOrDefault(x => x.IsGreater(character.value));
                var indexOfGreater = substring.IndexOf(greaterChar);

                if (indexOfGreater == -1)
                    continue;

                var substractionPart = substring.Substring(0, indexOfGreater);

                if (substractionPart.Where((c, i) => i >= 1 && substractionPart[i - 1] == c).Any())
                    return true;
            }
            return false;
        }

    }
}