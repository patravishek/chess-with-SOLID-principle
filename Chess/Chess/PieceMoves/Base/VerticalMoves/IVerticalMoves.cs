using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.PieceMoves.Base.VerticalMoves
{
    public interface IVerticalMoves
    {
        List<int> VerticalDownMoves(int currentPositionIndex);
        List<int> VerticalUpMoves(int currentPositionIndex);
    }
}
