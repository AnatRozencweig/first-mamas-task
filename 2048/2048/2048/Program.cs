﻿
using _2048.Logic;
using _2048.UI;
using System;

namespace _2048
{
    class Program
    {
        static void Main(string[] args)
        {
            Board gameBoard = new Board();
            Game game = new Game(gameBoard);
            ConsoleGame screen = new ConsoleGame(game);
            game.GameBoard.PlacesFirstTwoCells();
            while (true)
            {
                screen.PrintBoard();
                Direction direction = screen.GetDirection();
                game.Move(direction);
                Console.Clear();
            }
        }
    }
}
