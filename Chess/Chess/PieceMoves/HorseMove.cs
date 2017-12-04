using Chess.Constants;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.PieceMoves
{
    public class HorseMove : BasePieceMoves
    {
        /// <summary>
        /// Horse can move bit wierd way :)
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        public override List<string> Moves(string currentPosition)
        {
            var currentPositionIndex = chess.BoardMap.IndexOf(chess.BoardMap.Find(value => value.Item1.Equals(currentPosition)));
            var nextPossibleMove = new List<int>
            {
                (currentPositionIndex + (Constant.Row - 2)),
                (currentPositionIndex + (Constant.Row + 2)),
                (currentPositionIndex - (Constant.Row - 2)),
                (currentPositionIndex - (Constant.Row + 2)),
                (currentPositionIndex - ((Constant.Row * 2) - 1)),
                (currentPositionIndex - ((Constant.Row * 2) + 1)),
                (currentPositionIndex + ((Constant.Row * 2) - 1)),
                (currentPositionIndex + ((Constant.Row * 2) + 1))
            };

            //Check if the positions are not occupied
            return GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
