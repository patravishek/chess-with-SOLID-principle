using System;
using Chess.Implementation;
using Chess.Constants;

namespace Chess
{
    class Program
    {
        static void Main(string[] args)
        {
            var chess = ChessBoard.Instance;
            chess.CreateChessBoard();
            var counter = 1;

            foreach(var item in chess.BoardMap)
            {
                Console.Write("{0}", item.Item1);
                if (counter % Constant.Row == 0) { Console.Write("\n"); }
                counter++;
            }

            string displayText = "@@Avilable Pieces, 'King, Queen, Bishop, Horse, Rook, Pawn' @Enter a piece type to move:";
            Console.Write(displayText.Replace("@",System.Environment.NewLine));
            var inputString = Console.ReadLine();
        }
    }
}
