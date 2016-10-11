using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.Services;
using TicTacToe.AI;

namespace TicTacToe
{
    [TestClass]
    public class GameWinnerServiceTest
    {
        IGameWinnerService gameWinnerService = new GameWinnerService();
        AIOpponent         ai                = new AIOpponent();
        private char[,] gameBoard = new char[3, 3] { {' ', ' ', ' '},
                                                     {' ', ' ', ' '},
                                                     {' ', ' ', ' '}};
        

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
        [TestMethod]
        public void PlayerWithAllSpacesInColumn2Winner()
        {
            var _gameBoard = gameBoard;

            const char expected = 'X';
            for (var columIndex = 0; columIndex < 3; columIndex++)
            {
                _gameBoard[columIndex, 1] = expected;
            }
            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod]
        public void PlayerWithAllSpacesInColumn3Winner()
        {
            var _gameBoard = gameBoard;

            const char expected = 'X';
            for (var columIndex = 0; columIndex < 3; columIndex++)
            {
                _gameBoard[columIndex, 2] = expected;
            }
            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

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
                      {' ', ' ', ' '}
                    };

            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void PlayerWithAllSpacesInMiddleRowIsWinning()
        {
            const char expected = 'X';
            var gameBoard = new char[3, 3]
                    { {' ', ' ', ' '},
                      { expected, expected, expected},
                      {' ', ' ', ' '}
                    };

            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    

        [TestMethod]
        public void PlayerWithAllSpacesInBottomRowIsWinning()
        {
            const char expected = 'X';
            var gameBoard = new char[3, 3]
                    { {' ', ' ', ' '},
                      {' ', ' ', ' '},
                      { expected, expected, expected}
                    };

            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
            public void PlayerWithThreeInARowDiagonallyDownAndToRightIsWinner()
            {
                var _gameBoard = gameBoard;
                const char expected = 'X';
                for (var cellIndex = 0; cellIndex < 3; cellIndex++)
                {
                    _gameBoard[cellIndex, cellIndex] = expected;
                }
                var actual = gameWinnerService.Validate(_gameBoard);
                Assert.AreEqual(expected.ToString(), actual.ToString());

            }
      
        [TestMethod]
        public void PlayerWithThreeInARowDiagonallyDownAndToLeftIsWinner()
        {
            const char expected = 'X';
            var gameBoard = new char[3, 3]
                        { {' ', ' ', expected},
                          {' ', expected, ' '},
                          { expected, ' ', ' '}
                };

            var actual = gameWinnerService.Validate(gameBoard);
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }

    }
}
