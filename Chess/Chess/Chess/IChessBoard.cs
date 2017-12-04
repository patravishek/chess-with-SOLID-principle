using System.Collections.Generic;

namespace Chess.Interface
{
    public interface IChessBoard
    {
        void CreateChessBoard();
        string PieceMoveInBoard(string pieceName, string cell);
    }
}