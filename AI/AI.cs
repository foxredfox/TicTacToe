using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.AI
{
    public class AIOpponent
    {
        private const char SymbolForNoWinner = ' ';

        public char[,] NextMove(char[,] gameBoard)
        {
            gameBoard = CanWinOnRow(gameBoard);

            return gameBoard;
        }
        
        public char[,] CanWinOnRow(char[,] gameBoard)
        {
        	for(int i = 0; i <= 2; i++)
            {
        		var columnOneChar   = gameBoard[i, 0];
				var columnTwoChar   = gameBoard[i, 1];
        		var columnThreeChar = gameBoard[i, 2];
                
                if (columnOneChar == SymbolForNoWinner && columnTwoChar == columnThreeChar)
                {
                    gameBoard[i,0] = 'X';
                }

                if (columnTwoChar == SymbolForNoWinner && columnThreeChar == columnOneChar)
                {
                    gameBoard[i,1] = 'X';
                }

                if (columnThreeChar == SymbolForNoWinner && columnTwoChar == columnOneChar)
                {
                    gameBoard[i,2] = 'X';
                }
            }

            return gameBoard;
        }
        

    }
}
