using _2048.Logic;
using System;

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
            Console.SetCursorPosition(0, 2);
            Console.Write(string.Format("SCORE: {0}", Game.Points.ToString()));
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
                        Console.Write(".        ");
                    }
                    else
                    {
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
            Console.WriteLine("You lose");
        }
        public void WinScreen()
        {
            Console.WriteLine("You win");
        }
    }
}
