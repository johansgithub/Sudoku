using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    public class SquareManager
    {
        //int[,] går på int[row, col];
        private Square[,] squares;

        public SquareManager(int lengthOfGrid)
        {
            squares = new Square[lengthOfGrid, lengthOfGrid];
        }

        public bool IsLocked(int row, int col)
        {
            return squares[row, col].Locked;
        }
        public bool Validate(int row, int col, int number)
        {
            /*
             * validera så att:
             * 1. Siffran inte finns i samma rad.
             * 2. Siffran inte finns i samma kolumn.
             * 3. Siffran inte finns i samma lillruta. 
             * Gör det inte det, returnera true, annars false.
             */
            return false;
        }
        public void EditNumber(int row, int col, int number)
        {
            squares[row, col].Number = number;
        }
    }
}
