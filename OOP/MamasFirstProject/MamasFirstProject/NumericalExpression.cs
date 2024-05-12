using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MamasFirstProject
{
    class NumericalExpression
    {
        public long Number;
        private string[] Ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        private string[] Teens = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
        private string[] Tens = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        private string[] Thousands = { "", "Thousand", "Million", "Billion", "Trillion" };
        public NumericalExpression(long number)
        {
            Number = number;
        }
        public string ConvertNumberToWordsUntilTens(long number)
        {
            string numberInWords = "";
            while(number > 0)
            {
                if (number >= 100)
                {
                    numberInWords += Ones[number / 100] + " Hundred ";
                    number %= 100;
                }

                if (number >= 10 && number <= 19)
                {
                    numberInWords += Teens[number % 10] + " ";
                    number = 0;
                }
                else
                {
                    numberInWords += Tens[number / 10] + " ";
                    numberInWords += Ones[number % 10] + " ";
                    number = 0;
                }

            }
            return numberInWords;
        }
        public string ConvertNumberToWords()
        {
            long number = Number;
            string numberInWords = "";
            long numberChunck = 0;
            int numberOfThousands = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(Convert.ToString(number).Length) / 3.0))-1;
            for (int i = 0; i < numberOfThousands+1; i++)
            {
                if(number < 3)
                {
                    numberChunck = number;
                }
                else
                {
                    numberChunck = number % 1000;
                }
                string chunkOfNumberInWords = ConvertNumberToWordsUntilTens(numberChunck);
                numberInWords = " " + chunkOfNumberInWords + Thousands[i] + numberInWords;
                number = number / 1000;
            }
            return numberInWords;
        }


    public override string ToString()
        {
            return ConvertNumberToWords();
        }
        public long GetValue()
        {
            return Number;
        }

    }
}
