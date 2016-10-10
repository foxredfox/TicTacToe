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
    class AITest
    {
        [TestMethod]
        public void AICanWinTopRowLeft()
        {
            AIOpponent ai       = new AIOpponent();
            const char expected = 'X';
            var gameBoardBefore = new char[3, 3]
                    { { ' ', expected, expected},
                      {' ', ' ', ' '},
                      {' ', ' ', ' '}
                    };
                    
            var gameBoardAfter = new char[3, 3]
                    { { expected, expected, expected},
                      {' ', ' ', ' '},
                      {' ', ' ', ' '}
                    };

            var actual = ai.NextMove(gameBoardBefore);
            
            Assert.AreEqual(gameBoardAfter.ToString(), actual.ToString());
        }







    }
}
