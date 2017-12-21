using Chess.PieceMoves;
using Chess.PieceMoves.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class FacadePositionMoves
    {
        public readonly List<BasePieceMoves> PositionMovesType;

        public FacadePositionMoves()
        {
            //Here we can use reflection to load all the dependency classes, 
            //but we have to make sure that the performance didn't hit up for that reason
            PositionMovesType = new List<BasePieceMoves>
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
