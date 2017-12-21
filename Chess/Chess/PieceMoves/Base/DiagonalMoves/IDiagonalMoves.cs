using System.Collections.Generic;

namespace Chess.PieceMoves.Base.DiagonalMoves
{
    public interface IDiagonalMoves
    {
        List<int> DiagonalMoveUpward(int currentPositionIndex, int rowIndex);
        List<int> DiagonalMoveDownward(int currentPositionIndex, int rowIndex);
        List<int> DiagonalMoveReverseUpward(int currentPositionIndex, int rowIndex);
        List<int> DiagonalMoveReverseDownward(int currentPositionIndex, int rowIndex);
    }
}
