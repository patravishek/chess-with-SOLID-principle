using Chess.Constants;
using System;
using System.Collections.Generic;

namespace Chess.PieceMoves
{
    public class PawnMove : BasePieceMoves
    {
        /// <summary>
        /// Pwan Can Move only to one direction
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        public override List<string> Moves(string currentPosition)
        {
            var currentPositionIndex = chess.BoardMap.IndexOf(chess.BoardMap.Find(value => value.Item1.Equals(currentPosition)));
            var nextPossibleMove = new List<string>
            {
                Convert.ToString(currentPositionIndex + Constant.Row)
            };

            //Check if the positions are not occupied
             return GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
