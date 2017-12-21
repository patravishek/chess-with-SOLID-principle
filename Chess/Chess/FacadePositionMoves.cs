using Chess.PieceMoves;
using Chess.PieceMoves.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class FacadePositionMoves
    {
        public readonly List<BasePieceMoves> positionMovesType;

        public FacadePositionMoves()
        {
            //Here we can use reflection to load all the dependency classes, 
            //but we have to make sure that the performance didn't hit up for that reason
            //Whenever new class adds up in the implementation we have to let the Facade class 
            //let know about the implementation so it cal travarse 
            positionMovesType = new List<BasePieceMoves>
            {
                new RookMove(),
                new BishopMove(),
                new HorseMove(),
                new KingMove(),
                new QueenMove(),
                new PawnMove()
            };
        }
    }
}
