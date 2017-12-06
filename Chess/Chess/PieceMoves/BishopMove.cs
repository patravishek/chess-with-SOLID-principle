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
            
            for (var iterator = currentRowNum; iterator >= 1; iterator--)
            {
                var nextRightPositionIndex = currentPositionIndex + ((Constants.Constant.Row * iterator) + iterator);
                var nextLeftPositionIndex = currentPositionIndex + ((Constants.Constant.Row * iterator) - iterator);
                
                nextPossibleMove.Add(nextRightPositionIndex);
                nextPossibleMove.Add(nextLeftPositionIndex);

                var nextDownwardRightPositionIndex = currentPositionIndex - ((Constants.Constant.Row * iterator) + iterator);
                var nextDownwardLeftPositionIndex = currentPositionIndex - ((Constants.Constant.Row * iterator) - iterator);

                nextPossibleMove.Add(nextDownwardRightPositionIndex);
                nextPossibleMove.Add(nextDownwardLeftPositionIndex);

            }
            
            //Check if the positions are not occupied and are valid moves
            return GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
