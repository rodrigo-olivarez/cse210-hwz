using System;
using Microsoft.Win32.SafeHandles;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        string name = PrompUserName();
        int number = PrompUserNumber();
        int squaredNumber = SquareNumber(number);
        DisplayResult(name, squaredNumber);

    }
    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!.");
    }
    static string PrompUserName()
    {
        Console.Write("Please enter your name: ");
        string username = Console.ReadLine();
        return username;
    }
    static int PrompUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int usernumber = int.Parse(Console.ReadLine());
        return usernumber;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string username, int square)
    {
        Console.WriteLine($"{username}, the square of your number is {square}.");
    }

}
        