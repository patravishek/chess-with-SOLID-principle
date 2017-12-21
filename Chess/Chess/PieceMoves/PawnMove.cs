using Chess.Constant;
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
            var indexs = Helper.GetPositionIndexAndRowIndex(currentPosition);
            var nextPossibleMove = new List<int>
            {
                (indexs.currentPositionIndex + Constant.Constants.Row)
            };

            //Check if the positions are not occupied
            return Helper.GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
