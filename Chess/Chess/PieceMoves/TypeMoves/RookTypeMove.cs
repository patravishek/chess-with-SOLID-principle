using Chess.PieceMoves.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.PieceMoves.TypeMoves
{
    public class RookTypeMove : PositionMoves
    {
        public override List<string> MoveIndividualTypes(string currentCellPosition)
        {
            return new RookMove().Moves(currentCellPosition);
        }
    }
}
