using System;

namespace ticTacToe
{
    internal class Program
    {
        static string[,] gameArray = new string[3, 3]
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"}
        };

        private static void Main(string[] args)
        {
            var iterator = 1;
            var player = 2;
            var playerSign = "X";
            while (true)
            {
                if (player == 1)
                {
                    player = 2;
                    playerSign = "O";
                }
                else if (player == 2)
                {
                    player = 1;
                    playerSign = "X";
                }

                int input = 0;
                bool success = false;
                Console.Clear();
                GenerateBoard();

                string[] playerChars = {"X", "O"};

                foreach (string playerChar in playerChars)
                {
                    if ((gameArray[0, 0] == playerChar && gameArray[0, 1] == playerChar &&
                         gameArray[0, 2] == playerChar) ||
                        (gameArray[1, 0] == playerChar && gameArray[1, 1] == playerChar &&
                         gameArray[1, 2] == playerChar) ||
                        (gameArray[2, 0] == playerChar && gameArray[2, 1] == playerChar &&
                         gameArray[2, 2] == playerChar) ||
                        (gameArray[0, 0] == playerChar && gameArray[1, 0] == playerChar &&
                         gameArray[2, 0] == playerChar) ||
                        (gameArray[0, 1] == playerChar && gameArray[1, 1] == playerChar &&
                         gameArray[2, 1] == playerChar) ||
                        (gameArray[0, 2] == playerChar && gameArray[1, 2] == playerChar &&
                         gameArray[2, 2] == playerChar) ||
                        (gameArray[0, 0] == playerChar && gameArray[1, 1] == playerChar &&
                         gameArray[2, 2] == playerChar) ||
                        (gameArray[0, 2] == playerChar && gameArray[1, 1] == playerChar &&
                         gameArray[2, 0] == playerChar))
                    {
                        if (playerChar == "X")
                        {
                            Console.WriteLine("Player 1 has won!");
                        }
                        else if (playerChar == "O")
                        {
                            Console.WriteLine("Player 2 has won!");
                        }

                        Console.WriteLine("Click to reset your game!");
                        Console.ReadKey();
                        ResetGameBoard();
                        iterator = 1;
                        break;
                    }
                    else if (iterator == 10)
                    {
                        Console.WriteLine("DRAW!");
                        Console.WriteLine("Click to reset your game!");
                        Console.ReadKey();
                        ResetGameBoard();
                        iterator = 1;
                    }
                }

                do
                {
                    Console.WriteLine($"Player {player}: Choose your field!");
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please write a correct number");
                    }

                    if (input == 1 && gameArray[0, 0] == "1")
                        success = true;
                    else if (input == 2 && gameArray[0, 1] == "2")
                        success = true;
                    else if (input == 3 && gameArray[0, 2] == "3")
                        success = true;
                    else if (input == 4 && gameArray[1, 0] == "4")
                        success = true;
                    else if (input == 5 && gameArray[1, 1] == "5")
                        success = true;
                    else if (input == 6 && gameArray[1, 2] == "6")
                        success = true;
                    else if (input == 7 && gameArray[2, 0] == "7")
                        success = true;
                    else if (input == 8 && gameArray[2, 1] == "8")
                        success = true;
                    else if (input == 9 && gameArray[2, 2] == "9")
                        success = true;
                    else
                    {
                        Console.WriteLine("incorrect input!");
                        success = false;
                    }

                    if (success)
                    {
                        PlayerMove(input, playerSign);
                        iterator++;
                    }
                } while (!success);
            }
        }

        private static void PlayerMove(int number, string playerSign)
        {
            switch (number)
            {
                case 1:
                    gameArray[0, 0] = playerSign;
                    break;
                case 2:
                    gameArray[0, 1] = playerSign;
                    break;
                case 3:
                    gameArray[0, 2] = playerSign;
                    break;
                case 4:
                    gameArray[1, 0] = playerSign;
                    break;
                case 5:
                    gameArray[1, 1] = playerSign;
                    break;
                case 6:
                    gameArray[1, 2] = playerSign;
                    break;
                case 7:
                    gameArray[2, 0] = playerSign;
                    break;
                case 8:
                    gameArray[2, 1] = playerSign;
                    break;
                case 9:
                    gameArray[2, 2] = playerSign;
                    break;
            }
        }

        private static void ResetGameBoard()
        {
            string[,] gameArrayDefault = new string[3, 3]
            {
                {"1", "2", "3"},
                {"4", "5", "6"},
                {"7", "8", "9"}
            };

            gameArray = gameArrayDefault;
            Console.Clear();
            GenerateBoard();
        }

        private static void GenerateBoard()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {gameArray[0, 0]}  |  {gameArray[0, 1]}  |  {gameArray[0, 2]}   ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {gameArray[1, 0]}  |  {gameArray[1, 1]}  |  {gameArray[1, 2]}   ");
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine($"  {gameArray[2, 0]}  |  {gameArray[2, 1]}  |  {gameArray[2, 2]}   ");
            Console.WriteLine("     |     |     ");
        }
    }
}