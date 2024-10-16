using System;
using System.Diagnostics.Eventing.Reader;

namespace PracticeLangto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2;

            string choices;

            Console.WriteLine("PLEASE ENTER THE NUMBER");

            Console.Write("Enter the 1 number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the 2 Number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("CHOOSE THE OPERATION, [A = +, S = - M = * D = /]: ");
            choices = Console.ReadLine();

            double result;

            if (choices == "A")
            {
                result = num1 + num2;

            }
            else if (choices == "S")
            {
                result = num1 - num2;

            }
            else if (choices == "M")
            {
                result = num1 * num2;

            }
            else
            {
                result = num1 / num2;

            }

            Console.WriteLine("Result: {0:F2}", result);
        }
    }
}
