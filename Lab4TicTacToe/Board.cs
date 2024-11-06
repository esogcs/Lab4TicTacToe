using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4TicTacToe
{
    internal class Board
    {
        PlayerEnum[,] board = new PlayerEnum[3, 3];
        PlayerEnum currentPlayer = PlayerEnum.X;
        int x_score_cumulative = 0;
        int y_score_cumulative = 0;

        public Board()
        {
            for (int x = 0; x < 3; x++)
                for (int y = 0; y < 3; y++)
                {
                    board[x,y] = PlayerEnum.NONE;
                }
            {

            }

        }
    }
}
