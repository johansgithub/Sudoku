//InputUtility.cs
//2012-04-12
//Carl-Peter Holgersson  
//TDA07030
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    class InputUtility
    {
        public static bool GetDouble(string stringToConvert, out double dblOutValue, double minLimit, double maxLimit)
        {
            if(Double.TryParse(stringToConvert, out dblOutValue))
            {
                return (dblOutValue <= maxLimit && dblOutValue >= minLimit);
            }
            else
            {
                return false;
            }
        }

        public static bool GetInteger(string stringToConvert, out int intOutValue, int minLimit, int maxLimit)
        {
            if(int.TryParse(stringToConvert, out intOutValue))
            {
                return (intOutValue <= maxLimit && intOutValue >= minLimit);
            }
            else
            {
                return false;
            }
        }
    }
}
