using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Services;

namespace TicTacToe
{
    [TestClass]
    public class GameWinnerServiceTest
    {
        [TestMethod]
        public void NeitherPlayerHasThreeInARow()
        {
            IGameWinnerService gameWinnerService = new GameWinnerService();
            const char expected = ' ';
            var gameBoard = new char[3, 3] {{' ', ' ', ' '},
                                            {' ', ' ', ' '},
                                            {' ', ' ', ' '}};

            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlayerWithAllSpacesInTopRowIsWinning()
        {
            IGameWinnerService gameWinnerService = new GameWinnerService();
            const char expected = 'X';
            var gameBoard = new char[3, 3]
                    { { expected, expected, expected},
                      {' ', ' ', ' '},
                      {' ', ' ', ' '}};

            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

    }
}
