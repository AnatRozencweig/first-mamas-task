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
            b.PlacesSpecificCell(2, 1, 2);
            b.PlacesSpecificCell(3, 1, 4);



            //b.PlacesFirstTwoCells();
            PrintBoard(b.Data);
            Console.WriteLine("-----------------");
            b.MoveRight();
            PrintBoard(b.Data);
            Console.WriteLine("-----------------");
           
        }
    }
}
