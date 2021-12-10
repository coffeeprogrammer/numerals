using System;
using System.Collections.Generic;
using System.Text;

namespace numerals
{
    public class Numeral
    {
        private string _romanRepresentation;
        private int _arabicRepresentation;

        public Numeral()
        {

        }

        public Numeral(string roman)
        {
            this.Roman = roman;
        }

        public Numeral(int arabic)
        {
            this.Arabic = arabic;
        }

        public string Roman
        {
            get
            {
                return _romanRepresentation;
            }
            set
            {
                _romanRepresentation = value;
                _arabicRepresentation = ConvertToDeciamal(value);
            }
        }

        public int Arabic
        {
            get
            {
                return _arabicRepresentation;
            }
            set
            {
                _arabicRepresentation = value;
                // TODO: write method to convert from arabic to deciamal
            }
        }


        private int ConvertToDeciamal(string roman)
        {
            int returnValue = 0;
            int[] arabicNumerals = new int[roman.Length];
            int arabicNumeralToRight = -1;

            for ( int i = 0; i < arabicNumerals.Length; i++)
            {
                arabicNumerals[i] = GetValueFromRomanDigit(roman.Substring(i, 1)[0]);
            }

            for (int i = arabicNumerals.Length - 1; i >= 0; i--)
            {
                if (arabicNumerals[i] < arabicNumeralToRight)
                {
                    returnValue = returnValue - arabicNumerals[i];
                }
                else
                {
                    returnValue = returnValue + arabicNumerals[i];
                }
                arabicNumeralToRight = arabicNumerals[i];
            }

            return returnValue;
        }

        private int GetValueFromRomanDigit(char rd)
        {
            int returnValue = -1;

            if (rd == 'M' || rd == 'm')
                returnValue = 1000;
            if (rd == 'D' || rd == 'd')
                returnValue = 500;
            if (rd == 'C' || rd == 'c')
                returnValue = 100;
            if (rd == 'L' || rd == 'l')
                returnValue = 50;
            if (rd == 'X' || rd == 'x')
                returnValue = 10;
            if (rd == 'V' || rd == 'v')
                returnValue = 5;
            if (rd == 'I' || rd == 'i')
                returnValue = 1;

            return returnValue;
        }

    }
}
