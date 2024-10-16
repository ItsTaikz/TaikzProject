using System;
using System.Data.SqlTypes;

namespace Activity2_Cruz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double SELLORGPRICE;
            double VATAM;
            double VATRATE;
           
            Console.Write("\n\n\t\tInput Original Selling Price: P");
            SELLORGPRICE = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            VATAM = ( SELLORGPRICE * 0.12) / (1 + 0.12);
            Console.WriteLine("\n\n\t\tVAT AMOUNT= {0:F2}", VATAM);

            double Total_Selling_Price = SELLORGPRICE + VATAM;
            Console.WriteLine("\n\n\t\tTotal Selling Price={0:F2}", Total_Selling_Price);
            Console.ReadKey(true);



            
            


           
            

            

           
                
        }
    }
}
