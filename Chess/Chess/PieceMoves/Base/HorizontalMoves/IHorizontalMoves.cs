using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.PieceMoves.Base.HorizontalMoves
{
    public interface IHorizontalMoves
    {
        List<int> HorizontalReverseMoves(int currentPositionIndex, int rowIndex);
        List<int> HorizontalForwardMoves(int currentPositionIndex, int rowIndex);
    }
}
