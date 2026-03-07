using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("What is the magic number? ");
        //int number = int.Parse(Console.ReadLine());

        Random RandomGenerator = new Random();
        int RandomNumber = RandomGenerator.Next(1, 101);
        int guess = -1;

        while (guess != RandomNumber)
        {
            Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (RandomNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (RandomNumber < guess)
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