using Chess.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.PieceMoves
{
    public class QueenMove : BasePieceMoves
    {
        /// <summary>
        /// Queen Can move any direction
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        public override List<string> Moves(string currentPosition)
        {
            var nextPossibleMove = new List<int>();
            var indexs = GetPositionIndexAndRowIndex(currentPosition);

            //Setting up horizontal and vertical direction
            nextPossibleMove.AddRange(VerticalDownMoves(indexs.currentPositionIndex));
            nextPossibleMove.AddRange(VerticalUpMoves(indexs.currentPositionIndex));
            nextPossibleMove.AddRange(HorizontalForwardMoves(indexs.currentPositionIndex, indexs.rowIndex));
            nextPossibleMove.AddRange(HorizontalReverseMoves(indexs.currentPositionIndex, indexs.rowIndex));

            //Setting up diagonal direction


            //Check if the positions are not occupied
            return GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
