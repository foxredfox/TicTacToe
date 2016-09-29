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
            var columOneChar = gameBoard[0, 0];
            var columTwoChar = gameBoard[0, 1];
            var columThreeChar = gameBoard[0, 2];

            if (columOneChar == columTwoChar &&
                 columTwoChar == columThreeChar)
            {
                return columOneChar;
            }


            return ' ';


        }
    }
}
