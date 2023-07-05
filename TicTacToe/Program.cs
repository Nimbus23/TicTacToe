using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {


        static char[,] matrix =
        {
                    {'1','2','3'},
                    {'4','5','6'},
                    {'7','8','9'}
        };

        static int turns = 0;

        static void Main(string[] args)
        {

            

           

            int player = 2;
            int input = 0;
            bool inputCorrect = true;

           


            do
            {
                if (player == 2)
                {
                    player = 1;
                    XorO('O', input);
                }
                else
                {
                    player = 2;
                    XorO('X', input);
                }


                CreateField();
                #region
                //Check for the winner

                char[] playerChars = { 'X', 'O' };

                foreach(char c in playerChars)
                {
                    if (((matrix[0, 0] == c) && (matrix[0, 1] == c) && (matrix[0, 2] == c))
                        || ((matrix[1, 0] == c) && (matrix[1, 1] == c) && (matrix[1, 2] == c))
                        || ((matrix[2, 0] == c) && (matrix[2, 1] == c) && (matrix[2, 2] == c))
                        || ((matrix[0, 0] == c) && (matrix[1, 0] == c) && (matrix[2, 0] == c))
                        || ((matrix[0, 1] == c) && (matrix[1, 1] == c) && (matrix[2, 1] == c))
                        || ((matrix[0, 2] == c) && (matrix[1, 2] == c) && (matrix[2, 2] == c))
                        || ((matrix[0, 0] == c) && (matrix[1, 1] == c) && (matrix[2, 2] == c))
                        || ((matrix[0, 2] == c) && (matrix[1, 1] == c) && (matrix[2, 0] == c)))
                    {
                        if (c == 'X')
                        {
                            Console.WriteLine("\nPlayer 1 has won");
                        }
                        else
                            Console.WriteLine("\nPlayer 2 has won");
                        Console.WriteLine("Press any key to reset the game");
                        Console.ReadKey();
                        ResetField(); break;
                    }
                    else if (turns == 10)
                    {
                        Console.WriteLine("\nDraw!");
                        Console.WriteLine("Press any key to reset the game");
                        Console.ReadKey();
                        ResetField();
                        break;
                    }

                }   
                #endregion

                #region
                //Check whether the field is already used
                do
                {
                    try
                    {
                        Console.Write("\nPlayer {0}: Choose your field! ", player);
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch { Console.WriteLine("Please, enter an integer value"); }

                    if ((input == 1) && (matrix[0, 0] == '1'))
                        inputCorrect = true;
                    else if (((input == 2)) && (matrix[0, 1] == '2'))
                        inputCorrect = true;
                    else if ((input == 3) && (matrix[0, 2] == '3'))
                        inputCorrect = true;
                    else if ((input == 4) && (matrix[1, 0] == '4'))
                        inputCorrect = true;
                    else if ((input == 5) && (matrix[1, 1] == '5'))
                        inputCorrect = true;
                    else if ((input == 6) && (matrix[1, 2] == '6'))
                        inputCorrect = true;
                    else if ((input == 7) && (matrix[2, 0] == '7'))
                        inputCorrect = true;
                    else if ((input == 8) && (matrix[2, 1] == '8'))
                        inputCorrect = true;
                    else if ((input == 9) && (matrix[2, 2] == '9'))
                        inputCorrect = true;
                    else
                    {
                        Console.WriteLine("\nIncorrect input! Please, use another field");
                        inputCorrect = false;
                    }
               



                } while (!inputCorrect);

                
            } while (true);
                #endregion


        }

        public static void CreateField()
        {
            Console.Clear();
            Console.WriteLine("       |        |     ");
            Console.WriteLine("  {0}    |   {1}    |   {2}", matrix[0, 0], matrix[0, 1], matrix[0, 2]);
            Console.WriteLine("       |        |     ");
            Console.WriteLine("------------------------");
            Console.WriteLine("       |        |     ");
            Console.WriteLine("  {0}    |   {1}    |   {2}", matrix[1, 0], matrix[1, 1], matrix[1, 2]);
            Console.WriteLine("       |        |     ");
            Console.WriteLine("------------------------");
            Console.WriteLine("       |        |     ");
            Console.WriteLine("  {0}    |   {1}    |   {2}", matrix[2, 0], matrix[2, 1], matrix[2, 2]);
            Console.WriteLine("       |        |     ");
            turns++;
       
        }
        public static void XorO(char playerSign, int input)
        {
            
            switch(input)
            {
                case 1: matrix[0, 0] = playerSign; break;
                case 2: matrix[0, 1] = playerSign; break;
                case 3: matrix[0, 2] = playerSign; break;
                case 4: matrix[1, 0] = playerSign; break;
                case 5: matrix[1, 1] = playerSign; break;
                case 6: matrix[1, 2] = playerSign; break;
                case 7: matrix[2, 0] = playerSign; break;
                case 8: matrix[2, 1] = playerSign; break;
                case 9: matrix[2, 2] = playerSign; break;

            }
            
        }
        public static void ResetField()
        {

            char[,] matrixInitial =
            {
                 { '1','2','3'},
                 { '4','5','6'},
                 { '7','8','9'}
            };

            matrix = matrixInitial;
            turns = 0;
            CreateField();
            
        }
    }

}
