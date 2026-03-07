using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number? ");
        int number = int.Parse(Console.ReadLine());
        int guess = -1;

        while (guess != number)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (number > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!!!");
            }    
        }
    }
}