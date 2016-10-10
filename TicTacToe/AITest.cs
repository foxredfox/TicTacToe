using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicTacToe.AI;

namespace TicTacToe
{
    [TestClass]
    public class AITest
    {
        AIOpponent         ai     = new AIOpponent();
        private char[,] gameBoard = new char[3, 3] { {' ', ' ', ' '},
                                                     {' ', ' ', ' '},
                                                     {' ', ' ', ' '}};
        

        [TestMethod]                                             
        public void AICanWinTopRow()
        {
            const char expected = 'X';
            var gameBoardBefore = new char[3, 3]
                    { { ' ', expected, expected},
                      {' ', ' ', ' '},
                      {' ', ' ', ' '}
                    };

            var actual = ai.NextMove(gameBoardBefore);
            Assert.AreEqual(expected.ToString(),actual[0,0].ToString());
            
            
            
            gameBoardBefore = new char[3, 3]
                    { { expected, ' ' , expected},
                      {' ', ' ', ' '},
                      {' ', ' ', ' '}
                    };
				
            actual = ai.NextMove(gameBoardBefore);
            Assert.AreEqual(expected.ToString(),actual[0,1].ToString());
            
            gameBoardBefore = new char[3, 3]
                    { { expected, expected , ' '},
                      {' ', ' ', ' '},
                      {' ', ' ', ' '}
                    };

            actual = ai.NextMove(gameBoardBefore);
            Assert.AreEqual(expected.ToString(),actual[0,2].ToString());
        }         

        [TestMethod]
        public void AICanWinMiddleRow()
        {
           const char expected = 'X';
            var gameBoardBefore = new char[3, 3]
                    { { ' ', ' ' , ' '},
                      {' ', expected, expected},
                      {' ', ' ', ' '}
                    };

            var actual = ai.NextMove(gameBoardBefore);
            Assert.AreEqual(expected.ToString(), actual[1, 0].ToString());


            gameBoardBefore = new char[3, 3]
                    { {' ', ' ' , ' '},
                      {expected, ' ',expected},
                      {' ', ' ', ' '}
                    };

            actual = ai.NextMove(gameBoardBefore);

            Assert.AreEqual(expected.ToString(), actual[1, 1].ToString());

            gameBoardBefore = new char[3, 3]
                    { { ' ', ' ' , ' '},
                      {expected, expected, ' '},
                      {' ', ' ', ' '}
                    };

            actual = ai.NextMove(gameBoardBefore);

            Assert.AreEqual(expected.ToString(), actual[1, 2].ToString());
        }
                                

        [TestMethod]
        public void AICanWinBottomRow()
        {
            const char expected = 'X';
            var gameBoardBefore = new char[3, 3]
                    { { ' ', ' ', ' '},
                      { ' ', ' ', ' '},
                      {' ', expected, expected}
                    };

            var actual = ai.NextMove(gameBoardBefore);
            Assert.AreEqual(expected.ToString(), actual[2, 0].ToString());
            
            gameBoardBefore = new char[3, 3]
                    { { ' ', ' ', ' '},
                      { ' ', ' ', ' '},
                      {expected, ' ', expected}
                    };

            actual = ai.NextMove(gameBoardBefore);
            Assert.AreEqual(expected.ToString(), actual[2, 1].ToString());
            
            gameBoardBefore = new char[3, 3]
                    { { ' ', ' ', ' '},
                      { ' ', ' ', ' '},
                      {expected, expected, ' '}
                    };

            actual = ai.NextMove(gameBoardBefore);
            Assert.AreEqual(expected.ToString(), actual[2, 2].ToString());
        }


        [TestMethod]
        public void AICanWinDiagonally()
        {
            const char expected = 'X';
            var gameBoard = new char[3, 3]
                        { {' ', ' ', expected},
                          {' ', expected, ' '},
                          { ' ', ' ', ' '}
                };

            var actual = ai.NextMove(gameBoard);
            Assert.AreEqual(expected.ToString(), actual[2, 0].ToString());
            
            gameBoard = new char[3, 3]
                        { {' ', ' ', expected},
                          {' ', ' ', ' '},
                          { expected, ' ', ' '}
                };

            actual = ai.NextMove(gameBoard);
            Assert.AreEqual(expected.ToString(), actual[1, 1].ToString());
            
            gameBoard = new char[3, 3]
                        	{ {' ', ' ', ' '},
                          {' ', expected, ' '},
                          { expected, ' ', ' '}
                };

            actual = ai.NextMove(gameBoard);
            Assert.AreEqual(expected.ToString(), actual[0, 2].ToString());
	
            gameBoard = new char[3, 3]
                        { {expected, ' ', ' '},
                          {' ', expected, ' '},
                          { ' ', ' ', ' '}
                };

            actual = ai.NextMove(gameBoard);
            Assert.AreEqual(expected.ToString(), actual[2, 2].ToString());
            
            gameBoard = new char[3, 3]
                        { {expected, ' ', ' '},
                          {' ', ' ', ' '},
                          { ' ', ' ', expected}
                };

            actual = ai.NextMove(gameBoard);
            Assert.AreEqual(expected.ToString(), actual[1, 1].ToString());
            
            gameBoard = new char[3, 3]
                        	{ {' ', ' ', ' '},
                          {' ', expected, ' '},
                          { ' ', ' ', expected}
                };

            actual = ai.NextMove(gameBoard);
            Assert.AreEqual(expected.ToString(), actual[0, 0].ToString());
        }



    }
}
