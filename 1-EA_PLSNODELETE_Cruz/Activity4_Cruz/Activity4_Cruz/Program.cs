using System;
using System.Diagnostics.Eventing.Reader;

namespace Activity4_Cruz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Choices;
            string YesNo;
            double Toyota = 1500000, Honda = 1200000, Ford = 2300000, BMW = 2500000, Mercedes = 3000000, Installment, Percent, RemaininBalance;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine("WELCOME TO ABC CAR DEALERSHIP");

            Console.WriteLine("Choose a car brand");

            Console.SetCursorPosition(0, 3);
            Console.WriteLine("1. Toyota - P 1,500,000");

            Console.SetCursorPosition(0, 5);
            Console.WriteLine("2. Honda - P 1,200,000");

            Console.SetCursorPosition(0, 7);
            Console.WriteLine("3. Ford - P 2,300,000");

            Console.SetCursorPosition(0, 9);
            Console.WriteLine("4. BMW - P 2,500,000");

            Console.SetCursorPosition(0, 11);
            Console.WriteLine("5. Mercendes - P 3,000,000");

            Console.SetCursorPosition(0, 13);
            Console.Write("Enter the number of your chosen car brand: ");
            Choices = Convert.ToInt32(Console.ReadLine());

            switch (Choices)
            {
                case 1:
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("You Selected Toyota");
                    Console.WriteLine($"Price: {Toyota}");
                    Console.WriteLine();
                    Console.Write("Do you want to purchase this car? (Y/N): ");
                    YesNo = Console.ReadLine();

                    if (YesNo == "Y")
                    {

                        Percent = Toyota * .30;
                        Console.WriteLine($"Down Payment (30%), {Percent:n2}");

                        Console.SetCursorPosition(0, 19);
                        RemaininBalance = Toyota - Percent;
                        Console.WriteLine($"Remaining Balance: (30%), {RemaininBalance:n2}");

                        Console.SetCursorPosition(0, 21);
                        Installment = RemaininBalance / 60;
                        Console.WriteLine($"Montly Installment (For 5 Years): {Installment:n2}");
                    }
                    else
                    {
                        Console.WriteLine("Thank you for your time with us");
                    }
                    break;

            }

            switch (Choices)
            {

                case 2:
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("You Selected Honda");
                    Console.WriteLine($"Price: {Honda}");
                    Console.WriteLine();
                    Console.Write("Do you want to purchase this car? (Y/N): ");
                    YesNo = Console.ReadLine();


                    if (YesNo == "Y")
                    {

                        Percent = Honda * .30;
                        Console.WriteLine($"Down Payment (30%), {Percent:n2}");

                        Console.SetCursorPosition(0, 19);
                        RemaininBalance = Honda - Percent;
                        Console.WriteLine($"Remaining Balance: (30%), {RemaininBalance:n2}");

                        Console.SetCursorPosition(0, 21);
                        Installment = RemaininBalance / 60;
                        Console.WriteLine($"Montly Installment (For 5 Years): {Installment:n2}");
                    }
                    else
                    {
                        Console.WriteLine("Thank you for your time with us");
                    }
                    break;

            }
            switch (Choices)
            {

                case 3:
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("You Selected Ford");
                    Console.WriteLine($"Price: {Ford}");
                    Console.WriteLine();
                    Console.Write("Do you want to purchase this car? (Y/N): ");
                    YesNo = Console.ReadLine();


                    if (YesNo == "Y")
                    {

                        Percent = Ford * .30;
                        Console.WriteLine($"Down Payment (30%), {Percent:n2}");

                        Console.SetCursorPosition(0, 19);
                        RemaininBalance = Ford - Percent;
                        Console.WriteLine($"Remaining Balance: (30%), {RemaininBalance:n2}");

                        Console.SetCursorPosition(0, 21);
                        Installment = RemaininBalance / 60;
                        Console.WriteLine($"Montly Installment (For 5 Years): {Installment:n2}");
                    }
                    else
                    {
                        Console.WriteLine("Thank you for your time with us");
                    }
                    break;
            }
            switch (Choices)
            {

                case 4:
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("You Selected BMW");
                    Console.WriteLine($"Price: {BMW}");
                    Console.WriteLine();
                    Console.Write("Do you want to purchase this car? (Y/N): ");
                    YesNo = Console.ReadLine();


                    if (YesNo == "Y")
                    {

                        Percent = BMW * .30;
                        Console.WriteLine($"Down Payment (30%), {Percent:n2}");

                        Console.SetCursorPosition(0, 19);
                        RemaininBalance = BMW - Percent;
                        Console.WriteLine($"Remaining Balance: (30%), {RemaininBalance:n2}");

                        Console.SetCursorPosition(0, 21);
                        Installment = RemaininBalance / 60;
                        Console.WriteLine($"Montly Installment (For 5 Years): {Installment:n2}");
                    }
                    else
                    {
                        Console.WriteLine("Thank you for your time with us");
                    }
                    break;
            }
            switch (Choices)
            {

                case 5:
                    Console.SetCursorPosition(0, 14);
                    Console.WriteLine("You Selected Mercedes");
                    Console.WriteLine($"Price: {Mercedes}");
                    Console.WriteLine();
                    Console.Write("Do you want to purchase this car? (Y/N): ");
                    YesNo = Console.ReadLine();


                    if (YesNo == "Y")
                    {

                        Percent = Mercedes * .30;
                        Console.WriteLine($"Down Payment (30%), {Percent:n2}");

                        Console.SetCursorPosition(0, 19);
                        RemaininBalance = Mercedes - Percent;
                        Console.WriteLine($"Remaining Balance: (30%), {RemaininBalance:n2}");

                        Console.SetCursorPosition(0, 21);
                        Installment = RemaininBalance / 60;
                        Console.WriteLine($"Montly Installment (For 5 Years): {Installment:n2}");
                    }
                    else
                    {
                        Console.WriteLine("Thank you for your time with us");
                    }
                    break;
            }
        }
    }
}