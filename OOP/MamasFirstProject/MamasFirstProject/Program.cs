using System;


namespace MamasFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            NumericalExpression six = new NumericalExpression(999999999999);
            
            Console.WriteLine(six.ToString());
        }
        //The principle of polymorphism is manifested
        public static int SumLetters(long number)
        {
            NumericalExpression numberToSum = new NumericalExpression(number);
            string numberInWords = numberToSum.ToString();
            string trim = numberInWords.Replace(" ", "");
            return trim.Length;
        }
        public static int SumLetters(NumericalExpression number)
        {
            NumericalExpression numberToSum = new NumericalExpression(number.Number);
            string numberInWords = numberToSum.ToString();
            string trim = numberInWords.Replace(" ", "");
            return trim.Length;
        }
    }
}
