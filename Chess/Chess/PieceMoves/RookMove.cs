using Chess.PieceMoves.Base.HorizontalMoves;
using Chess.PieceMoves.Base.VerticalMoves;
using System.Collections.Generic;

namespace Chess.PieceMoves
{
    public class RookMove : BasePieceMoves
    {
        private IHorizontalMoves horizontalMove;
        private IVerticalMoves verticalMoves;

        //This can be called through facade class using dependency injection
        public RookMove()
        {
            horizontalMove = new HorizontalMoves();
            verticalMoves = new VerticalMoves();
        }

        /// <summary>
        /// Rook's can move vertically and horizontally 
        /// </summary>
        /// <param name="currentPosition"></param>
        /// <returns></returns>
        public override List<string> Moves(string currentPosition)
        {
            var nextPossibleMove = new List<int>();
            var indexs = Helper.GetPositionIndexAndRowIndex(currentPosition);

            //Predicting Positions
            nextPossibleMove.AddRange(verticalMoves.VerticalDownMoves(indexs.currentPositionIndex));
            nextPossibleMove.AddRange(verticalMoves.VerticalUpMoves(indexs.currentPositionIndex));
            nextPossibleMove.AddRange(horizontalMove.HorizontalForwardMoves(indexs.currentPositionIndex, indexs.rowIndex));
            nextPossibleMove.AddRange(horizontalMove.HorizontalReverseMoves(indexs.currentPositionIndex, indexs.rowIndex));

            //Check if the positions are not occupied and are valid moves
            return Helper.GettingActualPossibleMove(nextPossibleMove);
        }
    }
}
