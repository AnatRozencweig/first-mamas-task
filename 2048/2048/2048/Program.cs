using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2048.Logic;
namespace _2048
{
    class Program
    {
        static void Main(string[] args)
        {
            Board b = new Board();
            b.D
            //b.PlacesFirstTwoCells();
            PrintBoard(b.Data);
            Console.WriteLine("-----------------");
            b.MoveUp();
            PrintBoard(b.Data);

        }
        public static void PrintBoard(int[,] arr)
        {
            int xLen = arr.GetLength(0);
            int yLen = arr.GetLength(1);

            for (int i = 0; i < yLen; i++)
            {
                for (int j = 0; j < xLen; j++)
                {
                    Console.Write(string.Format("{0} ", arr[j, i]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
