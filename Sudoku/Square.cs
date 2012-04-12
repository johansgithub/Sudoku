using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    public class Square
    {
        private int number;
        bool locked;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public bool Locked
        {
            get { return locked; }
        }

    }
}
