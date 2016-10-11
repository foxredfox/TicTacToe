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
            
            gameBoard = CanWinOnColumn(gameBoard);

            gameBoard = CanWinDiagonally(gameBoard);

            return gameBoard;
        }
        
        public char[,] CanWinOnRow(char[,] gameBoard)
        {
        	for(int i = 0; i <= 2; i++)
            {
          		int winField = WinField(gameBoard[i, 0], gameBoard[i, 1], gameBoard[i, 2]);
                
                if(winField >= 0)
              		gameBoard[i,winField] = 'X';
            }

            return gameBoard;
        }

        public char[,] CanWinOnColumn(char[,] gameBoard)
        {
            for (int i = 0; i <= 2; i++)
            {
                int winField = WinField(gameBoard[0, i], gameBoard[1, i], gameBoard[2, i]);

                if (winField >= 0)
                    gameBoard[winField, i] = 'X';

            }

            return gameBoard;
        }

        private int WinField(char a, char b, char c)
        {
            if (a == SymbolForNoWinner && b == c && c != SymbolForNoWinner)
                return 0;
            if (b == SymbolForNoWinner && a == c && a != SymbolForNoWinner)
                return 1;
            if (c == SymbolForNoWinner && a == b && a != SymbolForNoWinner) 
                return 2;
                
            return -1;
        }

        public char[,] CanWinDiagonally(char[,] gameBoard)
        {
            int winRightToLeft = WinField(gameBoard[0,2], gameBoard[1,1], gameBoard[2,0]);
            int winLeftToRight = WinField(gameBoard[0,0], gameBoard[1,1], gameBoard[2,2]);
            
            if(winLeftToRight >= 0)
                    gameBoard[winLeftToRight,winLeftToRight] = 'X';
                
            switch(winRightToLeft)
            {
                    case 0:
                        gameBoard[0,2] = 'X';
                        break;
                case 1:
                        gameBoard[1,1] = 'X';
                        break;
                case 2:
                        gameBoard[2,0] = 'X';
                        break;
            }
            
            return gameBoard;
        }

    }
}
