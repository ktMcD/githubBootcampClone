using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class King : ChessPiece
    {
        // OVERRIDE is used to override the VIRTUAL method
       public override bool IsLegalMove(int row, int column)
        {
            if(base.IsLegalMove(row,column) == false)
            {
                return false;
            }

            // A king can only move one column or row
            if (Math.Abs(row - Row) > 1) return false;
            if (Math.Abs(column - Column) > 1) return false;

            return true;


        }

    }
}
