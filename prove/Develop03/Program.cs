using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new("Moroni", 10, 4, 5);
        Console.WriteLine();

        string text = "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with dreal intent, having efaith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may aknow the btruth of all things.";
        Scripture scripture = new(text,reference);
        

        while (!scripture.IsCompletlyHidden())
        {
            scripture.DisplayScripture();
            Console.WriteLine();
            Console.WriteLine("Welcome to Scripture Memorizer!");
            Console.WriteLine();
            Console.WriteLine("To 'Hide' a word press 'Enter'");
            Console.WriteLine("To 'Finish' type 'Quit'");
            string answer = Console.ReadLine().ToLower();
            scripture.HideRandomWords();

            if (answer == "quit")
            {
                break;
            }
            
        }
        
    }
}