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
            var outcome = bishop.Moves("G8");
            
            Assert.AreEqual("H7", outcome.Find(value => value.Equals("H7")));
            
            var outcome2 = bishop.Moves("D4");
            Assert.AreEqual("E3", outcome2.Find(value => value.Equals("E3")));
            Assert.AreEqual("F2", outcome2.Find(value => value.Equals("F2")));
            Assert.AreEqual("G1", outcome2.Find(value => value.Equals("G1")));
            Assert.AreEqual("C5", outcome2.Find(value => value.Equals("C5")));
            Assert.AreEqual("B6", outcome2.Find(value => value.Equals("B6")));
            Assert.AreEqual("A7", outcome2.Find(value => value.Equals("A7")));
            
        }
        
        [TestMethod]
        public void TestQueenMoves()
        {
            chess.CreateChessBoard();
            var queen = new QueenMove();
            var outcome = queen.Moves("G8");

            Assert.AreEqual("H7", outcome.Find(value => value.Equals("H7")));

            var outcome2 = queen.Moves("D4");
            Assert.AreEqual("E3", outcome2.Find(value => value.Equals("E3")));
            Assert.AreEqual("F2", outcome2.Find(value => value.Equals("F2")));
            Assert.AreEqual("G1", outcome2.Find(value => value.Equals("G1")));
            Assert.AreEqual("C5", outcome2.Find(value => value.Equals("C5")));
            Assert.AreEqual("B6", outcome2.Find(value => value.Equals("B6")));
            Assert.AreEqual("A7", outcome2.Find(value => value.Equals("A7")));

            var outcome3 = queen.Moves("E4");

            Assert.AreEqual("E8", outcome3.Find(value => value.Equals("E8")));
            Assert.AreEqual("E7", outcome3.Find(value => value.Equals("E7")));
            Assert.AreEqual("E6", outcome3.Find(value => value.Equals("E6")));
            Assert.AreEqual("E5", outcome3.Find(value => value.Equals("E5")));
            Assert.AreEqual("E3", outcome3.Find(value => value.Equals("E3")));
            Assert.AreEqual("E2", outcome3.Find(value => value.Equals("E2")));
            Assert.AreEqual("E1", outcome3.Find(value => value.Equals("E1")));

            Assert.AreEqual("A4", outcome3.Find(value => value.Equals("A4")));
            Assert.AreEqual("B4", outcome3.Find(value => value.Equals("B4")));
            Assert.AreEqual("C4", outcome3.Find(value => value.Equals("C4")));
            Assert.AreEqual("D4", outcome3.Find(value => value.Equals("D4")));
            Assert.AreEqual("F4", outcome3.Find(value => value.Equals("F4")));
            Assert.AreEqual("G4", outcome3.Find(value => value.Equals("G4")));
            Assert.AreEqual("H4", outcome3.Find(value => value.Equals("H4")));

        }

        [TestMethod]
        public void TestRootMoves()
        {
            chess.CreateChessBoard();
            var rook = new RookMove();
            var outcome = rook.Moves("E4");

            Assert.AreEqual("E8", outcome.Find(value => value.Equals("E8")));
            Assert.AreEqual("E7", outcome.Find(value => value.Equals("E7")));
            Assert.AreEqual("E6", outcome.Find(value => value.Equals("E6")));
            Assert.AreEqual("E5", outcome.Find(value => value.Equals("E5")));
            Assert.AreEqual("E3", outcome.Find(value => value.Equals("E3")));
            Assert.AreEqual("E2", outcome.Find(value => value.Equals("E2")));
            Assert.AreEqual("E1", outcome.Find(value => value.Equals("E1")));

            Assert.AreEqual("A4", outcome.Find(value => value.Equals("A4")));
            Assert.AreEqual("B4", outcome.Find(value => value.Equals("B4")));
            Assert.AreEqual("C4", outcome.Find(value => value.Equals("C4")));
            Assert.AreEqual("D4", outcome.Find(value => value.Equals("D4")));
            Assert.AreEqual("F4", outcome.Find(value => value.Equals("F4")));
            Assert.AreEqual("G4", outcome.Find(value => value.Equals("G4")));
            Assert.AreEqual("H4", outcome.Find(value => value.Equals("H4")));
        }
        
    }
}
