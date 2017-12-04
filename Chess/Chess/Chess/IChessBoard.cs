using System.Collections.Generic;

namespace Chess.Interface
{
    public interface IChessBoard
    {
        void CreateChessBoard();
        List<string> PieceMoveInBoard(string pieceName);
    }
}