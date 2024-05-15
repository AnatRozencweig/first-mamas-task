using _2048.Logic;
using System;
using System.Collections.Generic; 

namespace _2048.UI
{
    class ConsoleGame
    {
        public Game Game { get; set; }
        public ConsoleGame(Game game)
        {
            Game = game;
        }
        public Direction GetDirection()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (char.ToUpper(keyInfo.KeyChar))
            {
                case 'W':
                    return Direction.Up;
                case 'S':
                    return Direction.Down;
                case 'A':
                    return Direction.Left;
                case 'D':
                    return Direction.Right;
                default:
                    throw new InvalidOperationException("You press invalid key"); ;
            }
        }
        public void PrintScore()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 2);
            Console.Write(string.Format("SCORE: {0}", Game.Points.ToString()));
        }
        public ConsoleColor MatchNumberColor(int number)
        {
            switch (number)
            {
                case 2:
                    return ConsoleColor.Blue;
                case 4:
                    return ConsoleColor.Green;
                case 8:
                    return ConsoleColor.Cyan;
                case 16:
                    return ConsoleColor.Red;
                case 32:
                    return ConsoleColor.Magenta;
                case 64:
                    return ConsoleColor.Yellow;
                case 128:
                    return ConsoleColor.DarkBlue;
                case 256:
                    return ConsoleColor.DarkGreen;
                case 512:
                    return ConsoleColor.DarkRed;
                case 1024:
                    return ConsoleColor.DarkMagenta;
                case 2048:
                    return ConsoleColor.DarkYellow;
                default:
                    throw new InvalidOperationException("this number is not in the options"); ;
            }
        }
        public void PrintBoard()
        {
            int xLen = Game.GameBoard.Data.GetLength(0);
            int yLen = Game.GameBoard.Data.GetLength(1);
            Console.SetCursorPosition(0, 10);
            for (int i = 0; i < yLen; i++)
            {
                for (int j = 0; j < xLen; j++)
                {
                    if(Game.GameBoard.Data[j, i] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(".        ");
                    }
                    else
                    {
                        Console.ForegroundColor = MatchNumberColor(Game.GameBoard.Data[j,i]);
                        Console.Write(string.Format("{0}        ", Game.GameBoard.Data[j, i]));
                    }
                }
                Console.Write("\n \n \n");
            }
        }
        public void ShowGameScreen()
        {
            PrintScore();
            PrintBoard();
        }
        public string QuitOrStartScreen()
        {
            Console.WriteLine("To start a new game enter s \n" +
                "To quit the game enter q");
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (char.ToUpper(keyInfo.KeyChar))
            {
                case 'Q':
                    return "quit";
                case 'S':
                    return "start";
                default:
                    throw new InvalidOperationException("You press invalid key"); ;
            }
        }
        public void LoseScreen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You lose");
        }
        public void WinScreen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("You win");
        }
    }
}
