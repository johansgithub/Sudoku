using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    public class Controller
    {
        /// <summary>
        /// CONSTANTS
        /// </summary>
        private const int maxNumber = 4;
        private const int minNumber = 0;

        /// <summary>
        /// FIELDS
        /// </summary>
        private SquareManager m_squareManager;
        private string errorMessage;

        public Controller()
        {
            m_squareManager = new SquareManager(maxNumber);
            errorMessage = string.Empty;
        }

        public bool EditSquare(string strToConvert, int row, int col)
        {
            int number;
            if (InputUtility.GetInteger(strToConvert, out number, minNumber, maxNumber))
            {
                /*
                 * vad ska göras här?
                 * 1. kolla så att det inte är en låst siffra på den positionen
                 * 
                 * if(m_squareManager.IsLocked(row, col)
                 * {
                 *      errorMessage = "Siffran går inte att ändra."
                 *      return false;
                 * }
                 * else
                 * {
                 * 
                 * 2. validera med squaremanager så att siffran får vara där
                 * 
                 *      if(m_squareManager.Validate(row, col, number))
                 *      {
                 * 3. ändra eller skriv in siffran i square.          
                 *          m_squareManager.EditNumber(row, col, number);
                 *          return true;
                 *      }
                 *      else
                 *      {
                 *          errorMessage = "Det går inte att sätta en siffra där."
                 *          return false;
                 *      }
                 * }
                 * 
                 * 
                 * något mer?
                 * 
                 */

                return true;
            }
            else
            {
                return false;
            }
        }


        public string ErrorMessage
        {
            get { return errorMessage; }
        }

        
    }
}
