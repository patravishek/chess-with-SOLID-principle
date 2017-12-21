using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.PieceMoves.Base.HorizontalMoves
{
    public class HorizontalMoves : IHorizontalMoves
    {
        /// <summary>
        /// Common Horizontal Move
        /// </summary>
        /// <param name="currentRowNum"></param>
        /// <param name="currentPositionIndex"></param>
        /// <returns></returns>
        public virtual List<int> HorizontalReverseMoves(int currentPositionIndex, int rowIndex)
        {
            var nextPossibleMove = new List<int>();

            for (var iterator = rowIndex; iterator >= 1; iterator--)
            {
                if (nextPossibleMove.Count == 0)
                {
                    nextPossibleMove.Add(currentPositionIndex - 1);
                }
                else
                {
                    nextPossibleMove.Add(nextPossibleMove[nextPossibleMove.Count - 1] - 1);
                }
            }
            return nextPossibleMove;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentRowNum"></param>
        /// <param name="currentPositionIndex"></param>
        /// <returns></returns>
        public virtual List<int> HorizontalForwardMoves(int currentPositionIndex, int rowIndex)
        {
            var nextPossibleMove = new List<int>();
            for (var iterator = rowIndex; iterator < 7; iterator++)
            {
                if (nextPossibleMove.Count == 0)
                {
                    nextPossibleMove.Add(currentPositionIndex + 1);
                }
                else
                {
                    nextPossibleMove.Add(nextPossibleMove[nextPossibleMove.Count - 1] + 1);
                }
            }
            return nextPossibleMove;
        }

    }
}
