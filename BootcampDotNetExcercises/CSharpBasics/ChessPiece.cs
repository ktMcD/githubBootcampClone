using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class ChessPiece
    {
        public int Row { get; set; }
        public int Column { get; set; }

        // VIRTUAL gives permission to override
        public virtual bool IsLegalMove(int row, int column)
        {
            return IsOnBoard(row, column) && !IsCurrentLocation(row, column);
        }
        protected bool IsOnBoard(int row, int column)
        {
            // Using 8x8 board 
            return row >= 1 && row < 9 && column >= 1 && column < 9;
        }
        protected bool IsCurrentLocation(int row, int column)
        {
            return row == Row && column == Column;
        }

    }
}
