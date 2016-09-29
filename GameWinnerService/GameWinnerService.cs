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
        public char Validate(char[,] gameBoard)
        {
            var columnOneChar = gameBoard[0, 0];
            var columnTwoChar = gameBoard[0, 1];
            var columnThreeChar = gameBoard[0, 2];

            var rowTwoChar = gameBoard[1, 0];
            var rowThreeChar = gameBoard[2, 0];

            if (columnOneChar == columnTwoChar &&
                 columnTwoChar == columnThreeChar)
            {
                return columnOneChar;
            }

            if (columnOneChar == rowTwoChar && rowTwoChar == rowThreeChar)
            {
                return columnOneChar;
            }

            return ' ';

        }
    }
}
