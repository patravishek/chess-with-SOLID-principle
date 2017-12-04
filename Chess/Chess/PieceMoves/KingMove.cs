using Chess.Constants;
using System;
using System.Collections.Generic;

namespace Chess.PieceMoves
{
    public class KingMove : BasePieceMoves
    {
        /// <summary>
        /// King can move in 8 direction
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        public override List<string> Moves(string currentPosition)
        {
            var currentPositionIndex = chess.BoardMap.IndexOf(chess.BoardMap.Find(value => value.Item1.Equals(currentPosition)));
            var nextPossibleMove = new List<int>
            {
                (currentPositionIndex + 1),//E5
                (currentPositionIndex - 1),//C5
                (currentPositionIndex + Constant.Row),//D4
                (currentPositionIndex + (Constant.Row + 1)),//E4
                (currentPositionIndex + (Constant.Row - 1)),//C4
                (currentPositionIndex - Constant.Row),//D6
                (currentPositionIndex - (Constant.Row + 1)),//C6
                (currentPositionIndex - (Constant.Row - 1))//E6
            };

            //Check if the positions are not occupied
            return GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
