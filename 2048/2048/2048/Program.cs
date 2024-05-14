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
            b.PlacesSpecificCell(0, 3, 2);
            b.PlacesSpecificCell(2, 3, 2);
            b.PlacesSpecificCell(3, 3, 8);
            b.PlacesSpecificCell(0, 1, 2);
            b.PlacesSpecificCell(2, 1, 4);
            b.PlacesSpecificCell(3, 1, 8);



            //b.PlacesFirstTwoCells();
            PrintBoard(b.Data);
            Console.WriteLine("-----------------");
            b.MoveLeft();
            PrintBoard(b.Data);
            Console.WriteLine("-----------------");
           
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
