using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Services;

namespace TicTacToe
{
    [TestClass]
    public class GameWinnerServiceTest
    {
            IGameWinnerService gameWinnerService = new GameWinnerService();
        char[,] gameBoard = new char[3, 3] { {' ', ' ', ' '},
                                             {' ', ' ', ' '},
                                             {' ', ' ', ' '}};

        [TestMethod]
        public void NeitherPlayerHasThreeInARow()
        {            
            const char expected = ' ';
            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PlayerWithAllSpacesInTopRowIsWinning()
        {      
            const char expected = 'X';
            var gameBoard = new char[3, 3]
                    { { expected, expected, expected},
                      {' ', ' ', ' '},
                      {' ', ' ', ' '}};

            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void PlayerWithAllSpacesInColumIsWinner()
        {
            var _gameBoard = gameBoard;

            const char expected = 'X';
            for (var columIndex = 0; columIndex < 3; columIndex++)
            {
                _gameBoard[columIndex, 0] = expected;
            }
            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
