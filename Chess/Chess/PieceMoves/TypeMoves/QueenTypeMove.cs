using Chess.PieceMoves.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.PieceMoves.TypeMoves
{
    public class QueenTypeMove : PositionMoves
    {
        public override List<string> MoveIndividualTypes(string currentCellPosition)
        {
            return new QueenMove().Moves(currentCellPosition);
        }
    }
}
