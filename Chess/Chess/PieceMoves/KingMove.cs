using Chess.Constant;
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
            var indexs = Helper.GetPositionIndexAndRowIndex(currentPosition);
            var nextPossibleMove = new List<int>
            {
                (indexs.currentPositionIndex + 1),//E5
                (indexs.currentPositionIndex - 1),//C5
                (indexs.currentPositionIndex + Constant.Constants.Row),//D4
                (indexs.currentPositionIndex + (Constant.Constants.Row + 1)),//E4
                (indexs.currentPositionIndex + (Constant.Constants.Row - 1)),//C4
                (indexs.currentPositionIndex - Constant.Constants.Row),//D6
                (indexs.currentPositionIndex - (Constant.Constants.Row + 1)),//C6
                (indexs.currentPositionIndex - (Constant.Constants.Row - 1))//E6
            };

            //Check if the positions are not occupied
            return Helper.GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
