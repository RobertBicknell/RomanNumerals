using RomanNumerals;
using System;
using System.Collections.Generic;
using Xunit;

namespace RomanNumeralsTest
{
    public class Conversions
    {
        [Fact]
        public void ConvertI()
        {
            var expected = 1;
            var input = "I";
            var result = Converter.Convert(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertII()
        {
            var expected = 2;
            var input = "II";
            var result = Converter.Convert(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertV()
        {
            var expected = 5;
            var input = "V";
            var result = Converter.Convert(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertIV()
        {
            var expected = 4;
            var input = "IV";
            var result = Converter.Convert(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertXIV()
        {
            var expected = 14;
            var input = "XIV";
            var result = Converter.Convert(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertXC()
        {
            var expected = 90;
            var input = "XC";
            var result = Converter.Convert(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertXL()
        {
            var expected = 40;
            var input = "XL";
            var result = Converter.Convert(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertMCMLXXXIII()
        {
            var expected = 1983;
            var input = "MCMLXXXIII";
            var result = Converter.Convert(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertMDCCXLIX()
        {
            var expected = 1749;
            var input = "MDCCXLIX";
            var result = Converter.Convert(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertCMLXXXIII()
        {
            var expected = 983;
            var input = "CMLXXXIII";
            var result = Converter.Convert(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertCDLXXVII()
        {
            var expected = 477;
            var input = "CDLXXVII";
            var result = Converter.Convert(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void ConvertCDXLVII()
        {
            var expected = 447;
            var input = "CDXLVII";
            var result = Converter.Convert(input);
            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestAllNumberPartsLessThan2001() {
            var testCases = new Dictionary<int, string>();

            //scraped from https://www.cuemath.com/numbers/roman-numerals-1-to-2000/

            testCases.Add(1, "I");
            testCases.Add(2, "II");
            testCases.Add(3, "III");
            testCases.Add(4, "IV");
            testCases.Add(5, "V");
            testCases.Add(6, "VI");
            testCases.Add(7, "VII");
            testCases.Add(8, "VIII");
            testCases.Add(9, "IX");
            testCases.Add(10, "X");
            testCases.Add(11, "XI");
            testCases.Add(12, "XII");
            testCases.Add(13, "XIII");
            testCases.Add(14, "XIV");
            testCases.Add(15, "XV");
            testCases.Add(16, "XVI");
            testCases.Add(17, "XVII");
            testCases.Add(18, "XVIII");
            testCases.Add(19, "XIX");
            testCases.Add(20, "XX");
            testCases.Add(36, "XXXVI");
            testCases.Add(37, "XXXVII");
            testCases.Add(38, "XXXVIII");
            testCases.Add(39, "XXXIX");
            testCases.Add(40, "XL");
            testCases.Add(51, "LI");
            testCases.Add(52, "LII");
            testCases.Add(53, "LIII");
            testCases.Add(54, "LIV");
            testCases.Add(55, "LV");
            testCases.Add(56, "LVI");
            testCases.Add(57, "LVII");
            testCases.Add(58, "LVIII");
            testCases.Add(59, "LIX");
            testCases.Add(60, "LX");
            testCases.Add(66, "LXVI");
            testCases.Add(67, "LXVII");
            testCases.Add(68, "LXVIII");
            testCases.Add(69, "LXIX");
            testCases.Add(70, "LXX");
            testCases.Add(81, "LXXXI");
            testCases.Add(82, "LXXXII");
            testCases.Add(83, "LXXXIII");
            testCases.Add(84, "LXXXIV");
            testCases.Add(85, "LXXXV");
            testCases.Add(86, "LXXXVI");
            testCases.Add(87, "LXXXVII");
            testCases.Add(88, "LXXXVIII");
            testCases.Add(89, "LXXXIX");
            testCases.Add(90, "XC");
            testCases.Add(91, "XCI");
            testCases.Add(92, "XCII");
            testCases.Add(93, "XCIII");
            testCases.Add(94, "XCIV");
            testCases.Add(95, "XCV");
            testCases.Add(96, "XCVI");
            testCases.Add(97, "XCVII");
            testCases.Add(98, "XCVIII");
            testCases.Add(99, "XCIX");
            testCases.Add(100, "C");
            testCases.Add(150, "CL");
            testCases.Add(200, "CC");
            testCases.Add(250, "CCL");
            testCases.Add(300, "CCC");
            testCases.Add(350, "CCCL");
            testCases.Add(400, "CD");
            testCases.Add(450, "CDL");
            testCases.Add(500, "D");
            testCases.Add(550, "DL");
            testCases.Add(600, "DC");
            testCases.Add(650, "DCL");
            testCases.Add(700, "DCC");
            testCases.Add(750, "DCCL");
            testCases.Add(800, "DCCC");
            testCases.Add(850, "DCCCL");
            testCases.Add(900, "CM");
            testCases.Add(950, "CML");
            testCases.Add(1000, "M");
            testCases.Add(1050, "ML");
            testCases.Add(1100, "MC");
            testCases.Add(1150, "MCL");
            testCases.Add(1200, "MCC");
            testCases.Add(1250, "MCCL");
            testCases.Add(1300, "MCCC");
            testCases.Add(1350, "MCCCL");
            testCases.Add(1400, "MCD");
            testCases.Add(1450, "MCDL");
            testCases.Add(1500, "MD");
            testCases.Add(1550, "MDL");
            testCases.Add(1600, "MDC");
            testCases.Add(1650, "MDCL");
            testCases.Add(1700, "MDCC");
            testCases.Add(1750, "MDCCL");
            testCases.Add(1800, "MDCCC");
            testCases.Add(2000, "MM");

            foreach (var key in testCases.Keys)
            {
                var expected = key;
                var input = testCases[key];
                var result = Converter.Convert(input);
                Assert.Equal(expected, result);
            }

        }
    }
}
