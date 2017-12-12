using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Chess.PieceMoves
{
    public class BishopMove : BasePieceMoves
    {
        /// <summary>
        /// Bishop Can move diagonally
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        public override List<string> Moves(string currentPosition)
        {
            var currentPositionIndex = chess.BoardMap.IndexOf(chess.BoardMap.Find(value => value.Item1.Equals(currentPosition)));
            var nextPossibleMove = new List<int>();
            var currentRowNum = Convert.ToInt32(Regex.Replace(currentPosition, "[^0-9]+", string.Empty));
            
            nextPossibleMove = DiagonalMove(currentRowNum, currentPositionIndex);
            //Check if the positions are not occupied and are valid moves
            return GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
