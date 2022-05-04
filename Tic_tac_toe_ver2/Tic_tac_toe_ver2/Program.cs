using System;

namespace Tic_tac_toe_ver2
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
            int check_win = 0;
            bool win = false;
            string player_name = "";
            string player_win = "";
            //bool choose_number_flat = false;
            //string input_player = " ";
            Console.WriteLine("\n     #########################################");
            Console.WriteLine("     #########----- TIC TAC TOE -----#########");
            Console.WriteLine("     #########################################\n");
            do
            {
                Console.WriteLine("Please chosse player to play first:");
                Console.WriteLine("1.Player A");
                Console.WriteLine("2.Player B");
                try
                {
                    player = Int32.Parse(Console.ReadLine());
                    if (player == 1)
                    {
                        choose_player_flat = true;
                        sign_player = "X";
                        player_name = "Player A";
                    }
                    else if (player == 2)
                    {
                        choose_player_flat = true;
                        sign_player = "O";
                        player_name = "Player B";
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
                Print_Board(array_game, player_name, sign_player, win);

                Doing_Game(array_game, sign_player);

                #region //Comment out it - another insert input value on the array
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

                check_win = Check_To_Win(array_game);

                if (check_win == 1)
                {
                    win = true;
                    player_win = "Harry";
                }
                else if (check_win == 2)
                {
                    win = true;
                    player_win = "Anna";
                }
                else
                {
                    win = false;
                }
            } while (!win);
            Print_Board(array_game, player_name, sign_player, win);
            Console.WriteLine("\n###############################");
            Console.WriteLine($"####  The winner is {player_win}  ####");
            Console.WriteLine("###############################\n");
        }

        #region Check Win
        private static int Check_To_Win(string[,] array_game)
        {
            int check_win = 0;
            int score_to_win = 3;
            string[] sign_player_arr = { "X", "O" };
            Console.WriteLine($"This for test { array_game.GetLength(0)} and  {array_game.GetLength(1)} and h is {sign_player_arr.GetLength(0)}");
            for (int h = 0; h < sign_player_arr.GetLength(0); h++)
            {
                //Console.WriteLine("h is ok");
                for (int i = 0; i < array_game.GetLength(0); i++)
                {
                    //Console.WriteLine("i is ok");
                    for (int j = 0; j < array_game.GetLength(1); j++)
                    {
                        //Console.WriteLine("j is ok");
                        if (array_game[i, j] == sign_player_arr[h])
                        {
                            //Console.WriteLine($"Check sign is ok, sign is {sign_player_arr[h]} and value is {array_game[i, j]}");
                            //Check top to bottom
                            if (i <= (array_game.GetLength(0) - score_to_win))
                            {
                                Console.WriteLine($"array[{i}, {j}]with sign {sign_player_arr[h]} top to bottom is ok");
                                if (array_game[i, j] == array_game[i + 1, j] && array_game[i + 1, j] == array_game[i + 2, j])
                                {
                                    //Console.WriteLine("top to bottom detect to win!!!!!!!!!!!!!");
                                    if (sign_player_arr[h] == "X")
                                    {
                                        return check_win = 1;
                                    }
                                    else if (sign_player_arr[h] == "O")
                                    {
                                        return check_win = 2;
                                    }
                                }
                            }
                            //Check left to right
                            if (j <= (array_game.GetLength(1) - score_to_win))
                            {
                                Console.WriteLine($"array[{i}, {j}] with sigh {sign_player_arr[h]} left to right is ok");
                                if (array_game[i, j] == array_game[i, j + 1] && array_game[i, j + 1] == array_game[i, j + 2])
                                {
                                    Console.WriteLine("left to right detect to win!!!!!!!!!!!!!");
                                    if (sign_player_arr[h] == "X")
                                    {
                                        return check_win = 1;
                                    }
                                    else if (sign_player_arr[h] == "O")
                                    {
                                        return check_win = 2;
                                    }
                                }
                            }
                            //Check cross lef-top to right-bottom
                            if ((i <= (array_game.GetLength(0) - score_to_win)) && (j <= (array_game.GetLength(1) - score_to_win)))
                            {
                                if (array_game[i, j] == array_game[i + 1, j + 1] && array_game[i + 1, j + 1] == array_game[i + 2, j + 2])
                                {
                                    if (sign_player_arr[h] == "X")
                                    {
                                        return check_win = 1;
                                    }
                                    else if (sign_player_arr[h] == "O")
                                    {
                                        return check_win = 2;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return check_win = 0;
        }
        #endregion

        #region Doing Game
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
        #endregion

        #region Print Board on screen
        static void Print_Board(string[,] Barray_game, string player_name, string sign_player, bool win)
        {
            Console.WriteLine("\n     |-------|-------|-------|-------|-------|");
            for (int i = 0; i < Barray_game.GetLength(0); i++)
            {

                Console.WriteLine("     |       |       |       |       |       |");
                Console.Write("     |   ");
                for (int j = 0; j < Barray_game.GetLength(1); j++)
                {
                    if (Barray_game[i, j].Length == 1)
                    {
                        if (Barray_game[i, j] == "X")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{Barray_game[i, j]}");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("   |   ");
                        }
                        else if (Barray_game[i, j] == "O")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write($"{Barray_game[i, j]}");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("   |   ");
                        }
                        else
                        {
                            Console.Write($"{Barray_game[i, j]}");
                            Console.Write("   |   ");
                        }
                    }
                    else if (Barray_game[i, j].Length == 2)
                    {
                        if (Barray_game[i, j] == "X")
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write($"{Barray_game[i, j]}");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("  |   ");
                        }
                        else if (Barray_game[i, j] == "O")
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write($"{Barray_game[i, j]}");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("  |   ");
                        }
                        else
                        {
                            Console.Write($"{Barray_game[i, j]}");
                            Console.Write("  |   ");
                        }
                    }
                }
                Console.WriteLine("");
                Console.WriteLine("     |       |       |       |       |       |");
                Console.WriteLine("     |-------|-------|-------|-------|-------|");
            }
            if (win == false)
                Console.WriteLine($"\n-> Player {player_name} (with sign {sign_player}) turn, Please enter number:");
        }
        #endregion
    }
}
