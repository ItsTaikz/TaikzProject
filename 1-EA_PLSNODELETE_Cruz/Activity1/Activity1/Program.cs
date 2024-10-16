using System;

namespace Activity1_Cruz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n\t\tThis program asks you to input Resistance (R) and Amperes (I) and compute the equivalent voltage");
            Console.WriteLine("");

            double R;
            Console.Write("\n\n\n\n\n\t\t\t\t\t\tEnter Value for resistance:");
            R = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            double I;
            Console.Write("\n\n\n\n\n\t\t\t\t\t\tEnter Value for resistance:");
            I = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            double V;
            V = I * R;

            Console.WriteLine("\n\n\n\n\n\t\t\t\t\t\tComputed Voltage:{0:F2}", V);
            Console.ReadKey(true);




        }
    }



}
