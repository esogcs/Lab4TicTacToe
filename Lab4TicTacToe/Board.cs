using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Windows.Controls;

namespace Lab4TicTacToe
{
    internal class Board
    {
        PlayerEnum[,] board = new PlayerEnum[2, 2];
        int x_score_cumulative = 0;
        int y_score_cumulative = 0;
        static PlayerEnum currentPlayer = PlayerEnum.X;

        public Board()
        {
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    board[x,y] = PlayerEnum.NONE;
                }
            }

        }

        public static void changePlayer()
        {
            if (currentPlayer == PlayerEnum.X)
            {
                currentPlayer = PlayerEnum.O;
            }

            else
            {
                currentPlayer = PlayerEnum.X;
            }
        }

        public static void Select(object sender, MouseButtonEventArgs e)
        {
            Image currentImage = (Image)sender;
            if (currentImage.Name == "Blank1" || currentImage.Name == "Blank2" || currentImage.Name == "Blank3" || currentImage.Name == "Blank4" || currentImage.Name == "Blank5" || currentImage.Name == "Blank6" || currentImage.Name == "Blank7" || currentImage.Name == "Blank8" || currentImage.Name == "Blank9")
            {
                
                if (currentPlayer == PlayerEnum.X)
                {
                    currentImage.Source = new BitmapImage(new Uri("/Images/tic-tac-toe_x.png", UriKind.Relative));
                    changePlayer();
                }
                else
                {
                    currentImage.Source = new BitmapImage(new Uri("/Images/tic-tac-toe_o.png", UriKind.Relative));
                    changePlayer();
                }
            }
        }

        
        public void CheckWin()
        {

            if (true)
            {
                
            }

        }
    }
}
