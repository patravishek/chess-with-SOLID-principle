using Chess.Constants;
using System;
using System.Collections.Generic;

namespace Chess.PieceMoves
{
    public class KingMove : BasePieceMoves
    {
        /// <summary>
        /// King can move various direction
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        public override List<string> Moves(string currentPosition)
        {
            var currentPositionIndex = chess.BoardMap.IndexOf(chess.BoardMap.Find(value => value.Item1.Equals(currentPosition)));
            var nextPossibleMove = new List<string>
            {
                Convert.ToString(currentPositionIndex + 1),//E5
                Convert.ToString(currentPositionIndex - 1),//C5
                Convert.ToString(currentPositionIndex + Constant.Row),//D4
                Convert.ToString(currentPositionIndex + (Constant.Row + 1)),//E4
                Convert.ToString(currentPositionIndex + (Constant.Row - 1)),//C4
                Convert.ToString(currentPositionIndex - Constant.Row),//D6
                Convert.ToString(currentPositionIndex - (Constant.Row + 1)),//C6
                Convert.ToString(currentPositionIndex - (Constant.Row - 1))//E6
            };

            //Check if the positions are not occupied
            return GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
