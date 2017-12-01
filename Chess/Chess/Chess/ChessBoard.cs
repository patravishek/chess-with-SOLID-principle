using System;
using Chess.Interface;
using Chess.Constants;
using System.Collections.Generic;

namespace Chess.Implementation
{
    public class ChessBoard : IChessBoard
    {
        private List<Tuple<string, bool>> _boardMap = new List<Tuple<string, bool>>();

        public List<Tuple<string,bool>> BoardMap
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
            var _cellName = Constant.GetRowName(Constant.Row - rowId) + Convert.ToString(colId);
            var _boardValue = Tuple.Create(_cellName, false);
            _boardMap.Add(_boardValue);
            return _cellName;
        }
    }
}