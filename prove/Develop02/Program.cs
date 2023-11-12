using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your journal.");

        DateTime currentDateTime = DateTime.Now;
        Journal journal = new Journal();

        int userChoice = 0;
        while (userChoice != 5)
        {
            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            string userAnswer = Console.ReadLine();
            userChoice = int.Parse(userAnswer);
            
            if (userChoice == 1)
            {
                Entry entry = new Entry();
                PromptGenerator newPrompt = new PromptGenerator();

                Console.WriteLine(); 

                entry._promptText = newPrompt.GetRandomPrompt(); 

                string newEntry = Console.ReadLine();
                
                entry._entryText = newEntry;
                entry._date = currentDateTime.ToShortDateString();
                
                journal.AddEntry(entry);
                entry.Display();
                Console.WriteLine(); 
            }
            else if (userChoice == 2)
            {
                Console.WriteLine(); 
                journal.DisplayAll();
                Console.WriteLine();
            }
            else if (userChoice == 3)
            {
                Console.Write("Write the name of the file you would like to load: ");
                string fileName = Console.ReadLine();

                journal.LoadFromFile(fileName);
            }
            else if (userChoice == 4)
            {
                // Let the user name a new journal file
                Console.Write("How would you like to name your file? ");
                string fileName = Console.ReadLine();

                // Save the file
                journal.SaveToFile(fileName);
            }
        }
    }
}
    