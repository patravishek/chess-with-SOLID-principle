using Chess.PieceMoves.Base;
using Chess.PieceMoves.TypeMoves;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    public class FacadePositionMoves
    {
        public readonly List<PositionMoves> PositionMovesType;

        public FacadePositionMoves()
        {
            PositionMovesType = new List<PositionMoves>
            {
                new RookTypeMove(),
                new BishopTypeMove(),
                new HorseTypeMove(),
                new KingTypeMove(),
                new QueenTypeMove(),
                new PawnTypeMove()
            };
        }
    }
}
