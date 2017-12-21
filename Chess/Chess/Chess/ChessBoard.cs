using System;
using Chess.Interface;
using Chess.Constant;
using System.Collections.Generic;

namespace Chess.Implementation
{
    public sealed class ChessBoard : IChessBoard
    {
        private ChessBoard()
        {
        }
        private static readonly Lazy<ChessBoard> lazy = new Lazy<ChessBoard>(() => new ChessBoard());
        public static ChessBoard Instance
        {
            get
            {
                return lazy.Value;
            }
        }

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
            for (int col = Constant.Constants.Col; col >= 1; col--)
            {
                for(int row = Constant.Constants.Row; row >= 1; row--)
                {
                    GenerateCellName(row, col);
                }
            }
        }
        
        private string GenerateCellName(int rowId, int colId)
        {
            var _cellName = Constant.Constants.GetRowName(Constant.Constants.Row - rowId) + Convert.ToString(colId);
            var _boardValue = Tuple.Create(_cellName, false);
            _boardMap.Add(_boardValue);
            return _cellName;
        }
    }
}