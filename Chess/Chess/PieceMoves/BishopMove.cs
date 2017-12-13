using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Chess.PieceMoves
{
    public class BishopMove : BasePieceMoves
    {
        /// <summary>
        /// Bishop Can move diagonally
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        public override List<string> Moves(string currentPosition)
        {
            var nextPossibleMove = new List<int>();
            var indexs = GetPositionIndexAndRowIndex(currentPosition);

            nextPossibleMove.AddRange(DiagonalMoveUpward(indexs.currentPositionIndex, indexs.rowIndex));
            nextPossibleMove.AddRange(DiagonalMoveDownward(indexs.currentPositionIndex, indexs.rowIndex));
            nextPossibleMove.AddRange(DiagonalMoveReverseUpward(indexs.currentPositionIndex, indexs.rowIndex));
            nextPossibleMove.AddRange(DiagonalMoveReverseDownward(indexs.currentPositionIndex, indexs.rowIndex));

            //Check if the positions are not occupied and are valid moves
            return GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
