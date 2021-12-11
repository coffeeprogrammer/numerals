using System.Text;

namespace numerals
{
    public class Numeral
    {
        private string _romanRepresentation;
        private int _arabicRepresentation;

        public Numeral(){ }

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
                _arabicRepresentation = ConvertToArabic(value);
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
                _romanRepresentation = ConvertToRoman(value);
            }
        }

        private int ConvertToArabic(string roman)
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

        private string ConvertToRoman(int arabicNumber)
        {

            StringBuilder roman = new StringBuilder();
            bool done = false;

            if (arabicNumber >= 1000 && !done)
            {
                roman.Append("M" + ConvertToRoman(arabicNumber - 1000));
                done = true;
            }
                
            if (arabicNumber >= 900 && !done)
            {
                roman.Append("CM" + ConvertToRoman(arabicNumber - 900));
                done = true;
            }
                
            if (arabicNumber >= 500 && !done)
            {
                roman.Append("D" + ConvertToRoman(arabicNumber - 500));
                done = true;
            }
                
            if (arabicNumber >= 400 && !done)
            {
                roman.Append("CD" + ConvertToRoman(arabicNumber - 400));
                done = true;
            }
                
            if (arabicNumber >= 100 && !done)
            {
                roman.Append("C" + ConvertToRoman(arabicNumber - 100));
                done = true;
            }
                
            if (arabicNumber >= 90 && !done)
            {
                roman.Append("XC" + ConvertToRoman(arabicNumber - 90));
                done = true;
            }
                
            if (arabicNumber >= 50 && !done)
            {
                roman.Append("L" + ConvertToRoman(arabicNumber - 50));
                done = true;
            }
                
            if (arabicNumber >= 40 && !done)
            {
                roman.Append("XL" + ConvertToRoman(arabicNumber - 40));
                done = true;
            }
                
            if (arabicNumber >= 10 && !done)
            {
                roman.Append("X" + ConvertToRoman(arabicNumber - 10));
                done = true;
            }
                
            if (arabicNumber >= 9 && !done)
            {
                roman.Append("IX" + ConvertToRoman(arabicNumber - 9));
                done = true;
            }
                
            if (arabicNumber >= 5 && !done)
            {
                roman.Append("V" + ConvertToRoman(arabicNumber - 5));
                done = true;
            }
                
            if (arabicNumber >= 4 && !done)
            {
                roman.Append("IV" + ConvertToRoman(arabicNumber - 4));
                done = true;
            }
                
            if (arabicNumber >= 1 && !done)
            {
                roman.Append("I" + ConvertToRoman(arabicNumber - 1));
                done = true;
            }
                
            return roman.ToString();
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
