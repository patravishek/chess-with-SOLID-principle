using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.PieceMoves.Base.VerticalMoves
{
    public class VerticalMoves : IVerticalMoves
    {

        /// <summary>
        /// Common Vertical Move
        /// </summary>
        /// <param name="currentRowNum"></param>
        /// <param name="currentPositionIndex"></param>
        /// <returns></returns>
        public virtual List<int> VerticalDownMoves(int currentPositionIndex)
        {
            var nextPossibleMove = new List<int>();
            for (var iterator = (currentPositionIndex - Constant.Constants.Row); iterator >= 0; iterator -= Constant.Constants.Row)
            {
                var nextPositionIndex = iterator;
                nextPossibleMove.Add(nextPositionIndex);
            }
            return nextPossibleMove;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentPositionIndex"></param>
        /// <returns></returns>
        public virtual List<int> VerticalUpMoves(int currentPositionIndex)
        {
            var nextPossibleMove = new List<int>();
            for (var iterator = (currentPositionIndex + Constant.Constants.Row); iterator < (Constant.Constants.Row * Constant.Constants.Col); iterator += Constant.Constants.Row)
            {
                var nextPositionIndex = iterator;
                nextPossibleMove.Add(nextPositionIndex);
            }
            return nextPossibleMove;
        }
    }
}
