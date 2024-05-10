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
        public string ConvertHundreds(long number)
        {
            string words = "";

            if (number >= 100)
            {
                words += Ones[number / 100] + " Hundred ";
                number %= 100;
            }

            if (number >= 10 && number <= 19)
            {
                words += Teens[number % 10] + " ";
            }
            else
            {
                words += Tens[number / 10] + " ";
                words += Ones[number % 10] + " ";
            }

            return words;
        }
        public string ConvertNumberToWords()
        {
            long number = Number;
            if (number == 0)
                return "Zero";

            string words = "";

            for (int i = 0; number > 0; i++)
            {
                if (number % 1000 != 0)
                    words = ConvertHundreds(number % 1000) + Thousands[i] + " " + words;

                number /= 1000;
            }

            return words.Trim();
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
