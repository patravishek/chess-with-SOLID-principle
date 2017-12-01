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
            Console.Write(_chessObj.BoardMap.Find(value => value.Item1.Equals("A2")).Item1);
            Console.ReadLine();
        }
    }
}
