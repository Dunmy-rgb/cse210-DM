using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the Exercise1 Project.");

        // Console.Write("What is your first name? ");
        // string firstName = Console.ReadLine();

        // Console.Write("What is your last name? ");
        // string lastName = Console.ReadLine();

        // Console.WriteLine($"Your name is {lastName} {firstName} {lastName}");

        // int x = 5;
        // int y = 4;

        // if (x > y)
        // {
        //     Console.Write("x is greater than y.");
        // }
        // else
        // {
        //     Console.Write("y is greater than x.");
        // }

        // string firstName = "Brigham";
        // string lastName = "Young";

        // if (firstName == "Brigham" && lastName == "Young")
        // {
        //     Console.WriteLine("Welcome Brother Brigham!");
        // }

        Console.Write("Enter a number: ");
        string UserInput = Console.ReadLine();

        int x = int.Parse(UserInput);
        int y = 7;
        int z = 3;

        if (x >= y && x >= z)
        {
            Console.Write("x is greater");
        }

        else if (x < y)
        {
            Console.Write("Less");
        }

        else
        {
            Console.Write("Equal");
        }
    }
}