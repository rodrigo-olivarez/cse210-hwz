using System;

class Program
{
    static void Main(string[] args)

    //I ADD A MOOD AND A QUESTION//
    {
        Journal thejournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string userChoice = "";


        while (userChoice != "5")
        {
            Console.WriteLine("Welcome to the Journal Program");
            Console.WriteLine("SELECT ONE:");
            Console.WriteLine();
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine();
            Console.Write("What Would you like to do? ");

            userChoice = Console.ReadLine();
            Console.WriteLine();
            if (userChoice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");
                Console.Write(">");
                string response = Console.ReadLine();

                Console.Write("How do you feel today (1-10)? ");
                string mood = Console.ReadLine();

                Entry newEntry = new Entry();
                newEntry._date = DateTime.Now.ToShortDateString();
                newEntry._prompText = prompt;
                newEntry._entryText = response;
                newEntry._mood = mood;

                thejournal.AddEntry(newEntry);
            }
            else if (userChoice == "2")
            {
                thejournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.Write("What es the filename? ");
                string filename = Console.ReadLine();
            }
            else if (userChoice == "4")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();
                thejournal.SaveToFile(filename);
            }
            else if (userChoice == "5")
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}