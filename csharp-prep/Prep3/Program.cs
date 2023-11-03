using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 50);

        int guess = -1;

        while (guess != magic)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magic > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magic < guess)
            {
                Console.WriteLine("Lower");
            }
            else 
            {
                Console.WriteLine("You guessed it");
            }
        }

    }   
}