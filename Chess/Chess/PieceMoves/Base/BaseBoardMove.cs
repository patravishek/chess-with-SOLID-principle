using Chess.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.PieceMoves
{
    public abstract class BasePieceMoves
    {
        public abstract List<string> Moves(string currentPosition);

        protected ChessBoard chess = ChessBoard.Instance;

        protected List<string> GettingActualPossibleMove(List<int> inputValue)
        {
            var possibleMove = new List<string>();

            inputValue.ForEach(_item =>
            {
                if ((_item >= 0) && (_item < (Constants.Constant.Row * Constants.Constant.Col)))
                {
                    if (!chess.BoardMap[_item].Item2)
                    {
                        possibleMove.Add(chess.BoardMap[_item].Item1);
                    }
                }
            });
            
            return possibleMove;
        }

        
        /// <summary>
        /// Common Diagonal Move
        /// </summary>
        /// <param name="currentRowNum"></param>
        /// <param name="currentPositionIndex"></param>
        /// <returns></returns>
        public virtual List<int> DiagonalMoveUpward(int currentPositionIndex, int rowIndex)
        {
            var nextPossibleMove = new List<int>();
            var maxPossibleShifts = Constants.Constant.Row - rowIndex;

            for (var iterator = 1; iterator < maxPossibleShifts; iterator++)
            {
                nextPossibleMove.Add(currentPositionIndex + ((Constants.Constant.Col * iterator) + iterator));
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
            var maxPossibleShifts = Constants.Constant.Row - rowIndex;

            for (var iterator = 1; iterator < maxPossibleShifts; iterator++)
            {
                nextPossibleMove.Add(currentPositionIndex - ((Constants.Constant.Col * iterator) + iterator));
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
            for (var iterator = rowIndex; iterator > 0; iterator--,incremental++)
            {
                nextPossibleMove.Add(currentPositionIndex + ((Constants.Constant.Row * incremental) - incremental));
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
                nextPossibleMove.Add(currentPositionIndex - ((Constants.Constant.Row * incremental) - incremental));
            }

            return nextPossibleMove;
        }

        /// <summary>
        /// Common Vertical Move
        /// </summary>
        /// <param name="currentRowNum"></param>
        /// <param name="currentPositionIndex"></param>
        /// <returns></returns>
        public virtual List<int> VerticalDownMoves(int currentPositionIndex)
        {
            var nextPossibleMove = new List<int>();
            for (var iterator = (currentPositionIndex - Constants.Constant.Row); iterator >= 0; iterator -= Constants.Constant.Row)
            {
                var nextPositionIndex = iterator;
                nextPossibleMove.Add(nextPositionIndex);
            }
            return nextPossibleMove;
        }

        public virtual List<int> VerticalUpMoves(int currentPositionIndex)
        {
            var nextPossibleMove = new List<int>();
            for(var iterator = (currentPositionIndex + Constants.Constant.Row); iterator < (Constants.Constant.Row * Constants.Constant.Col); iterator += Constants.Constant.Row)
            {
                var nextPositionIndex = iterator;
                nextPossibleMove.Add(nextPositionIndex);
            }
            return nextPossibleMove;
        }

        /// <summary>
        /// Common Horizontal Move
        /// </summary>
        /// <param name="currentRowNum"></param>
        /// <param name="currentPositionIndex"></param>
        /// <returns></returns>
        public virtual List<int> HorizontalReverseMoves(int currentPositionIndex, int rowIndex)
        {
            var nextPossibleMove = new List<int>();
            
            for (var iterator = rowIndex; iterator >=1; iterator--)
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

        /// <summary>
        /// This is a new feature of c#7.0
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        public virtual (int currentPositionIndex, int rowIndex) GetPositionIndexAndRowIndex(string currentPosition)
        {
            var currentPositionIndex = chess.BoardMap.IndexOf(chess.BoardMap.Find(value => value.Item1.Equals(currentPosition)));

            var rowPosition = currentPosition.ToCharArray();
            var rowIndex = Constants.Constant.GetIndex(rowPosition[0]);

            return (currentPositionIndex, rowIndex);
        }
    }
}
