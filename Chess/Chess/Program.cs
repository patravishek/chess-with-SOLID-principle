using System;
using Chess.Implementation;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            var _chessObj = new ChessBoard();
            _chessObj.CreateChessBoard();
            Console.Write(_chessObj.BoardMap.Find(val=>val.Equals("A2")));
            Console.ReadLine();
        }
    }
}
