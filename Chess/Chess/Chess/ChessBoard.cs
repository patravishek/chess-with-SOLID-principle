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
                    Console.Write("{0}", GenerateCellName(row,col));
                }
                Console.Write("\n");
            }
        }

        private string GenerateCellName(int rowId, int colId)
        {
            var cellName = Constant.GetRowName(Constant.Row - rowId) + Convert.ToString(colId);
            _boardMap.Add(cellName);
            return cellName;
        }
    }
}