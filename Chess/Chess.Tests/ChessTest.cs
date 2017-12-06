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

            Assert.IsNull(chess.BoardMap.Find(value => value.Item1.Equals("D9")));
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

            var outcome2 = king.Moves("D8");
            Assert.AreEqual("D7", outcome2.Find(value => value.Equals("D7")));
            Assert.AreEqual("E8", outcome2.Find(value => value.Equals("E8")));
            Assert.AreEqual("C8", outcome2.Find(value => value.Equals("C8")));
            Assert.AreEqual("C7", outcome2.Find(value => value.Equals("C7")));
            Assert.AreEqual("E7", outcome2.Find(value => value.Equals("E7")));

            //Tests should fail since they are out of index
            Assert.AreNotEqual("D9", outcome2.Find(value => value.Equals("D9")));
            Assert.AreNotEqual("C9", outcome2.Find(value => value.Equals("C9")));
            Assert.AreNotEqual("E9", outcome2.Find(value => value.Equals("E9")));
        }

        [TestMethod]
        public void TestHorseMoves()
        {
            chess.CreateChessBoard();
            var horse = new HorseMove();
            var outcome1 = horse.Moves("E3");
            Assert.AreEqual("D5", outcome1.Find(value => value.Equals("D5")));
            Assert.AreEqual("F5", outcome1.Find(value => value.Equals("F5")));
            Assert.AreEqual("C4", outcome1.Find(value => value.Equals("C4")));
            Assert.AreEqual("G4", outcome1.Find(value => value.Equals("G4")));
            Assert.AreEqual("C2", outcome1.Find(value => value.Equals("C2")));
            Assert.AreEqual("G2", outcome1.Find(value => value.Equals("G2")));
            Assert.AreEqual("D1", outcome1.Find(value => value.Equals("D1")));
            Assert.AreEqual("F1", outcome1.Find(value => value.Equals("F1")));
        }

        [TestMethod]
        public void TestPawnMoves()
        {
            chess.CreateChessBoard();
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

        [TestMethod]
        public void TestBishopMoves()
        {
            chess.CreateChessBoard();
            var bishop = new BishopMove();
            var outcome1 = bishop.Moves("D4");
            Assert.AreEqual("E3", outcome1.Find(value => value.Equals("E3")));
            Assert.AreEqual("C3", outcome1.Find(value => value.Equals("C3")));
            Assert.AreEqual("B2", outcome1.Find(value => value.Equals("B2")));
            Assert.AreEqual("F2", outcome1.Find(value => value.Equals("F2")));
            Assert.AreEqual("A1", outcome1.Find(value => value.Equals("A1")));
            Assert.AreEqual("G1", outcome1.Find(value => value.Equals("G1")));
            Assert.AreEqual("C5", outcome1.Find(value => value.Equals("C5")));
            Assert.AreEqual("B6", outcome1.Find(value => value.Equals("B6")));
            Assert.AreEqual("G7", outcome1.Find(value => value.Equals("G7")));
            Assert.AreEqual("A7", outcome1.Find(value => value.Equals("A7")));
            Assert.AreEqual("H8", outcome1.Find(value => value.Equals("H8")));
            Assert.AreEqual("B6", outcome1.Find(value => value.Equals("B6")));
            Assert.AreEqual("F6", outcome1.Find(value => value.Equals("F6")));

            var outcome2 = bishop.Moves("D8");
            Assert.AreEqual("C7", outcome2.Find(value => value.Equals("C7")));
            Assert.AreEqual("E7", outcome2.Find(value => value.Equals("E7")));
            Assert.AreEqual("B6", outcome2.Find(value => value.Equals("B6")));
            Assert.AreEqual("F6", outcome2.Find(value => value.Equals("F6")));
            Assert.AreEqual("A5", outcome2.Find(value => value.Equals("A5")));
            Assert.AreEqual("G5", outcome2.Find(value => value.Equals("G5")));
            Assert.AreEqual("H4", outcome2.Find(value => value.Equals("H4")));

            var outcome3 = bishop.Moves("F4");
            Assert.AreEqual("H6", outcome3.Find(value => value.Equals("H6")));
            Assert.AreEqual("C1", outcome3.Find(value => value.Equals("C1")));

        }

        [TestMethod]
        public void TestPieceMoveInBoard()
        {
            chess.CreateChessBoard();
            var outcome = chess.PieceMoveInBoard("King", "D5");
            Assert.IsNotNull(outcome);
        }
    }
}
