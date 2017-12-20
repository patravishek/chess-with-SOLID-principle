using Chess.PieceMoves.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.PieceMoves.TypeMoves
{
    public class BishopTypeMove : PositionMoves
    {
        public override List<string> MoveIndividualTypes(string currentCellPosition)
        {
            return new BishopMove().Moves(currentCellPosition);
        }
    }
}
