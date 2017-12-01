using Chess.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess.Tests
{
    [TestClass]
    public class ChessBoardTest
    {
        ChessBoard _chessObj;
        
        [TestInitialize]
        public void Setup()
        {
            _chessObj = new ChessBoard();
        }

        [TestMethod]
        public void IsBoardGenerated()
        {
            _chessObj.CreateChessBoard();
            Assert.AreEqual("A2", _chessObj.BoardMap.Find(val => val.Equals("A2")));
        }

        [TestMethod]
        public void IsKingsMoveTrue()
        {

        }
    }
}
