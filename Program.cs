using System;
using System.Xml.Serialization;

namespace Ewallet
{
    internal class Program
    {
        static double balance = 0.0;
        static void main()
        {
            ShowMenu();
        }
        int choice;

        do
        }
    Console.WriteLine("\====== GCASH APP ======");
Console.WriteLine("1. Check Balance ");
Console.WriteLine("2. Withdraw ");
Console.WriteLine("3. Deposit ");
Console.WriteLine("4. Exit ");
        Console.WriteLine(" Enter Choice ");

        choice = Convert.ToIn32(Console.ReadLine());

        if (choice == 1)
        Check Balance();
    else if (choice == 2)
        Withdraw();
    else if (choice == 3)
        Deposit();
    else if (choice == 4)
        ExitApp();
    else 
    Console.WriteLine(" Invalid Choice! ");


    }
