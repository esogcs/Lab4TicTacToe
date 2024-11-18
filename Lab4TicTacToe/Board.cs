using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace Lab4TicTacToe
{
    internal class Board
    {
        static PlayerEnum[,] board = new PlayerEnum[3, 3];
        int x_score_cumulative = 0;
        int y_score_cumulative = 0;
        static PlayerEnum currentPlayer = PlayerEnum.X;
        static int turnsSinceStart = 0;

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

        public static void makeMove(int x, int y)
        {
            board[x, y] = currentPlayer;
        }

        public static void settingLocation(int i)
        {
            int x;
            int y;
            if (i >= 0 && i < 3)
            {
                x = 0;
                y = i;
            }
            else if (i >= 3 && i < 6)
            {
                y = i - 3;
                x = 1;
            }
            else
            {
                y = i - 6; 
                x = 2;
            }

            makeMove(x, y);
            CheckDraw(x, y);
        }

        public static void Select(object sender, MouseButtonEventArgs e)
        {
            Image currentImage = (Image)sender;
            if (currentImage.Name == "Blank1" || currentImage.Name == "Blank2" || currentImage.Name == "Blank3" || currentImage.Name == "Blank4" || currentImage.Name == "Blank5" || currentImage.Name == "Blank6" || currentImage.Name == "Blank7" || currentImage.Name == "Blank8" || currentImage.Name == "Blank9")
            {
                
                if (currentPlayer == PlayerEnum.X)
                {
                    currentImage.Source = new BitmapImage(new Uri("/Images/tic-tac-toe_x.png", UriKind.Relative));
                    settingLocation(int.Parse((string)currentImage.Tag));
                    changePlayer();
                }
                else
                {
                    currentImage.Source = new BitmapImage(new Uri("/Images/tic-tac-toe_o.png", UriKind.Relative));
                    changePlayer();
                }
                turnsSinceStart++;
            }
        }

        public static String CheckDraw(int x, int y)
        {
            if (turnsSinceStart == 9)
            {
                return "The game is a draw";
            }
            else
            {
                return CheckWin(x, y);
            }
        }

        public static bool CheckColumn(int x, int y)
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                if (board[i, y] == currentPlayer)
                {
                    count++;
                }
            }

            if (count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckRow(int x, int y)
        {
            int count = 0;
            for (int i = 0; i < 3; i++)
            {
                if (board[x, i] == currentPlayer)
                {
                    count++;
                }
            }

            if (count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckDiagonal()
        {
            int count = 0;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (x-y == 0 && board[x, y] == currentPlayer)
                    {
                        count++;
                    }
                }
            }

            if (count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckOppDiagonal()
        {
            int count = 0;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    if (x + y == 2 && board[x, y] == currentPlayer)
                    {
                        count++;
                    }
                }
            }

            if (count == 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static String CheckWin(int x, int y)
        {

            if ((CheckColumn(x, y) || CheckRow(x,y) || CheckDiagonal() || CheckOppDiagonal()) && currentPlayer == PlayerEnum.X)
            {
                return "Player X wins.";
            }
            else if ((CheckColumn(x, y) || CheckRow(x, y) || CheckDiagonal() || CheckOppDiagonal()) && currentPlayer == PlayerEnum.O) {
                return "Player O wins.";
            }
            else
            {
                return "The game is not over.";
            }

        }
    }
}
