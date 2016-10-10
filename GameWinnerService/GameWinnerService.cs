using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public interface IGameWinnerService
    {
        char Validate(char[,] gameBoard);
    }

    public class GameWinnerService : IGameWinnerService
    {
    	private const char SymbolForNoWinner = ' ';
      
      public char Validate(char[,] gameBoard)
        {
		    var currentWinningSymbol = CheckForThreeInARowInHorizontalRow(gameBoard);            
            if(currentWinningSymbol != SymbolForNoWinner)
            	return currentWinningSymbol;
            
            currentWinningSymbol = CheckForThreeInARowInVerticalColumn(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
                return currentWinningSymbol;

            currentWinningSymbol = CheckForThreeInARowDiagonally(gameBoard);
            if(currentWinningSymbol != SymbolForNoWinner)
                return currentWinningSymbol;

            currentWinningSymbol = CheckForThreeInARowDiagonally2(gameBoard);


            return currentWinningSymbol;
        }


        private static char CheckForThreeInARowInHorizontalRow(char[,] gameBoard)
        {
            for (int i = 0; i <= 2; i++)
            {
                var columnOneChar   = gameBoard[i, 0];
                var columnTwoChar   = gameBoard[i, 1];
                var columnThreeChar = gameBoard[i, 2];

                if (columnOneChar == columnTwoChar &&
                    columnTwoChar == columnThreeChar &&
                    columnOneChar != SymbolForNoWinner)

                   {
                    return columnOneChar;
                   }
            }

            return SymbolForNoWinner;
        }


        private static char CheckForThreeInARowInVerticalColumn(char[,] gameBoard)
        {
            for (int i = 0; i <= 2; i++)
            {

                var rowOneChar   = gameBoard[0, i];
                var rowTwoChar   = gameBoard[1, i];
                var rowThreeChar = gameBoard[2, i];

                if (rowOneChar == rowTwoChar &&
                    rowTwoChar == rowThreeChar &&
                    rowOneChar != SymbolForNoWinner)
                {
                    return rowOneChar;
                }

            }

            return SymbolForNoWinner;

        }
        private static char CheckForThreeInARowDiagonally(char[,] gameBoard)
        {
            var cellOneChar   = gameBoard[0, 0];
            var cellTwoChar   = gameBoard[1, 1];
            var cellThreeChar = gameBoard[2, 2];

            if (cellOneChar == cellTwoChar &&
                 cellTwoChar == cellThreeChar)
            {
                return cellOneChar;
            }

            return SymbolForNoWinner;
        }
        private static char CheckForThreeInARowDiagonally2(char[,] gameBoard)
        {
            var cellOneChar   = gameBoard[0, 2];
            var cellTwoChar   = gameBoard[1, 1];
            var cellThreeChar = gameBoard[2, 0];

            if (cellOneChar == cellTwoChar &&
                 cellTwoChar == cellThreeChar)
            {
                return cellOneChar;
            }

            return SymbolForNoWinner;
        }


    }		
}
