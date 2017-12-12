using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Chess.PieceMoves
{
    public class RookMove : BasePieceMoves
    {
        /// <summary>
        /// Rook's can move vertically and horizontally 
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        public override List<string> Moves(string currentPosition)
        {
            var nextPossibleMove = new List<int>();
            var indexs = GetPositionIndexAndRowIndex(currentPosition);

            //Predicting Positions
            nextPossibleMove.AddRange(VerticalDownMoves(indexs.currentPositionIndex));
            nextPossibleMove.AddRange(VerticalUpMoves(indexs.currentPositionIndex));
            nextPossibleMove.AddRange(HorizontalForwardMoves(indexs.currentPositionIndex, indexs.rowIndex));
            nextPossibleMove.AddRange(HorizontalReverseMoves(indexs.currentPositionIndex, indexs.rowIndex));

            //Check if the positions are not occupied and are valid moves
            return GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
