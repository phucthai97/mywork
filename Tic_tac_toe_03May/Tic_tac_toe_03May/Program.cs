using System;

namespace Tic_tac_toe_03May
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] array_game =
            {
                {"1", "2", "3", "4", "5"},
                {"6", "7", "8", "9", "10"},
                {"11", "12", "13", "14", "15"},
                {"16", "17", "18", "19", "20"},
                {"21", "22", "23", "24", "25"}
            };

            int player = 0;
            string sign_player = " "; //X or O
            bool choose_player_flat = false;
            bool win = false;
            //bool choose_number_flat = false;
            //string input_player = " ";

            do
            {
                Console.WriteLine("Please chosse phayer to play first:");
                Console.WriteLine("1.Harry");
                Console.WriteLine("2.Anna");
                try
                {
                    player = Int32.Parse(Console.ReadLine());
                    if (player == 1)
                    {
                        choose_player_flat = true;
                        sign_player = "X";
                    }
                    else if (player == 2)
                    {
                        choose_player_flat = true;
                        sign_player = "O";
                    }
                    else
                    {
                        choose_player_flat = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("It's not correct. Please choose again!");
                }
            } while (!choose_player_flat);

            do
            {
                Board_Game(array_game, player, sign_player);
                //array_game[,] = Doing_replace(sign_player);

                Doing_Game(array_game, sign_player);

                #region
                //do
                //{
                //    try
                //    {
                //        input_player = Console.ReadLine();
                //        for (int i = 0; i < array_game.GetLength(0); i++)
                //        {
                //            for (int j = 0; j < array_game.GetLength(1); j++)
                //            {
                //                if (array_game[i,j] == input_player)
                //                {
                //                    array_game[i, j] = sign_player;
                //                    choose_number_flat = true;
                //                }
                //            }
                //        } if (choose_number_flat == false)
                //        {
                //            Console.WriteLine("Input is not exits in board, please try again");
                //        }
                //    }
                //    catch (Exception)
                //    {
                //        Console.WriteLine("Input is not the number, please try again");
                //    }

                //} while (!choose_number_flat);
                #endregion
                #region
                //do
                //{
                //    try
                //    {
                //        input_player = Int32.Parse(Console.ReadLine());
                //        #region
                //        switch (input_player)
                //        {
                //            case 1:
                //                choose_number_flat = true;
                //                array_game[0, 0] = sign_player;
                //                break;
                //            case 2:
                //                choose_number_flat = true;
                //                array_game[0, 1] = sign_player;
                //                break;
                //            case 3:
                //                choose_number_flat = true;
                //                array_game[0, 2] = sign_player;
                //                break;
                //            case 4:
                //                choose_number_flat = true;
                //                array_game[0, 3] = sign_player;
                //                break;
                //            case 5:
                //                choose_number_flat = true;
                //                array_game[0, 4] = sign_player;
                //                break;
                //            case 6:
                //                choose_number_flat = true;
                //                array_game[1, 0] = sign_player;
                //                break;
                //            case 7:
                //                choose_number_flat = true;
                //                array_game[1, 1] = sign_player;
                //                break;
                //            case 8:
                //                choose_number_flat = true;
                //                array_game[1, 2] = sign_player;
                //                break;
                //            case 9:
                //                choose_number_flat = true;
                //                array_game[1, 3] = sign_player;
                //                break;
                //            case 10:
                //                choose_number_flat = true;
                //                array_game[1, 4] = sign_player;
                //                break;
                //            case 11:
                //                choose_number_flat = true;
                //                array_game[2, 0] = sign_player;
                //                break;
                //            case 12:
                //                choose_number_flat = true;
                //                array_game[2, 1] = sign_player;
                //                break;
                //            case 13:
                //                choose_number_flat = true;
                //                array_game[2, 2] = sign_player;
                //                break;
                //            case 14:
                //                choose_number_flat = true;
                //                array_game[2, 3] = sign_player;
                //                break;
                //            case 15:
                //                choose_number_flat = true;
                //                array_game[2, 4] = sign_player;
                //                break;
                //            case 16:
                //                choose_number_flat = true;
                //                array_game[3, 0] = sign_player;
                //                break;
                //            case 17:
                //                choose_number_flat = true;
                //                array_game[3, 1] = sign_player;
                //                break;
                //            case 18:
                //                choose_number_flat = true;
                //                array_game[3, 2] = sign_player;
                //                break;
                //            case 19:
                //                choose_number_flat = true;
                //                array_game[3, 3] = sign_player;
                //                break;
                //            case 20:
                //                choose_number_flat = true;
                //                array_game[3, 4] = sign_player;
                //                break;
                //            case 21:
                //                choose_number_flat = true;
                //                array_game[4, 0] = sign_player;
                //                break;
                //            case 22:
                //                choose_number_flat = true;
                //                array_game[4, 1] = sign_player;
                //                break;
                //            case 23:
                //                choose_number_flat = true;
                //                array_game[4, 2] = sign_player;
                //                break;
                //            case 24:
                //                choose_number_flat = true;
                //                array_game[4, 3] = sign_player;
                //                break;
                //            case 25:
                //                choose_number_flat = true;
                //                array_game[4, 4] = sign_player;
                //                break;
                //            default:
                //                choose_number_flat = false;
                //                break;
                //        }
                //        #endregion
                //    }
                //    catch (Exception)
                //    {
                //        Console.WriteLine("Number it not exits on board. Please re-enter again");
                //    }
                //} while (!choose_number_flat);
                #endregion

                //Board_Game(array_game, player);

                if (player == 1)
                {
                    player = 2;
                    sign_player = "O";
                }
                else if (player == 2)
                {
                    player = 1;
                    sign_player = "X";
                }
            } while (!win);
        }

        #region
        public static void Doing_Game(string[,] Darray_game, string sign_player)
        {
            bool choose_number_flat = false;
            string input_player = " ";
            do
            {
                bool Is_X_or_O = false;
                try
                {
                    input_player = Console.ReadLine().ToString();
                    //input_player_char = 
                    if (input_player == "X" || input_player == "O")
                    {
                        Is_X_or_O = true;
                        Console.WriteLine($"{input_player} is not valid! Please entern the number on matrix board.");
                    }
                    else
                    {
                        for (int i = 0; i < Darray_game.GetLength(0); i++)
                        {
                            for (int j = 0; j < Darray_game.GetLength(1); j++)
                            {
                                if (Darray_game[i, j] == input_player)
                                {
                                    Darray_game[i, j] = sign_player;
                                    choose_number_flat = true;
                                }
                            }
                        }
                    }
                    if (choose_number_flat == false && Is_X_or_O == false)
                    {
                        Console.WriteLine("Input is not exits in matrix board, please try again");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Input is not the number, please try again");
                }

            } while (!choose_number_flat);
        }

        static void Board_Game(string[,] Barray_game, int player_choose, string sign_player)
        {
            Console.WriteLine("-----------Game Tick Toe-----------\n\n");
            Console.WriteLine("     |-------|-------|-------|-------|-------|");
            for (int i = 0; i < Barray_game.GetLength(0); i++)
            {

                Console.WriteLine("     |       |       |       |       |       |");
                Console.Write("     |   ");
                for (int j = 0; j < Barray_game.GetLength(1); j++)
                {
                    if (Barray_game[i, j].Length == 1)
                    {
                        Console.Write($"{Barray_game[i, j]}   |   ");
                    }
                    else if (Barray_game[i, j].Length == 2)
                    {
                        Console.Write($"{Barray_game[i, j]}  |   ");
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("     |       |       |       |       |       |");
                Console.WriteLine("     |-------|-------|-------|-------|-------|");
            }
            Console.WriteLine($"\n-> Player {player_choose} (with sign {sign_player}) turn, Please enter number:");
        }
        #endregion
    }
}
