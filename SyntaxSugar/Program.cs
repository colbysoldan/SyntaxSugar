using System;

namespace SyntaxSugar
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var answer = 4;
            string response;
            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + " is greater than or equal to nine";
            }*/

            //same code, single line.
            //syntax suger, not necessarily best practice, but a lot shorter.
            var answer = 4;
            var response = answer < 9 ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

            Console.WriteLine(response);

            var x = 7;
            var y = -4;

            Console.WriteLine(Compare(x, y));


            Console.ReadLine();
        }

        public static string Compare(int num1, int num2)
        {
            //if-else
            //if(num1 > num2)
            //{
            //  return $"{num1} is greater than {num2}";
            //}
            //else
            //{
            //    return $"{num2} is greater than {num1}";
            //}

            //ternary
            return (num1 > num2) ? $"{num1} is greater than {num2}" : $"{num2} is greater than {num1}";
        }
    }
}

