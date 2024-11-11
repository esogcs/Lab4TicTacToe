using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows;

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

        public void Select()
        {
            // Make image one turn into image two on mouse click
            private void Image_MouseDown(object sender, MouseButtonEventArgs e)
            {
                Image currentImage = (Image)sender;

                currentImage.Source = new BitmapImage(new Uri("two.jpg", UriKind.Relative));
            }

            private void sp1_Loaded(object sender, RoutedEventArgs e)
            {
                Label lbl1 = new Label();
                lbl1.Content = "AAAA";
                sp1.Children.Add(lbl1);
                Label lbl2 = new Label();
                lbl2.Content = "BBBB";
                sp1.Children.Add(lbl2);

            }

        }

        
        public String CheckWin()
        {


        }
    }
}
