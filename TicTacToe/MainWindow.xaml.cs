using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace TicTacToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 9; i++)
            {
                isClicked[i] = false;
            }

            msgBox.Text = "X starts first!";
            scoreX.Text = scrX.ToString();
            scoreO.Text = scrO.ToString();

        }

        int scrX = 0;
        int scrO = 0;

        bool X = true;
        bool O = false;

        bool signal = false;
        bool[] isClicked = new bool[9];

        int counter = 0;
        string[] array={"0","0","0","0","0","0","0","0","0"};


        private void winnerX()
        {
            MessageBox.Show("Winner is X", "Winner", MessageBoxButton.OK, MessageBoxImage.Information);
            msgBox.Text = "Winner is X. Restart game !";
            scrX++;
            scoreX.Text = scrX.ToString();
            
        }
        private void winnerO()
        {
            MessageBox.Show("Winner is O","Winner",MessageBoxButton.OK,MessageBoxImage.Information);
            msgBox.Text = "Winner is O. Restart game !";
            scrO++;
            scoreO.Text = scrO.ToString();
 
        }
        private void isDrawBattle()
        {
            if ((counter == 9) && !(CheckForWin()))
            {
                MessageBox.Show("Draw battle", "Winner", MessageBoxButton.OK, MessageBoxImage.Information);
                msgBox.Text = "Draw battle";
            }
 
        }
        
        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int button = 0;

            if (signal)
            {
                return;
            }

            if (isClicked[0])
            {
                return;
            }
            
            if (X && (counter < 9))
            {
                msgBox.Text="Now its X's turn !";
                button1.Content = "X";
                array[button] = "x";
                X = false;
                O = true;
                if (!signal)
                {
                    msgBox.Text = "Now its O's turn !";
                }
            }
            else if (O && (counter < 9))
            {
                msgBox.Text = "Not its O's turn !";
                button1.Content = "O";
                array[button] = "o";
                O = false;
                X = true;
                if (!signal)
                {
                    msgBox.Text = "Now its X's turn !";
                }
            }
            else return;
            counter++;

            isClicked[0] = true;

            if (CheckForWin())
            {
                return;
            }

            isDrawBattle();
        }
                
        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int button = 1;

            if (signal)
            {
                return;
            }
            if (isClicked[1])
            {
                return;
            }

            if (X && (counter < 9))
            {
                msgBox.Text = "Now its X's turn !";
                button2.Content = "X";
                array[button] = "x";
                X = false;
                O = true;
                if (!signal)
                {
                    msgBox.Text = "Now its O's turn !";
                }
            }
            else if (O && (counter < 9))
            {
                msgBox.Text = "O's turn !";
                button2.Content = "O";
                array[button] = "o";
                O = false;
                X = true;
                if (!signal)
                {
                    msgBox.Text = "X's turn !";
                }
            }
            else return;
            counter++;
            isClicked[1] = true;

            if (CheckForWin())
            {
                return;
            }

            isDrawBattle();
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            int button = 2;

            if (signal)
            {
                return;
            }
            if (isClicked[2])
            {
                return;
            }

            if (X && (counter < 9))
            {
                msgBox.Text = "X's turn !";
                button3.Content = "X";
                array[button] = "x";
                X = false;
                O = true;
                if (!signal)
                {
                    msgBox.Text = "O's turn !";
                }
            }
            else if (O && (counter < 9))
            {
                msgBox.Text = "O's turn !";
                button3.Content = "O";
                array[button] = "o";
                O = false;
                X = true;
                if (!signal)
                {
                    msgBox.Text = "X's turn !";
                }
            }
            else return;
            counter++;
            isClicked[2] = true;

            if (CheckForWin())
            {
                return;
            }

            isDrawBattle();
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            int button = 3;

            if (signal)
            {
                return;
            }
            if (isClicked[3])
            {
                return;
            }

            if (X && (counter < 9))
            {
                msgBox.Text = "X's turn !";
                button4.Content = "X";
                array[button] = "x";
                X = false;
                O = true;
                if (!signal)
                {
                    msgBox.Text = "O's turn !";
                }
            }
            else if (O && (counter < 9))
            {
                msgBox.Text = "O's turn !";
                button4.Content = "O";
                array[button] = "o";
                O = false;
                X = true;
                if (!signal)
                {
                    msgBox.Text = "X's turn !";
                }
            }
            else return;
            counter++;
            isClicked[3] = true;

            if (CheckForWin())
            {
                return;
            }
            isDrawBattle();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            int button = 4;

            if (signal)
            {
                return;
            }
            if (isClicked[4])
            {
                return;
            }

            if (X   &&  (counter < 9))
            {
                msgBox.Text = "X's turn !";
                button5.Content = "X";
                array[button] = "x";
                X = false;
                O = true;
                if (!signal)
                {
                    msgBox.Text = "O's turn !";
                }
            }
            else if (O && (counter < 9))
            {
                msgBox.Text = "O's turn !";
                button5.Content = "O";
                array[button] = "o";
                O = false;
                X = true;
                if (!signal)
                {
                    msgBox.Text = "X's turn !";
                }
            }
            else return;
            counter++;
            isClicked[4] = true;

            if (CheckForWin())
            {
                return;
            }

            isDrawBattle();
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            int button = 5;

            if (signal)
            {
                return;
            }
            if (isClicked[5])
            {
                return;
            }

            if (X && (counter<9))
            {
                msgBox.Text = "X's turn !";
                button6.Content = "X";
                array[button] = "x";
                X = false;
                O = true;
                if (!signal)
                {
                    msgBox.Text = "O's turn !";
                }
            }
            else if (O && (counter < 9))
            {
                msgBox.Text = "O's turn !";
                button6.Content = "O";
                array[button] = "o";
                O = false;
                X = true;
                if (!signal)
                {
                    msgBox.Text = "X's turn !";
                }
            }

            else return;
            counter++;
            isClicked[5] = true;

            if (CheckForWin())
            {
                return;
            }

            isDrawBattle();
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            int button = 6;

            if (signal)
            {
                return;
            }
            if (isClicked[6])
            {
                return;
            }

            if (X && (counter < 9))
            {
                msgBox.Text = "X's turn !";
                button7.Content = "X";
                array[button] = "x";
                X = false;
                O = true;
                if (!signal)
                {
                    msgBox.Text = "O's turn !";
                }
            }
            else if (O && (counter < 9))
            {
                msgBox.Text = "O's turn !";
                button7.Content = "O";
                array[button] = "o";
                O = false;
                X = true;
                if (!signal)
                {
                    msgBox.Text = "X's turn !";
                }
            }
            else return;
            counter++;
            isClicked[6] = true;

            if (CheckForWin())
            {
                return;
            }
            isDrawBattle();
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            int button = 7;

            if (signal)
            {
                return;
            }
            if (isClicked[7])
            {
                return;
            }

            if (X && (counter < 9))
            {
                msgBox.Text = "X's turn !";
                button8.Content = "X";
                array[button] = "x";
                X = false;
                O = true;
                if (!signal)
                {
                    msgBox.Text = "O's turn !";
                }
            }
            else if (O && (counter < 9))
            {
                msgBox.Text = "O's turn !";
                button8.Content = "O";
                array[button] = "o";
                O = false;
                X = true;
                if (!signal)
                {
                    msgBox.Text = "X's turn !";
                }
            }
            else return;
            counter++;
            isClicked[7] = true;

            if (CheckForWin())
            {
                return;
            }
            isDrawBattle();
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            int button = 8;

            if (signal)
            {
                return;
            }
            if (isClicked[8])
            {
                return;
            }

            if (X && (counter < 9))
            {
                msgBox.Text = "X's turn !";
                button9.Content = "X";
                array[button] = "x";
                X = false;
                O = true;
                if (!signal)
                {
                    msgBox.Text = "Now its O's turn !";
                }
            }
            else if (O && (counter < 9))
            {
                msgBox.Text = "O's turn !";
                button9.Content = "O";
                array[button] = "o";
                O = false;
                X = true;
                if (!signal)
                {
                    msgBox.Text = "X's turn !";
                }
            }
            else return;
            counter++;
            isClicked[8] = true;

            if (CheckForWin())
            {
                return;
            }
            isDrawBattle();
        }

        private void button10_Click(object sender, RoutedEventArgs e) /*Restart*/
        {
            button1.Content = button2.Content = button3.Content = button4.Content = button5.Content = button6.Content = button7.Content = button8.Content = button9.Content = "";
            
            for (int i = 0; i < 9; i++)
            {
                isClicked[i] = false;
            }

            msgBox.Text = "X starts first!";
            counter = 0;
            signal = false;

            X = true;
            O = false;

            for (int i = 0; i < 9; i++)
            {
                array[i] = "0";
            } 
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            scrX = scrO = 0;
            scoreX.Text = scrX.ToString();
            scoreO.Text = scrO.ToString();
            msgBox.Text = "Scores are reseted!";
        }


        private bool CheckForWin()
        {
            bool flag = false;

            if ((array[0] == array[1]) && (array[0] == array[2]) && (array[0] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[0] == array[1]) && (array[0] == array[2]) && (array[0] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[3] == array[4]) && (array[3] == array[5]) && (array[3] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[3] == array[4]) && (array[3] == array[5]) && (array[3] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[6] == array[7]) && (array[6] == array[8]) && (array[6] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[6] == array[7]) && (array[6] == array[8]) && (array[6] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[0] == array[3]) && (array[0] == array[6]) && (array[0] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[0] == array[3]) && (array[0] == array[6]) && (array[0] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[1] == array[4]) && (array[1] == array[7]) && (array[1] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[1] == array[4]) && (array[1] == array[7]) && (array[1] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[2] == array[5]) && (array[2] == array[8]) && (array[2] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[2] == array[5]) && (array[2] == array[8]) && (array[2] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[0] == array[4]) && (array[0] == array[8]) && (array[0] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[0] == array[4]) && (array[0] == array[8]) && (array[0] == "o"))
            {
                winnerO();
                flag = true;
            }
            else if ((array[2] == array[4]) && (array[2] == array[6]) && (array[2] == "x"))
            {
                winnerX();
                flag = true;
            }
            else if ((array[2] == array[4]) && (array[2] == array[6]) && (array[2] == "o"))
            {
                winnerO();
                flag = true;
            }

            signal = flag;
            return flag;
        }

    }


}
