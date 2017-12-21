using System.Collections.Generic;

namespace Chess.PieceMoves.Base.DiagonalMoves
{
    public class DiagonalMoves : IDiagonalMoves
    {
        /// <summary>
        /// Common Diagonal Move
        /// </summary>
        /// <param name="currentRowNum"></param>
        /// <param name="currentPositionIndex"></param>
        /// <returns></returns>
        public virtual List<int> DiagonalMoveUpward(int currentPositionIndex, int rowIndex)
        {
            var nextPossibleMove = new List<int>();
            var maxPossibleShifts = Constant.Constants.Row - rowIndex;

            for (var iterator = 1; iterator < maxPossibleShifts; iterator++)
            {
                nextPossibleMove.Add(currentPositionIndex + ((Constant.Constants.Col * iterator) + iterator));
            }

            return nextPossibleMove;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentPositionIndex"></param>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public virtual List<int> DiagonalMoveDownward(int currentPositionIndex, int rowIndex)
        {
            var nextPossibleMove = new List<int>();
            var maxPossibleShifts = Constant.Constants.Row - rowIndex;

            for (var iterator = 1; iterator < maxPossibleShifts; iterator++)
            {
                nextPossibleMove.Add(currentPositionIndex - ((Constant.Constants.Col * iterator) + iterator));
            }

            return nextPossibleMove;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentPositionIndex"></param>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public virtual List<int> DiagonalMoveReverseUpward(int currentPositionIndex, int rowIndex)
        {
            var nextPossibleMove = new List<int>();

            var incremental = 1;
            for (var iterator = rowIndex; iterator > 0; iterator--, incremental++)
            {
                nextPossibleMove.Add(currentPositionIndex + ((Constant.Constants.Row * incremental) - incremental));
            }

            return nextPossibleMove;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentPositionIndex"></param>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        public virtual List<int> DiagonalMoveReverseDownward(int currentPositionIndex, int rowIndex)
        {
            var nextPossibleMove = new List<int>();

            var incremental = 1;
            for (var iterator = rowIndex; iterator > 0; iterator--, incremental++)
            {
                nextPossibleMove.Add(currentPositionIndex - ((Constant.Constants.Row * incremental) - incremental));
            }

            return nextPossibleMove;
        }
    }
}
