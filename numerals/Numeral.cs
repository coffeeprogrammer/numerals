using System;
using System.Collections.Generic;
using System.Text;

namespace numerals
{
    public class Numeral
    {
        private string _romanRepresentation;
        private int _deciamalRepresentation;

        public Numeral()
        {

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
            }
        }


        private int ConvertToDeciamal(string roman)
        {

            int returnValue = 0;
            int length = roman.Length;


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
