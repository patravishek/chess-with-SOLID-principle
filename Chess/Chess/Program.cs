using System;
using Chess.Implementation;
using System.Collections.Generic;

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
                if (counter % Constant.Constants.Row == 0) { Console.Write("\n"); }
                counter++;
            }

            var moveTypes = new FacadePositionMoves().positionMovesType;

            string displayText = "@@Avilable Pieces, 'King, Queen, Bishop, Horse, Rook, Pawn' @Enter a piece type to move:";
            Console.Write(displayText.Replace("@", Environment.NewLine));
            var inputString = Console.ReadLine();
            
            foreach(var item in moveTypes)
            {
                if(item.GetType().Name.ToLower().Contains(inputString.Split(" ")[0].ToLower()))
                {
                    Console.WriteLine(ConvertListToString(item.Moves(inputString.Split(" ")[1].ToUpper())));
                }
            }
            
            Console.ReadLine();
        }

        internal static string ConvertListToString(List<string> lstMoves)
        {
            string moves = string.Empty;
            lstMoves.ForEach(item =>
            {
                moves += item + ",";
            });
            return moves;
        }
    }
}
