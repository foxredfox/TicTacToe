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
            return ' ';
        }
    }
}
