using Chess.Implementation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Chess.Tests
{
    [TestClass]
    public class ChessTest
    {
        [TestMethod]
        public void IsBoardGenerated()
        {
            var _chessObj = new ChessBoard();
            _chessObj.CreateChessBoard();
            Assert.AreEqual("A2", _chessObj.BoardMap.Find(val => val.Equals("A2")));
        }
    }
}
