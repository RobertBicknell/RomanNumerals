using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public static class Converter //note, this class does not validate that a given string is correctly formed, but intends to evaluate correctly formed strings 
    {
        static readonly ImmutableDictionary<char, int> charToValueDict = new Dictionary<char, int>() { 
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {'M', 1000 }
        }.ToImmutableDictionary<char, int>();

        ///<remarks>
        ///Converts valid Roman Numerals into Arabic Numeral equivalents.
        ///Roman Numeral input should be in upper case. 
        ///</remarks>
        public static int Convert(string input) { 
            var last = 0;
            var answer = 0;
            foreach (var character in input.Reverse())
            {
                var value = charToValueDict[character];
                if (value >= last)
                {
                    answer += value;
                }
                else if ("IXC".Contains(character)) answer -= value;//Validation:
                                                                    // if the code were a validator rather than an evaluator, we could detect here any invalid subtraction prefix in an else{} clause.
                                                                    // however, there's no clear use-case for that information unless implementing all necessary validator logic -
                                                                    // for example: "MCM" is valid, but "CMM" is not, but both would parse fine here, to 1900 
                                                                    // to support this kind of checking, one cannot merely check the first char for validity, as in "CMM"
                                                                    // for example: although beyond 2000, "MCMM" and "MMCM" are examples that show one must to do more work to validate the positioning of subtraction prefixes.
                                                                    // for this reason, the code will parse some INVALID Roman Numerals without error, as noted in the method <summary>, for excample "MCCCCCC" -> 1600 which is properly "MDC"
                                                                    //
                                                                    // n.b. 'M' would itself also be a valid subtraction prefix if the Roman system had futher denominations beyond M - but it doesn't : )
                                                                    //
                                                                    // Complexity - probably a non-issue given the tiny data, but for completeness :
                                                                    //     the character lookup is O(1) and cannot be improved
                                                                    //     the .Contains is not a hash-lookup and O(n), but.. it only has to check 3 chars : )
                last = value;
            }
            return answer;
        }
    }
}
