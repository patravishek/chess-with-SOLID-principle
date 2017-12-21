using Chess.Constant;
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
            var indexs = Helper.GetPositionIndexAndRowIndex(currentPosition);

            var nextPossibleMove = new List<int>
            {
                (indexs.currentPositionIndex + (Constant.Constants.Row - 2)),
                (indexs.currentPositionIndex + (Constant.Constants.Row + 2)),
                (indexs.currentPositionIndex - (Constant.Constants.Row - 2)),
                (indexs.currentPositionIndex - (Constant.Constants.Row + 2)),
                (indexs.currentPositionIndex - ((Constant.Constants.Row * 2) - 1)),
                (indexs.currentPositionIndex - ((Constant.Constants.Row * 2) + 1)),
                (indexs.currentPositionIndex + ((Constant.Constants.Row * 2) - 1)),
                (indexs.currentPositionIndex + ((Constant.Constants.Row * 2) + 1))
            };

            //Check if the positions are not occupied
            return Helper.GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
