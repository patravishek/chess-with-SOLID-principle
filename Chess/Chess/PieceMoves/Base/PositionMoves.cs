using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.PieceMoves.Base
{
    public abstract class PositionMoves
    {
        public abstract List<string> MoveIndividualTypes(string currentCellPosition);
    }
}
