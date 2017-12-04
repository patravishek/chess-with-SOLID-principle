using Chess.Implementation;
using Chess.PieceMoves;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess.Tests
{
    [TestClass]
    public class ChessBoardTest
    {
        ChessBoard chess;

        [TestInitialize]
        public void Setup()
        {
            chess = ChessBoard.Instance;
        }

        [TestMethod]
        public void TestBoardSettings()
        {
            chess.CreateChessBoard();
            Assert.AreEqual("A2", chess.BoardMap.Find(value=>value.Item1.Equals("A2")).Item1);
            Assert.AreEqual(false, chess.BoardMap.Find(value => value.Item1.Equals("A2")).Item2);

            Assert.AreEqual("A6", chess.BoardMap.Find(value => value.Item1.Equals("A6")).Item1);
            Assert.AreEqual(false, chess.BoardMap.Find(value => value.Item1.Equals("A6")).Item2);
        }
        
        [TestMethod]
        public void TestKingMoves()
        {
            chess.CreateChessBoard();
            var king = new KingMove();
            var outcome1 = king.Moves("D5");
            Assert.AreEqual("D6", outcome1.Find(value => value.Equals("D6")));
            Assert.AreEqual("E6", outcome1.Find(value => value.Equals("E6")));
            Assert.AreEqual("C6", outcome1.Find(value => value.Equals("C6")));
            Assert.AreEqual("C5", outcome1.Find(value => value.Equals("C5")));
            Assert.AreEqual("E5", outcome1.Find(value => value.Equals("E5")));
            Assert.AreEqual("D4", outcome1.Find(value => value.Equals("D4")));
            Assert.AreEqual("C4", outcome1.Find(value => value.Equals("C4")));
            Assert.AreEqual("E4", outcome1.Find(value => value.Equals("E4")));
        }

        [TestMethod]
        public void TestPawnMoves()
        {
            var pawn = new PawnMove();
            var outcome1 = pawn.Moves("H7");
            Assert.AreEqual("H6", outcome1.Find(value => value.Equals("H6")));
            var outcome2 = pawn.Moves("A7");
            Assert.AreEqual("A6", outcome2.Find(value => value.Equals("A6")));
            var outcome3 = pawn.Moves("B3");
            Assert.AreEqual("B2", outcome3.Find(value => value.Equals("B2")));
            var outcome4 = pawn.Moves("E5");
            Assert.AreEqual("E4", outcome4.Find(value => value.Equals("E4")));
        }
    }
}
