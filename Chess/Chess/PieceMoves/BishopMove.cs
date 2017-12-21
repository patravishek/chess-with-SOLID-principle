using System.Collections.Generic;
using Chess.PieceMoves.Base.DiagonalMoves;

namespace Chess.PieceMoves
{
    public class BishopMove : BasePieceMoves
    {
        private IDiagonalMoves diagonalMoves;

        public BishopMove()
        {
            diagonalMoves = new DiagonalMoves();
        }

        /// <summary>
        /// Bishop Can move diagonally
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        public override List<string> Moves(string currentPosition)
        {
            var nextPossibleMove = new List<int>();
            var indexs = Helper.GetPositionIndexAndRowIndex(currentPosition);

            nextPossibleMove.AddRange(diagonalMoves.DiagonalMoveUpward(indexs.currentPositionIndex, indexs.rowIndex));
            nextPossibleMove.AddRange(diagonalMoves.DiagonalMoveDownward(indexs.currentPositionIndex, indexs.rowIndex));
            nextPossibleMove.AddRange(diagonalMoves.DiagonalMoveReverseUpward(indexs.currentPositionIndex, indexs.rowIndex));
            nextPossibleMove.AddRange(diagonalMoves.DiagonalMoveReverseDownward(indexs.currentPositionIndex, indexs.rowIndex));

            //Check if the positions are not occupied and are valid moves
            return Helper.GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
