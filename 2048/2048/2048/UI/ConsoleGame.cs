using _2048.Logic;
using System;

namespace _2048.UI
{
    class ConsoleGame
    {
        public Board GameBoard { get; set; }
        public ConsoleGame(Board board)
        {
            GameBoard = board;
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
        public void PrintBoard()
        {

        }
    }
}
