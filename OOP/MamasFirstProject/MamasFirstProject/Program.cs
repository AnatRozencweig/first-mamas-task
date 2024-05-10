using System;


namespace MamasFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            NumericalExpression six = new NumericalExpression(3);
            
            Console.WriteLine(six.SumLetters());
        }
    }
}
