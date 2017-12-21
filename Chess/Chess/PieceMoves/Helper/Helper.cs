using Chess.Implementation;
using System.Collections.Generic;

namespace Chess.PieceMoves
{
    public static class Helper
    {
        private static ChessBoard chess = ChessBoard.Instance;
        /// <summary>
        /// This is a new feature of c#7.0
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        public static (int currentPositionIndex, int rowIndex) GetPositionIndexAndRowIndex(string currentPosition)
        {

            var rowPosition = currentPosition.ToCharArray();
            var rowIndex = Constant.Constants.GetIndex(rowPosition[0]);

            return (currentPositionIndex: chess.BoardMap.IndexOf(chess.BoardMap.Find(value => value.Item1.Equals(currentPosition))), rowIndex);
        }

        public static List<string> GettingActualPossibleMove(List<int> inputValue)
        {
            var possibleMove = new List<string>();

            inputValue.ForEach(_item =>
            {
                if ((_item >= 0) && (_item < (Constant.Constants.Row * Constant.Constants.Col)))
                {
                    if (!chess.BoardMap[_item].Item2)
                    {
                        possibleMove.Add(chess.BoardMap[_item].Item1);
                    }
                }
            });

            return possibleMove;
        }
    }
}
