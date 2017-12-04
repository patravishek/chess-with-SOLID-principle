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
                if (_item > 0)
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
        /// This method is not implemented, this can be implemented in case user selects a paritcular piece and wants to move its position
        /// </summary>
        /// <param name="pieceName"></param>
        /// <param name="cell"></param>
        /// <returns></returns>
        protected bool UpdateMove(string pieceName, string cell)
        {
            throw new NotImplementedException();
        }
    }
}
