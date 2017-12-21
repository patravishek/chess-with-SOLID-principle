using Chess.Implementation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chess.PieceMoves
{
    public abstract class BasePieceMoves
    {
        public abstract List<string> Moves(string currentPosition);
    }
}
