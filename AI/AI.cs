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
        private       bool madeMove          = false;

        public char[,] NextMove(char[,] gameBoard)
        {
            madeMove = false;

            WinOnRow(ref gameBoard);

            WinDiagonally(ref gameBoard);

            return gameBoard;
        }

        private void WinDiagonally(ref char[,] gameBoard)
        {
            int rightToLeft = WinSlot(gameBoard[0, 0], gameBoard[1, 1], gameBoard[2, 2]);
            int leftToRight = WinSlot(gameBoard[0, 2], gameBoard[1, 1], gameBoard[2, 0]);

            switch(leftToRight)
            {
                case 0:
                    gameBoard[0,2] = 'X';
                    madeMove = true;
                    break;
                case 1:
                    gameBoard[1,1] = 'X';
                    madeMove = true;
                    break;
                case 2:
                    gameBoard[2,0] = 'X';
                    madeMove = true;
                    break;
            }

            if(rightToLeft >= 0)
            {
                gameBoard[rightToLeft,rightToLeft] = 'X';
                madeMove = true;
            }
        }

        
        private void WinOnRow( ref char[,] gameBoard )
        {
        	for(int i = 0; i <= 2; i++)
            {
                int winSlot = WinSlot(gameBoard[i, 0], gameBoard[i, 1], gameBoard[i, 2]);
                
                if(winSlot >= 0)
                {
                    gameBoard[i,winSlot] = 'X';
                    madeMove = true;
                }
            }
        }

        private int WinSlot(char a, char b, char c)
        {
            if (a == SymbolForNoWinner && b == c)
                return 0;
            if (b == SymbolForNoWinner && a == c)
                return 1;
            if (c == SymbolForNoWinner && a == b)
                return 2;
            
            return -1;
        }
        


    }
}
