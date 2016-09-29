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
    }
}
