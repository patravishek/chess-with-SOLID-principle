using System;
using Chess.Interface;
using Chess.Constants;
using System.Collections.Generic;

namespace Chess.Implementation
{
    public class ChessBoard : IChessBoard
    {
        private List<string> _boardMap = new List<string>();

        public List<string> BoardMap
        {
            get
            {
                return _boardMap;
            }
        }

        public void CreateChessBoard()
        {
            for (int col = Constant.Col; col >= 1; col--)
            {
                for(int row = Constant.Row; row >= 1; row--)
                {
                    var rowAddress = Constant.GetRowName(Constant.Row - row) + Convert.ToString(col);
                    _boardMap.Add(rowAddress);
                    Console.Write("{0}", rowAddress);
                }
                Console.Write("\n");
            }
        }
    }
}