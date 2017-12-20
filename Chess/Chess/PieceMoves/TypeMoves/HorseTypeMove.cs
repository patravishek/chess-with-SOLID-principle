using Chess.PieceMoves.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.PieceMoves.TypeMoves
{
    public class HorseTypeMove : PositionMoves
    {
        public override List<string> MoveIndividualTypes(string currentCellPosition)
        {
            return new HorseMove().Moves(currentCellPosition);
        }
    }
}
