using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBasics
{
    public class Pawn : ChessPiece
    {
        public override bool IsLegalMove(int row, int column)
        {
            if (!base.IsLegalMove(row, column)) return false;

            // Do the Pawn logic here
            return true;
        }

    }
}
