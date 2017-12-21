using Chess.PieceMoves.Base.DiagonalMoves;
using Chess.PieceMoves.Base.HorizontalMoves;
using Chess.PieceMoves.Base.VerticalMoves;
using System.Collections.Generic;

namespace Chess.PieceMoves
{
    public class QueenMove : BasePieceMoves
    {
        private IVerticalMoves verticalMoves;
        private IHorizontalMoves horizontalMoves;
        private IDiagonalMoves diagonalMoves;

        public QueenMove()
        {
            verticalMoves = new VerticalMoves();
            horizontalMoves = new HorizontalMoves();
            diagonalMoves = new DiagonalMoves();
        }
        /// <summary>
        /// Queen Can move any direction
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        public override List<string> Moves(string currentPosition)
        {
            var nextPossibleMove = new List<int>();
            var indexs = Helper.GetPositionIndexAndRowIndex(currentPosition);

            //Possible Moves
            nextPossibleMove.AddRange(verticalMoves.VerticalDownMoves(indexs.currentPositionIndex));
            nextPossibleMove.AddRange(verticalMoves.VerticalUpMoves(indexs.currentPositionIndex));
            nextPossibleMove.AddRange(horizontalMoves.HorizontalForwardMoves(indexs.currentPositionIndex, indexs.rowIndex));
            nextPossibleMove.AddRange(horizontalMoves.HorizontalReverseMoves(indexs.currentPositionIndex, indexs.rowIndex));
            nextPossibleMove.AddRange(diagonalMoves.DiagonalMoveDownward(indexs.currentPositionIndex, indexs.rowIndex));
            nextPossibleMove.AddRange(diagonalMoves.DiagonalMoveUpward(indexs.currentPositionIndex, indexs.rowIndex));
            nextPossibleMove.AddRange(diagonalMoves.DiagonalMoveReverseUpward(indexs.currentPositionIndex, indexs.rowIndex));
            nextPossibleMove.AddRange(diagonalMoves.DiagonalMoveReverseDownward(indexs.currentPositionIndex, indexs.rowIndex));

            //Check if the positions are not occupied
            return Helper.GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
